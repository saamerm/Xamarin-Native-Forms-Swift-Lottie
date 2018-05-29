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
	[Register ("ControlsViewController")]
	partial class ControlsViewController
	{
		[Outlet]
		UIKit.UIButton HideButton { get; set; }

		[Outlet]
		UIKit.UIButton ShowButton { get; set; }

		[Outlet]
		UIKit.UIView WolfVIew { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (WolfVIew != null) {
				WolfVIew.Dispose ();
				WolfVIew = null;
			}

			if (HideButton != null) {
				HideButton.Dispose ();
				HideButton = null;
			}

			if (ShowButton != null) {
				ShowButton.Dispose ();
				ShowButton = null;
			}
		}
	}
}
