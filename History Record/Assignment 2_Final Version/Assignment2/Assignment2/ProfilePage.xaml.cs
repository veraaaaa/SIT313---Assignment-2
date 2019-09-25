using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Assignment2
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            List<CustomerInfo> customerInfos = QueryPage2.CustomerInfo;
            CustomerInfo Profile = QueryPage2.customerInfo;

            var username = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center
            };
            username.Text = Profile.email;

            var age = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center
            };
            age.Text = Profile.Age;

            var cycleday = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center
            };
            cycleday.Text = Profile.CycleDay;

            var menstrualday = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center
            };
            menstrualday.Text = Profile.MenstrualDay.ToString();

            var menstrualperiod = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center
            };
            menstrualperiod.Text = Profile.LmenstrualDay.ToString("dd / MMM / yyyy");

            var AccountSetting = new Button
            {
                Text = "Account Setting",
                BackgroundColor = Color.GhostWhite,
                WidthRequest = 250,
            };
            var PasswordSetting = new Button
            {
                Text = "Password Setting",
                BackgroundColor = Color.GhostWhite,
                WidthRequest = 250,
            };
            var AboutUs = new Button
            {
                Text = "About Us",
                BackgroundColor = Color.GhostWhite,
                WidthRequest = 250,
            };
            /*
            var notification_label = new Label
            {
                Text = "No",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Black,
            };
            
            //notification_label.FontSize = 15;
            Switch notification = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                IsToggled = false,
            };
            */
            AccountSetting.Clicked += Account_clicked;
            PasswordSetting.Clicked += Password_clicked;
            AboutUs.Clicked += Aboutus_clicked;

            async void Account_clicked(object sender, System.EventArgs e)
            {
                await Navigation.PushAsync(new AccountSettingPage());
            }
            async void Password_clicked(object sender, System.EventArgs e)
            {
                await Navigation.PushAsync(new PasswordSettingPage());
            }
            async void Aboutus_clicked(object sender, System.EventArgs e)
            {
                await Navigation.PushAsync(new AboutUsPage());
            }

            Content = new StackLayout
            {
                BackgroundColor = Color.GhostWhite,
                Orientation = StackOrientation.Vertical,

                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Vertical,
                        Children =
                        {
                            new StackLayout
                            {
                                Orientation = StackOrientation.Vertical,

                                Children =
                                {
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Horizontal,

                                        Children =
                                        {
                                            new Label
                                            {
                                                Text = "Your Age is: ",
                                            },
                                            age,
                                        }
                                    },
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Horizontal,

                                        Children =
                                        {
                                            new Label
                                            {
                                                Text="Your Cycle days are: ",
                                            },
                                            cycleday,
                                        }
                                    },
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Horizontal,

                                        Children =
                                        {
                                            new Label
                                            {
                                                Text="Your menstrual days are: ",
                                            },
                                            menstrualday,
                                        }
                                    },
                                },
                            },
                            /*
                            new StackLayout
                                    {
                                        Orientation=StackOrientation.Horizontal,

                                        Children =
                                        {
                                            new StackLayout
                                            {
                                                WidthRequest = 250,
                                                Children =
                                                {
                                                    new Label
                                                    {
                                                        Text="Notification",
                                                        Margin = new Thickness(0,5,0,0)

                                                    }
                                                }
                                            },
                                            new StackLayout
                                            {
                                                WidthRequest = 30,
                                                Children =
                                                {

                                                    notification_label,
                                                }
                                            },
                                            new StackLayout
                                            {
                                                Children =
                                                {
                                                   notification,
                                                }
                                            }
                                        }
                                    },
                                    */
                            new StackLayout
                            {
                                Orientation = StackOrientation.Vertical,
                                VerticalOptions = LayoutOptions.CenterAndExpand,
                                HorizontalOptions = LayoutOptions.Center,
                                Margin = new Thickness(0,100,0,0),

                                Children =
                                {
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Horizontal,


                                        Children =
                                        {
                                            AccountSetting,
                                        }
                                    },
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Horizontal,

                                        Children =
                                        {
                                            PasswordSetting,
                                        }
                                    },
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Horizontal,

                                        Children =
                                        {
                                            AboutUs,
                                        }
                                    },

                                },

                            }
                        }
                    }
                }
            };
        }
    }
}
