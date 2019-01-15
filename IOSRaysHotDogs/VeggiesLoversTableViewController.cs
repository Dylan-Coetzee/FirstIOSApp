using Foundation;
using IOSRaysHotDogs.DataSources;
using IOSRaysHotDogs.Utilities;
using RaysHotDogs.Core;
using System;
using UIKit;

namespace IOSRaysHotDogs
{
    public partial class VeggiesLoversTableViewController : BaseUITableViewController
    {
        HotDogDataService dataService = new HotDogDataService();

        public VeggiesLoversTableViewController (IntPtr handle) : base (handle)
        {
        }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var meatLovers = dataService.GetHotDogsForGroup(2);
            var datasource = new HotDogDataSource(meatLovers, this);

            TableView.Source = datasource;

            this.ParentViewController.NavigationItem.Title = "Veggies Lovers";
        }
    }
}