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

        [Action ("submitClick:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void submitClick (Add.submitButton sender);

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
        }
    }
}