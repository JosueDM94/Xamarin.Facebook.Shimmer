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
	[Register ("ShimmerCell")]
	partial class ShimmerCell
	{
		[Outlet]
		UIKit.UIImageView imgView { get; set; }

		[Outlet]
		UIKit.UILabel lbl1 { get; set; }

		[Outlet]
		UIKit.UILabel lbl2 { get; set; }

		[Outlet]
		UIKit.UIView vwMain { get; set; }

		[Outlet]
		UIKit.UIView vwShimmer { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (vwShimmer != null) {
				vwShimmer.Dispose ();
				vwShimmer = null;
			}

			if (vwMain != null) {
				vwMain.Dispose ();
				vwMain = null;
			}

			if (lbl1 != null) {
				lbl1.Dispose ();
				lbl1 = null;
			}

			if (lbl2 != null) {
				lbl2.Dispose ();
				lbl2 = null;
			}

			if (imgView != null) {
				imgView.Dispose ();
				imgView = null;
			}
		}
	}
}
