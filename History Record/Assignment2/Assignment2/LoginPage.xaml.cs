using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment2
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Button Login = new Button
            {
                Text="Login",
                TextColor = Color.Gray,
                BorderWidth = 2,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                WidthRequest = 130,
            };
            Button Register = new Button
            {
                Text = "Register",
                TextColor = Color.Gray,
                BorderWidth = 2,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                WidthRequest = 130,
            };
            Login.Clicked += LoginBtn_clicked;
            Register.Clicked += RegisterBtn_clicked;
            
            Editor PhoneNumber = new Editor
            {
                Placeholder = "123456",
                MaxLength = 10,
                AutoSize = EditorAutoSizeOption.TextChanges,
            };
            Editor UserName = new Editor
            {
                Placeholder = "Jack",
                MaxLength = 20,
                AutoSize = EditorAutoSizeOption.TextChanges,
            };

            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                FlowDirection = FlowDirection.LeftToRight,
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Vertical,
                        Children =
                        {
                            new Label
                            {
                                Text="Enter you phone number:",
                            },
                            PhoneNumber,
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Vertical,
                        Children =
                        {
                            new Label
                            {
                                Text="Enter you UserName:",
                            },
                            UserName,
                        }
                    },
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            Login,
                            Register,
                        }
                    },
                }
            };
        }

        async void RegisterBtn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        async void LoginBtn_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }
    }
}
