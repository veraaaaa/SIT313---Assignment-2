using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TrialAss2
{
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();

            List<CustomerInfo> customerInfos = Details.CustomerInfo;
            CustomerInfo Profile = Details.customerInfo;

            var username = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center
            };
            username.Text = Profile.UserName;

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
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
