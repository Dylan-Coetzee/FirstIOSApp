using Foundation;
using IOSRaysHotDogs.DataSources;
using IOSRaysHotDogs.Utilities;
using RaysHotDogs.Core;
using System;
using UIKit;

namespace IOSRaysHotDogs
{
    public partial class MeatLoversTableViewController : BaseUITableViewController
    {
        HotDogDataService dataService = new HotDogDataService();

        public MeatLoversTableViewController(IntPtr handle) : base(handle)
        {
        }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var meatLovers = dataService.GetHotDogsForGroup(1);
            var datasource = new HotDogDataSource(meatLovers, this);

            TableView.Source = datasource;

            this.ParentViewController.NavigationItem.Title = "Meat Lovers";
        }
    }
}