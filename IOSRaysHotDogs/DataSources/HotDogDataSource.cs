using System;
using System.Collections.Generic;
using Foundation;
using IOSRaysHotDogs.Cells;
using IOSRaysHotDogs.Utilities;
using RaysHotDogs.Core;
using UIKit;

namespace IOSRaysHotDogs.DataSources
{
    public class HotDogDataSource : UITableViewSource
    {

        private List<HotDog> hotDogs;
        NSString cellIdentifier = new NSString("HotDogCell");
        //helps IOS to reuse existing cells, Identifier can also be set within in the properties view under "Table View Cell"
        BaseUITableViewController callingController;

        public HotDogDataSource(List<HotDog> hotDogs, BaseUITableViewController callingController)
        {
            this.hotDogs = hotDogs;
            this.callingController = callingController;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return hotDogs.Count;
            //amount of items in a given section, this case we return the number of the entire list
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            //None custom cell
            //UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier) as UITableViewCell;

            //if (cell == null)
            //{
            //    cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
            //}

            //var hotDog = hotDogs[indexPath.Row];
            //cell.TextLabel.Text = hotDog.Name;
            //cell.ImageView.Image = UIImage.FromFile("Images/hotdog" + hotDog.HotDogId + ".jpg");

            //return cell;

            //Custom cell implementation
            HotDogListCell cell = tableView.DequeueReusableCell(cellIdentifier) as HotDogListCell;

            if (cell == null)
                cell = new HotDogListCell(cellIdentifier);

            cell.UpdateCell(hotDogs[indexPath.Row].Name
                , hotDogs[indexPath.Row].Price.ToString()
                , UIImage.FromFile("Images/hotdog" + hotDogs[indexPath.Row].HotDogId + ".jpg"));

            return cell;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var selectedHotDog = hotDogs[indexPath.Row];
            callingController.HotDogSelected(selectedHotDog);
            tableView.DeselectRow(indexPath, true);
        }

        public HotDog GetItem(int id)
        {
            return hotDogs[id];
        }
    }
}
