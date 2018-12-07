using System;
using System.Drawing;
using Foundation;
using UIKit;

namespace IOSRaysHotDogs.Cells
{
    public class HotDogListCell : UITableViewCell
    {

        UILabel nameLabel;
        UILabel priceLabel;
        UIImageView imageView;

        public HotDogListCell(NSString cellId) : base(UITableViewCellStyle.Default, cellId)
        {
            //Setting up the components on the cell
            SelectionStyle = UITableViewCellSelectionStyle.Gray;

            ContentView.BackgroundColor = UIColor.FromRGB(254, 199, 101);

            imageView = new UIImageView();

            nameLabel = new UILabel()
            {
                Font = UIFont.FromName("Cochin-BoldItalic", 18f),
                TextColor = UIColor.FromRGB(255, 255, 255),
                BackgroundColor = UIColor.Clear
            };

            priceLabel = new UILabel()
            {
                Font = UIFont.FromName("AmericanTypewriter", 12f),
                TextColor = UIColor.FromRGB(228, 79, 61),
                TextAlignment = UITextAlignment.Center,
                BackgroundColor = UIColor.Clear
            };

            ContentView.Add(nameLabel);
            ContentView.Add(priceLabel);
            ContentView.Add(imageView);
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            //Setting where the components should appear on the cell
            imageView.Frame = new RectangleF((float)ContentView.Bounds.Width - 63, 5, 33, 33);
            nameLabel.Frame = new RectangleF(5, 4, (float)ContentView.Bounds.Width - 63, 25);
            priceLabel.Frame = new RectangleF(200, 10, 100, 20);
        }

        public void UpdateCell (string caption, string subtitle, UIImage image)
        {
            imageView.Image = image;
            nameLabel.Text = caption;
            priceLabel.Text = subtitle;
        }
    }
}
