using System;
using System.Collections.Generic;
using Foundation;
using RaysHotDogs.Core;
using UIKit;

namespace IOSRaysHotDogs.DataSources
{
    public class HotDogDataSource : UITableViewSource
    {

        private List<HotDog> hotDogs;
        NSString cellIdentifier = new NSString("HotDogCell");

        public HotDogDataSource(List<HotDog> hotDogs, UITableViewController callingController)
        {
            this.hotDogs = hotDogs;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return hotDogs.Count;
            //amount of items in a given section, this case we return the number of the entire list
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier) as UITableViewCell;

            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            }

            var hotDog = hotDogs[indexPath.Row];
            cell.TextLabel.Text = hotDog.Name;
            cell.ImageView.Image = UIImage.FromFile("Images/hotdog" + hotDog.HotDogId + ".jpg");

            return cell;
        }

        public HotDog GetItem(int id)
        {
            return hotDogs[id];
        }
    }
}
