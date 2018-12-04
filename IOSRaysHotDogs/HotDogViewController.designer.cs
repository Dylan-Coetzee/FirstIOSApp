// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace IOSRaysHotDogs
{
    [Register ("HotDogViewController")]
    partial class HotDogViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AddToCartButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField AmountText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CancelButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView HotDogImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView LongDescriptionText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel NameLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PriceLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel ShortDescriptionLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AddToCartButton != null) {
                AddToCartButton.Dispose ();
                AddToCartButton = null;
            }

            if (AmountText != null) {
                AmountText.Dispose ();
                AmountText = null;
            }

            if (CancelButton != null) {
                CancelButton.Dispose ();
                CancelButton = null;
            }

            if (HotDogImageView != null) {
                HotDogImageView.Dispose ();
                HotDogImageView = null;
            }

            if (LongDescriptionText != null) {
                LongDescriptionText.Dispose ();
                LongDescriptionText = null;
            }

            if (NameLabel != null) {
                NameLabel.Dispose ();
                NameLabel = null;
            }

            if (PriceLabel != null) {
                PriceLabel.Dispose ();
                PriceLabel = null;
            }

            if (ShortDescriptionLabel != null) {
                ShortDescriptionLabel.Dispose ();
                ShortDescriptionLabel = null;
            }
        }
    }
}