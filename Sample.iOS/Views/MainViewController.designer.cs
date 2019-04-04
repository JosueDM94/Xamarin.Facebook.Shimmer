// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Sample.iOS.Views
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		UIKit.UIBarButtonItem btnRight { get; set; }

		[Outlet]
		UIKit.UITableView tblShimmer { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (tblShimmer != null) {
				tblShimmer.Dispose ();
				tblShimmer = null;
			}

			if (btnRight != null) {
				btnRight.Dispose ();
				btnRight = null;
			}
		}
	}
}
