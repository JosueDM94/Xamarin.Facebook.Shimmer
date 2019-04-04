using UIKit;
using System;
using Foundation;
using Facebook.Shimmer;

namespace Sample.iOS.Views
{
    public partial class ShimmerCell : UITableViewCell
    {
        public static readonly UINib Nib;
        public static readonly NSString Key = new NSString("ShimmerCell");

        public FBShimmeringView shimmeringView = new FBShimmeringView();

        static ShimmerCell()
        {
            Nib = UINib.FromName("ShimmerCell", NSBundle.MainBundle);
        }

        protected ShimmerCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            imgView.Layer.CornerRadius = imgView.Frame.Width / 2;
            imgView.ClipsToBounds = true;
            lbl1.Layer.CornerRadius = 5.0f;
            lbl1.ClipsToBounds = true;
            lbl2.Layer.CornerRadius = 5.0f;
            lbl2.ClipsToBounds = true;
        }

        public void UpdateCell(bool isLoaded)
        {
            vwShimmer.AddSubview(shimmeringView);
            shimmeringView.ContentView = vwMain;
            shimmeringView.Shimmering = !isLoaded;
            shimmeringView.ShimmeringSpeed = 1000;
            shimmeringView.ShimmeringBeginFadeDuration = 0.3;

            UIColor mycolor = isLoaded ? UIColor.Clear : UIColor.LightGray;
            imgView.BackgroundColor = mycolor;
            lbl1.BackgroundColor = mycolor;
            lbl2.BackgroundColor = mycolor;

            if (isLoaded)
            {
                // Show Your Original Content Here After You Fetch Your Data
                imgView.Image = UIImage.FromBundle(@"Facebook");
                lbl1.Text = @"Facebook";
                lbl2.Text = @":)";
            }
            else
            {
                // Dummy The Cell Until The Content Loads
                imgView.Image = null;
                lbl1.Text = @"";
                lbl2.Text = @"";
            }
        }

        public override bool Selected { get => base.Selected; set => base.Selected = value; }
    }
}