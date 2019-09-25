using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment2
{
    public partial class PasswordSettingPage : ContentPage
    {
        List<CustomerInfo> PasswordChange = LoginPage.LoginList;

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
                IsPassword = true,
                Text = null,
                
            };
            var Newpassword = new Label
            {
                Text = "Please enter your new password:",
            };
            var NPentry = new Entry
            {
                Placeholder = "New Password",
                IsPassword = true,
                Text = null,
            };
            var Confirm = new Label
            {
                Text = "Please re-enter your new password:",
            };
            var CPentry = new Entry
            {
                Placeholder = "Re-enter new Password",
                IsPassword = true,
                Text = null,
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
                var inputOldP = OPentry.Text;
                var inputNewP = NPentry.Text;
                var inputCP = CPentry.Text;
                bool _isoldpassword = false;
                
                foreach (var i in PasswordChange)
                {
                    if (i.PassWord.Equals(inputOldP))
                    {
                        _isoldpassword = true;
                        break;
                    }
                    else if(i.PassWord != inputOldP)
                    {
                        await DisplayAlert("Reminder", "Please enter the old password correctly", "OK");
                        return;
                    }
                }
                if (_isoldpassword)
                {
                    if (inputNewP == inputCP)
                    {
                        for (int i = 0; i< PasswordChange.Count; i++)
                        {
                            PasswordChange[i].PassWord = inputNewP;
                            await DisplayAlert("Reminder", "Your password has been changed sucessfully, you need to login again!", "OK");
                            await Navigation.PushAsync(new LoginPage());
                        }
                        
                    }
                    else if (inputNewP != inputCP)
                    {
                        await DisplayAlert("Reminder", "Please enter the same password and confirm password correctly", "OK");
                        return;
                    }
                }
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
                                Text = "Password Setting",
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
