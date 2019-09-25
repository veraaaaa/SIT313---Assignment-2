using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment2
{
    public partial class AccountSettingPage : ContentPage
    {
        List<CustomerInfo> Logout = LoginPage.LoginList;
        CustomerInfo logout = RegisterPage.NewCustomer;

        public AccountSettingPage()
        {
            InitializeComponent();

            var email = new Label
            {
                Text = "Hello ",
                FontSize = 20,
                TextColor = Color.Black,
            };
            var email2 = new Label
            {
                FontSize = 20,
                TextColor = Color.Black,
            };
            email2.Text = logout.email;

            var LogoutBtn = new Button
            {
                Text = "Logout",
                TextColor = Color.Black,
                BorderColor = Color.White,
            };
            LogoutBtn.Clicked += logoutbtn_clicked;

            async void logoutbtn_clicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new LoginPage());
            }

            Content = new StackLayout
            {
                
                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            new StackLayout
                            {
                                Children =
                                {
                                    email,
                                }
                            },
                            new StackLayout
                            {
                                Children =
                                {
                                    email2,
                                }
                            },
                        }
                    },
                    new StackLayout
                    {
                        Children =
                        {
                            LogoutBtn,
                        }
                    }
                }
            };
        }
    }
}
