using System;
using UIKit;

namespace HelloWorld
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            HelloButton.PrimaryActionTriggered += async (sender, args) =>
            {
                var ip = await HttpBin.GetIp();

                var alert = UIAlertController.Create(
                    "Hello?",
                    $"Hello World!\nyour ip is {ip}",
                    UIAlertControllerStyle.Alert);

                alert.AddAction(
                    UIAlertAction.Create(
                        "Dismiss",
                        UIAlertActionStyle.Default,
                        null));

                PresentViewController(alert, true, null);
            };
        }
    }
}