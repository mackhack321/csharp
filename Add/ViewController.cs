using System;

using UIKit;

namespace Add
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void submitClick(UIButton sender)
        {
            //throw new NotImplementedException();
            int numOne = int.Parse(numOneTextBox.Text);
            int numTwo = int.Parse(numTwoTextBox.Text);
            int result = numOne + numTwo;
            resultLabel.Text = result.ToString();
            resultLabel.Hidden = false;

            UIAlertView alert = new UIAlertView()
            {
                Title = "Result",
                Message = $"{numOne.ToString()}+{numTwo.ToString()}={result.ToString()}"
            };
            alert.AddButton("OK"); alert.Show();
        }
    }
}
