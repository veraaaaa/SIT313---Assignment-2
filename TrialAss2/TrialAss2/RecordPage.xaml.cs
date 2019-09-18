using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamForms.Controls;

namespace TrialAss2
{
    [DesignTimeVisible(false)]
    public partial class RecordPage : ContentPage
    {
        public RecordPage()
        {
            InitializeComponent();
            //calendar display
            Calendar calendar = new Calendar
            {
                SelectedDate = DateTime.Now,
                SelectedBorderColor = Color.Red,
            };
            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                FlowDirection = FlowDirection.LeftToRight,
                //Display calendar
                Children =
                {
                    calendar,
                    //record start date
                    new StackLayout
                {
                    Orientation = StackOrientation.Horizontal,
                    HeightRequest = 30,
                     Children =
                        {
                            new Image
                            {
                                Source = "start.png"
                            },
                            new Label
                            {
                                Text = "Start"
                            },
                            new Switch
                            {
                                IsToggled = true
                            },
                        }
                },
                    //record finish date
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        HeightRequest = 30,
                        Children =
                        {
                            new Image
                            {
                                Source = "finish.png"
                            },
                            new Label
                            {
                                Text = "Finish"
                            },
                            new Switch
                            {
                                IsToggled=true
                            },
                        }

                    },
                    //record detail
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        HeightRequest = 30,
                        Children =
                        {
                            new Image
                            {
                                Source = "analyse.png"
                            },
                            new Label
                            {
                                Text = "Detail"
                            },
                            new ImageButton
                            {
                                Source = "next.png"
                            },
                        }
                    },

                },

            };

        }
    }
}
