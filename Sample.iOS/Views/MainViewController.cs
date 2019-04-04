using UIKit;
using System;
using Foundation;

namespace Sample.iOS.Views
{
    public partial class MainViewController : UIViewController, IUITableViewDelegate, IUITableViewDataSource
    {
        bool isLoaded;

        public MainViewController() : base("MainViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            btnRight.Clicked += (sender, e) =>
            {
                isLoaded = !isLoaded;
                ((UIBarButtonItem)sender).Title = isLoaded ? "Start" : "Stop";
                tblShimmer.ReloadData();
            };

            tblShimmer.RegisterNibForCellReuse(ShimmerCell.Nib, ShimmerCell.Key);
            tblShimmer.DataSource = this;
            tblShimmer.Delegate = this;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return 6;
        }

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(ShimmerCell.Key, indexPath) as ShimmerCell;
            cell.UpdateCell(isLoaded);
            return cell;
        }
    }
}