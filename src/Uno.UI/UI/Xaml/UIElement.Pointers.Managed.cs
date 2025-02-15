﻿#if UNO_HAS_MANAGED_POINTERS
#nullable enable

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

using Uno.Disposables;
using Uno.Extensions;
using Uno.Foundation.Logging;
using Uno.UI.DataBinding;
using Uno.UI.Extensions;
using Windows.UI.Core;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Uno.UI;
using Uno.UI.Xaml;

#if HAS_UNO_WINUI
using Microsoft.UI.Input;
#else
using Windows.Devices.Input;
using Windows.UI.Input;
#endif

namespace Windows.UI.Xaml
{
	partial class UIElement
	{
		#region HitTestVisibility
		internal void UpdateHitTest()
		{
			this.CoerceValue(HitTestVisibilityProperty);
		}

		/// <summary>
		/// Represents the final calculated hit-test visibility of the element.
		/// </summary>
		/// <remarks>
		/// This property should never be directly set, and its value should always be calculated through coercion (see <see cref="CoerceHitTestVisibility(DependencyObject, object, bool)"/>.
		/// </remarks>
		[GeneratedDependencyProperty(DefaultValue = HitTestability.Collapsed, CoerceCallback = true, Options = FrameworkPropertyMetadataOptions.Inherits)]
		internal static DependencyProperty HitTestVisibilityProperty { get; } = CreateHitTestVisibilityProperty();

		internal HitTestability HitTestVisibility
		{
			get => GetHitTestVisibilityValue();
			set => SetHitTestVisibilityValue(value);
		}

		/// <summary>
		/// This calculates the final hit-test visibility of an element.
		/// </summary>
		/// <returns></returns>
		private object CoerceHitTestVisibility(object baseValue)
		{
			// The HitTestVisibilityProperty is never set directly. This means that baseValue is always the result of the parent's CoerceHitTestVisibility.
			var baseHitTestVisibility = (HitTestability)baseValue;

			// If the parent is collapsed, we should be collapsed as well. This takes priority over everything else, even if we would be visible otherwise.
			if (baseHitTestVisibility == HitTestability.Collapsed)
			{
				return HitTestability.Collapsed;
			}

			// If we're not locally hit-test visible, visible, or enabled, we should be collapsed. Our children will be collapsed as well.
			if (
#if !__MACOS__
				!IsLoaded ||
#endif
				!IsHitTestVisible || Visibility != Visibility.Visible || !IsEnabledOverride())
			{
				return HitTestability.Collapsed;
			}

			// If we're not hit (usually means we don't have a Background/Fill), we're invisible. Our children will be visible or not, depending on their state.
			if (!IsViewHit())
			{
				return HitTestability.Invisible;
			}

			// If we're not collapsed or invisible, we can be targeted by hit-testing. This means that we can be the source of pointer events.
			return HitTestability.Visible;
		}

		internal void SetHitTestVisibilityForRoot()
		{
			// Root element must be visible to hit testing, regardless of the other properties values.
			// The default value of HitTestVisibility is collapsed to avoid spending time coercing to a
			// Collapsed.
			HitTestVisibility = HitTestability.Visible;
		}

		internal void ClearHitTestVisibilityForRoot()
		{
			this.ClearValue(HitTestVisibilityProperty);
		}

		#endregion

		partial void CapturePointerNative(Pointer pointer)
			=> XamlRoot?.VisualTree.ContentRoot.InputManager!.SetPointerCapture(pointer.UniqueId);

		partial void ReleasePointerNative(Pointer pointer)
			=> XamlRoot?.VisualTree.ContentRoot.InputManager!.ReleasePointerCapture(pointer.UniqueId);
	}
}
#endif
