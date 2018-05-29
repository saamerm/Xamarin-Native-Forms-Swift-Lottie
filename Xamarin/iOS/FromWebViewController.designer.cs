// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace LottieTest.iOS
{
	[Register ("FromWebViewController")]
	partial class FromWebViewController
	{
		[Outlet]
		UIKit.UIView ContentView { get; set; }

		[Outlet]
		UIKit.UIButton Test1Button { get; set; }

		[Outlet]
		UIKit.UIButton Test2Button { get; set; }

		[Outlet]
		UIKit.UIButton Test3Button { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Test1Button != null) {
				Test1Button.Dispose ();
				Test1Button = null;
			}

			if (Test2Button != null) {
				Test2Button.Dispose ();
				Test2Button = null;
			}

			if (Test3Button != null) {
				Test3Button.Dispose ();
				Test3Button = null;
			}

			if (ContentView != null) {
				ContentView.Dispose ();
				ContentView = null;
			}
		}
	}
}
