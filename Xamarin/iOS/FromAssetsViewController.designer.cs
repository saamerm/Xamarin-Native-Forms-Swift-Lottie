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
	[Register ("FromAssetsViewController")]
	partial class FromAssetsViewController
	{
		[Outlet]
		UIKit.UIButton RadioButton { get; set; }

		[Outlet]
		UIKit.UIView RadioContainer { get; set; }

		[Outlet]
		UIKit.UIButton WolfButton { get; set; }

		[Outlet]
		UIKit.UIView WolfView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (RadioButton != null) {
				RadioButton.Dispose ();
				RadioButton = null;
			}

			if (RadioContainer != null) {
				RadioContainer.Dispose ();
				RadioContainer = null;
			}

			if (WolfButton != null) {
				WolfButton.Dispose ();
				WolfButton = null;
			}

			if (WolfView != null) {
				WolfView.Dispose ();
				WolfView = null;
			}
		}
	}
}
