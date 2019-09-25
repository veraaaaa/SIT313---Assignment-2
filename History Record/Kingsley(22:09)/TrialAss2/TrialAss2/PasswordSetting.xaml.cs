using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TrialAss2
{
    public partial class PasswordSetting : ContentPage
    {
        public PasswordSetting()
        {
            InitializeComponent();

            var Oldpassword = new Label
            {
                Text = "Please enter your old password:",
            };
            var Newpassword = new Label
            {
                Text = "Please enter your new password:",
            };
            var Confirm = new Label
            {
                Text = "Please re-enter your new password:",
            };

            Content = new StackLayout
            {
                Children =
                {

                }
            };
        }
    }
}
