using System;
using UIKit;
using RaysHotDogs.Core;

namespace IOSRaysHotDogs.Utilities
{
	public class BaseUITableViewController: UITableViewController
	{
		public BaseUITableViewController () : base ("BaseUITableViewController", null)
		{
		}

		public BaseUITableViewController (IntPtr handle) : base (handle)
		{
		}


		public async void HotDogSelected(HotDog selectedHotDog)
		{
			HotDogViewController hotDogDetailViewController = 
				this.Storyboard.InstantiateViewController ("HotDogViewController") as HotDogViewController;
			if (hotDogDetailViewController != null)
			{
				hotDogDetailViewController.ModalTransitionStyle = UIModalTransitionStyle.PartialCurl;
				hotDogDetailViewController.SelectedHotDog = selectedHotDog;

				await PresentViewControllerAsync (hotDogDetailViewController, true);
			}

		}	
    }
}

