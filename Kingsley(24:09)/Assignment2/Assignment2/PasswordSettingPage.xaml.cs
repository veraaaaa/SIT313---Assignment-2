using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment2
{
    public partial class PasswordSettingPage : ContentPage
    {
        public PasswordSettingPage()
        {
            InitializeComponent();
            var Oldpassword = new Label
            {
                Text = "Please enter your old password:",
            };
            var OPentry = new Entry
            {
                Placeholder = "Old Password",
                IsPassword = true
            };
            var Newpassword = new Label
            {
                Text = "Please enter your new password:",
            };
            var NPentry = new Entry
            {
                Placeholder = "New Password",
                IsPassword = true
            };
            var Confirm = new Label
            {
                Text = "Please re-enter your new password:",
            };
            var CPentry = new Entry
            {
                Placeholder = "Re-enter new Password",
                IsPassword = true
            };

            var clear = new Button
            {
                Text = "Clear all",
            };
            clear.Clicked += clear_clicked;

            void clear_clicked(object sender, EventArgs e)
            {
                OPentry.Text = "";
                NPentry.Text = "";
                CPentry.Text = "";
            }

            var submit = new Button
            {
                Text = "Submit",
            };
            submit.Clicked += submit_clicked;
            async void submit_clicked(object sender, EventArgs e)
            {
                if (NPentry.Text != CPentry.Text)
                {
                    await DisplayAlert("Reminder", "Please enter the same password and confirm password correctly", "OK");
                }
                //用foreach查找password然后更改
            }

            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,

                Children =
                {
                    new StackLayout
                    {
                        Children =
                        {
                            new Label
                            {
                                Text = "PassWord Setting",
                                FontSize = 30,
                                HorizontalTextAlignment = TextAlignment.Center,
                                TextColor = Color.Black,
                            },

                            new StackLayout
                            {
                                Children =
                                {
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Vertical,
                                        Children =
                                        {
                                            Oldpassword,
                                            OPentry,
                                        }
                                    },
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Vertical,
                                        Children =
                                        {
                                            Newpassword,
                                            NPentry,
                                        }
                                    },
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Vertical,
                                        Children =
                                        {
                                            Confirm,
                                            CPentry,
                                        }
                                    },
                                }
                            },
                            new StackLayout
                            {
                                Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                    clear,
                                    submit,
                                }
                            }
                        },

                    },

                }
            };
        }
    }
}
