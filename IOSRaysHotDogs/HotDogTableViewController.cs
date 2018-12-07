using Foundation;
using IOSRaysHotDogs.DataSources;
using IOSRaysHotDogs.Utilities;
using RaysHotDogs.Core;
using System;
using UIKit;

namespace IOSRaysHotDogs
{
    public partial class HotDogTableViewController : BaseUITableViewController
    {
        HotDogDataService dataService = new HotDogDataService();

        public HotDogTableViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            var hotDogs = dataService.GetAllHotDogs();
            var datasource = new HotDogDataSource(hotDogs, this);

            TableView.Source = datasource;

            this.NavigationItem.Title = "Ray's Hot Dog Menu";

            //base.ViewDidLoad();
        }

        //public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        //{
        //    base.PrepareForSegue(segue, sender);

        //    if (segue.Identifier == "HotDogDetailSegue")
        //    {
        //        var hotDogDetailViewController = segue.DestinationViewController as HotDogViewController;
        //        if (hotDogDetailViewController != null)
        //        {
        //            var source = TableView.Source as HotDogDataSource;
        //            var rowPath = TableView.IndexPathForSelectedRow;
        //            var item = source.GetItem(rowPath.Row);
        //            hotDogDetailViewController.SelectedHotDog = item;
        //        }

        //    }

        //}

        public async void HotDogSelected(HotDog selectedHotDog)
        {
            HotDogViewController hotDogViewController =
                this.Storyboard.InstantiateViewController("HotDogViewController") as HotDogViewController;

            if(hotDogViewController != null) 
            {
                hotDogViewController.ModalTransitionStyle = UIModalTransitionStyle.PartialCurl;
                hotDogViewController.SelectedHotDog = selectedHotDog;

                await PresentViewControllerAsync(hotDogViewController, true);
            }
        }
    }
}