// <auto-generated>
#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Core
{
#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
#endif
	public partial interface ICoreWindow
	{
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		object AutomationHostProvider
		{
			get;
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		global::Windows.Foundation.Rect Bounds
		{
			get;
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		global::Windows.Foundation.Collections.IPropertySet CustomProperties
		{
			get;
		}
#endif
		// Skipping already declared property Dispatcher
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		global::Windows.UI.Core.CoreWindowFlowDirection FlowDirection
		{
			get;
			set;
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		bool IsInputEnabled
		{
			get;
			set;
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		global::Windows.UI.Core.CoreCursor PointerCursor
		{
			get;
			set;
		}
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		global::Windows.Foundation.Point PointerPosition
		{
			get;
		}
#endif
		// Skipping already declared property Visible
		// Forced skipping of method Windows.UI.Core.ICoreWindow.AutomationHostProvider.get
		// Forced skipping of method Windows.UI.Core.ICoreWindow.Bounds.get
		// Forced skipping of method Windows.UI.Core.ICoreWindow.CustomProperties.get
		// Forced skipping of method Windows.UI.Core.ICoreWindow.Dispatcher.get
		// Forced skipping of method Windows.UI.Core.ICoreWindow.FlowDirection.get
		// Forced skipping of method Windows.UI.Core.ICoreWindow.FlowDirection.set
		// Forced skipping of method Windows.UI.Core.ICoreWindow.IsInputEnabled.get
		// Forced skipping of method Windows.UI.Core.ICoreWindow.IsInputEnabled.set
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerCursor.get
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerCursor.set
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerPosition.get
		// Forced skipping of method Windows.UI.Core.ICoreWindow.Visible.get
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		void Activate();
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		void Close();
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		global::Windows.UI.Core.CoreVirtualKeyStates GetAsyncKeyState(global::Windows.System.VirtualKey virtualKey);
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		global::Windows.UI.Core.CoreVirtualKeyStates GetKeyState(global::Windows.System.VirtualKey virtualKey);
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		void ReleasePointerCapture();
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		void SetPointerCapture();
#endif
		// Forced skipping of method Windows.UI.Core.ICoreWindow.Activated.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.Activated.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.AutomationProviderRequested.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.AutomationProviderRequested.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.CharacterReceived.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.CharacterReceived.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.Closed.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.Closed.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.InputEnabled.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.InputEnabled.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.KeyDown.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.KeyDown.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.KeyUp.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.KeyUp.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerCaptureLost.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerCaptureLost.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerEntered.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerEntered.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerExited.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerExited.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerMoved.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerMoved.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerPressed.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerPressed.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerReleased.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerReleased.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.TouchHitTesting.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.TouchHitTesting.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerWheelChanged.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.PointerWheelChanged.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.SizeChanged.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.SizeChanged.remove
		// Forced skipping of method Windows.UI.Core.ICoreWindow.VisibilityChanged.add
		// Forced skipping of method Windows.UI.Core.ICoreWindow.VisibilityChanged.remove
		// Skipping already declared event Windows.UI.Core.ICoreWindow.Activated
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreWindow, global::Windows.UI.Core.AutomationProviderRequestedEventArgs> AutomationProviderRequested;
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreWindow, global::Windows.UI.Core.CharacterReceivedEventArgs> CharacterReceived;
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreWindow, global::Windows.UI.Core.CoreWindowEventArgs> Closed;
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreWindow, global::Windows.UI.Core.InputEnabledEventArgs> InputEnabled;
#endif
#if __ANDROID__ || false || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreWindow, global::Windows.UI.Core.KeyEventArgs> KeyDown;
#endif
#if __ANDROID__ || false || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreWindow, global::Windows.UI.Core.KeyEventArgs> KeyUp;
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreWindow, global::Windows.UI.Core.PointerEventArgs> PointerCaptureLost;
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreWindow, global::Windows.UI.Core.PointerEventArgs> PointerEntered;
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreWindow, global::Windows.UI.Core.PointerEventArgs> PointerExited;
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreWindow, global::Windows.UI.Core.PointerEventArgs> PointerMoved;
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreWindow, global::Windows.UI.Core.PointerEventArgs> PointerPressed;
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreWindow, global::Windows.UI.Core.PointerEventArgs> PointerReleased;
#endif
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreWindow, global::Windows.UI.Core.PointerEventArgs> PointerWheelChanged;
#endif
		// Skipping already declared event Windows.UI.Core.ICoreWindow.SizeChanged
#if __ANDROID__ || __IOS__ || __TVOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__
		event global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Core.CoreWindow, global::Windows.UI.Core.TouchHitTestingEventArgs> TouchHitTesting;
#endif
		// Skipping already declared event Windows.UI.Core.ICoreWindow.VisibilityChanged
	}
}
