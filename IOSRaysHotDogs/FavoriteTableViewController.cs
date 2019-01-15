using Foundation;
using IOSRaysHotDogs.DataSources;
using IOSRaysHotDogs.Utilities;
using RaysHotDogs.Core;
using System;
using UIKit;

namespace IOSRaysHotDogs
{
    public partial class FavoriteTableViewController : BaseUITableViewController
    {
        HotDogDataService dataService = new HotDogDataService();

        public FavoriteTableViewController(IntPtr handle) : base(handle)
        {
        }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var favorites = dataService.GetFavoriteHotDogs();
            TableView.Source = new HotDogDataSource(favorites, this);
            this.ParentViewController.NavigationItem.Title = "Ray's Favorites";
        }
    }
}