// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Add
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField numOneTextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField numTwoTextBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel resultLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton submitButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel titleLabel { get; set; }

        [Action ("submitClick:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void submitClick (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (numOneTextBox != null) {
                numOneTextBox.Dispose ();
                numOneTextBox = null;
            }

            if (numTwoTextBox != null) {
                numTwoTextBox.Dispose ();
                numTwoTextBox = null;
            }

            if (resultLabel != null) {
                resultLabel.Dispose ();
                resultLabel = null;
            }

            if (submitButton != null) {
                submitButton.Dispose ();
                submitButton = null;
            }

            if (titleLabel != null) {
                titleLabel.Dispose ();
                titleLabel = null;
            }
        }
    }
}