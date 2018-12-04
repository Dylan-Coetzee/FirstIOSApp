using Foundation;
using RaysHotDogs.Core;
using System;
using System.Xml;
using UIKit;

namespace IOSRaysHotDogs
{
    public partial class HotDogViewController : UIViewController
    {

        public HotDog SelectedHotDog { get; set;}

        public HotDogViewController (IntPtr handle) : base (handle)
        {
            HotDogDataService hotDogDataService = new HotDogDataService();
            SelectedHotDog = hotDogDataService.GetHotDogById(1);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            DataBindUI();

            //User touched button and let go of the button
            AddToCartButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                UIAlertView message = new UIAlertView("Ray's Hot Dogs", "Your hot dog(s) was added to the cart.", null, "OK", null);
                message.Show();
            };

            CancelButton.TouchUpInside += (object sender, EventArgs e) =>
            {
                UIAlertView message = new UIAlertView("Cancel Order", "Your order is going to be cancelled.", null, "OK", null);
                message.Show();
            };

        }

        private void DataBindUI()
        {
            UIImage img = UIImage.FromFile("Images/" + SelectedHotDog.ImagePath + ".jpg");
            HotDogImageView.Image = img;
            NameLabel.Text = SelectedHotDog.Name;
            ShortDescriptionLabel.Text = SelectedHotDog.ShortDescription;
            LongDescriptionText.Text = SelectedHotDog.Description;
            PriceLabel.Text = "R" + SelectedHotDog.Price.ToString();
        }
    }
}