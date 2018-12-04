using Foundation;
using IOSRaysHotDogs.DataSources;
using RaysHotDogs.Core;
using System;
using UIKit;

namespace IOSRaysHotDogs
{
    public partial class HotDogTableViewController : UITableViewController
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

            //base.ViewDidLoad();
        }
    }
}