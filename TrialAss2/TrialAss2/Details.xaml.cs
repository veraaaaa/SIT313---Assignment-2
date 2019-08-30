using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;


namespace TrialAss2
{
    public partial class Details : ContentPage
    {
        public Details()
        {
            InitializeComponent();

            var Age = new Label();

            var picker = new Picker
            {
                Title = "",
                WidthRequest = 25,
                FontSize = 15,
                Margin = new Thickness(100, 22, 20, 0)

            };
            for (int i = 18; i <= 50; i++)
            {
                picker.Items.Add(i.ToString());
            }
            picker.SelectedIndexChanged += (sender, e) =>
            {
                int selectedIndex = picker.SelectedIndex;
                if (selectedIndex != -1)
                {
                    Age.Text = picker.Items[selectedIndex];

                }
                picker.TextColor = Color.DarkRed;
            };

            var picker2 = new Picker
            {
                Title = "",
                WidthRequest = 25,
                FontSize = 15,
                Margin = new Thickness(100, 22, 20, 0)

            };
            for (int i = 15; i <= 90; i++)
            {
                picker2.Items.Add(i.ToString());
            }
            picker2.SelectedIndexChanged += (sender, e) =>
            {
                int selectedIndex = picker2.SelectedIndex;
                if (selectedIndex != -1)
                {
                    Age.Text = picker2.Items[selectedIndex];

                }
                picker2.TextColor = Color.DarkRed;
            };

            var picker3 = new Picker
            {
                Title = "",
                WidthRequest = 25,
                FontSize = 15,
                Margin = new Thickness(100, 22, 20, 0)

            };
            for (int i = 1; i <= 15; i++)
            {
                picker3.Items.Add(i.ToString());
            }
            picker3.SelectedIndexChanged += (sender, e) =>
            {
                int selectedIndex = picker3.SelectedIndex;
                if (selectedIndex != -1)
                {
                    Age.Text = picker3.Items[selectedIndex];

                }
                picker3.TextColor = Color.DarkRed;
            };

            DatePicker datePicker = new DatePicker
            {
                MinimumDate = new DateTime(1, 1, 1),
                MaximumDate = new DateTime(9999, 12, 31),
                Date = DateTime.Now,
                TextColor = Color.DarkRed,
                Margin = new Thickness(50, 22, 20, 0),
            };
            var Button = new Button
            {
                Text = "Next Step",
                TextColor = Color.White,
                HeightRequest = 62,
                WidthRequest = 201,
                VerticalOptions = LayoutOptions.EndAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.MediumSeaGreen,
                Margin = new Thickness(0, 200, 0, 0),
            };
            Button.Clicked += ButtonClicked;
            var stackLayout = new StackLayout
            {
                Children =
                {
                    Button,
                }
            };


            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                HeightRequest=300,
                Spacing=20,

                Children =
                {
                    new StackLayout
                    {
                        Children=
                        {
                            new Label
                            {
                                Text = "Tell us more about you",
                                Margin = new Thickness(14, 17, 20, 0),
                                HeightRequest = 54,
                                WidthRequest = 350,
                                HorizontalTextAlignment = TextAlignment.Center,
                                FontSize = 15,
                                TextColor = Color.Black,
                                HorizontalOptions = LayoutOptions.CenterAndExpand
                            },
                            new StackLayout
                            {
                                Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "Your current age is: ",
                                        TextColor = Color.Black,
                                        Margin = new Thickness(5, 35, 20, 0),
                                        FontSize = 15,
                                        WidthRequest = 200,

                                    },
                                    picker
                                }
                            },
                            new StackLayout
                            {

                                Orientation = StackOrientation.Horizontal,

                                Children =
                                {

                                    new Label
                                    {
                                        Text = "Your cycle days are：",
                                        TextColor = Color.Black,
                                        Margin = new Thickness(5, 35, 20, 0),
                                        FontSize = 15,
                                        WidthRequest = 200,

                                    },
                                    picker2
                                }
                            },
                            new StackLayout
                            {
                                Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "Your menstrual days are:",
                                        TextColor = Color.Black,
                                        Margin = new Thickness(5, 35, 20, 0),
                                        FontSize = 15,
                                        WidthRequest = 200,

                                    },
                                    picker3
                                }
                            },
                            new StackLayout
                            {
                                Orientation = StackOrientation.Horizontal,
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "Your last menstrual period was:",
                                        TextColor = Color.Black,
                                        Margin = new Thickness(5, 35, 20, 0),
                                        FontSize = 15,
                                        WidthRequest = 230,

                                    },
                                    datePicker
                                }
                            },
                        },
                    },
                    stackLayout,
                }

            };


        }
        async void ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
