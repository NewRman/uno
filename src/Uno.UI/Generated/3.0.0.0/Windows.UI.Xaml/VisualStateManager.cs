#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class VisualStateManager : global::Windows.UI.Xaml.DependencyObject
	{
		// Skipping already declared property CustomVisualStateManagerProperty
		// Skipping already declared method Windows.UI.Xaml.VisualStateManager.VisualStateManager()
		// Forced skipping of method Windows.UI.Xaml.VisualStateManager.VisualStateManager()
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected  void RaiseCurrentStateChanging( global::Windows.UI.Xaml.VisualStateGroup stateGroup,  global::Windows.UI.Xaml.VisualState oldState,  global::Windows.UI.Xaml.VisualState newState,  global::Windows.UI.Xaml.Controls.Control control)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.VisualStateManager", "void VisualStateManager.RaiseCurrentStateChanging(VisualStateGroup stateGroup, VisualState oldState, VisualState newState, Control control)");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		protected  void RaiseCurrentStateChanged( global::Windows.UI.Xaml.VisualStateGroup stateGroup,  global::Windows.UI.Xaml.VisualState oldState,  global::Windows.UI.Xaml.VisualState newState,  global::Windows.UI.Xaml.Controls.Control control)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.VisualStateManager", "void VisualStateManager.RaiseCurrentStateChanged(VisualStateGroup stateGroup, VisualState oldState, VisualState newState, Control control)");
		}
		#endif
		// Skipping already declared method Windows.UI.Xaml.VisualStateManager.GoToStateCore(Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.FrameworkElement, string, Windows.UI.Xaml.VisualStateGroup, Windows.UI.Xaml.VisualState, bool)
		// Skipping already declared method Windows.UI.Xaml.VisualStateManager.GetVisualStateGroups(Windows.UI.Xaml.FrameworkElement)
		// Forced skipping of method Windows.UI.Xaml.VisualStateManager.CustomVisualStateManagerProperty.get
		// Skipping already declared method Windows.UI.Xaml.VisualStateManager.GetCustomVisualStateManager(Windows.UI.Xaml.FrameworkElement)
		// Skipping already declared method Windows.UI.Xaml.VisualStateManager.SetCustomVisualStateManager(Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.VisualStateManager)
		// Skipping already declared method Windows.UI.Xaml.VisualStateManager.GoToState(Windows.UI.Xaml.Controls.Control, string, bool)
	}
}
