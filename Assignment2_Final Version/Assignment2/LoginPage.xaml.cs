using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment2
{
    public partial class LoginPage : ContentPage
    {
        public static List<CustomerInfo> LoginList = RegisterPage.NewCustomerList;

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
            
            Entry email = new Entry
            {
                Placeholder = "example@email.com",
                TextColor = Color.Black,
                Text = "",
            };

            Entry PassWord = new Entry
            {
                IsPassword = true,
                Text = "",
            };

            Login.Clicked += LoginBtn_clicked;
            Register.Clicked += RegisterBtn_clicked;

            async void RegisterBtn_clicked(object sender, EventArgs e)
            {
                await Navigation.PushAsync(new RegisterPage());
            }

            async void LoginBtn_clicked(object sender, EventArgs e)
            {
                var inputemail = email.Text;
                var inputpassword = PassWord.Text;

                bool _exist = false;

                foreach(var i in LoginList)
                {
                    if (i.email.Equals(inputemail)&&i.PassWord.Equals(inputpassword))
                    {
                        _exist = true;
                        break;
                    }
                    else if (i.email.Equals(inputemail) && i.PassWord!=inputpassword)
                    {
                        await DisplayAlert("Alert", "Please enter currect password!", "OK");
                        return;
                    }
                }
                if (_exist)
                {
                    await Navigation.PushAsync(new MainPage());
                }
                else 
                {
                    if (inputemail.Contains("@") && inputemail.Contains("."))
                    {
                        await DisplayAlert("Alert", "We can not find your account, please register your email!", "OK");
                        await Navigation.PushAsync(new RegisterPage());
                    }
                    else if ((inputemail == ""))
                    {
                        await DisplayAlert("Alert", "Please enter a valid email!", "OK");
                    }
                    else if (inputpassword == "")
                    {
                        await DisplayAlert("Alert", "Your password can not be empty!", "OK");
                    }
                    else
                    {
                        await DisplayAlert("Alert", "Please enter a valid email!", "OK");
                    }
                    
                }
                

            }
            
            
            

            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                FlowDirection = FlowDirection.LeftToRight,
                Children =
                {
                    new StackLayout
                    {
                        Children =
                        {

                            new StackLayout
                            {
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "WomenCare",
                                        FontSize = 30,
                                        HorizontalTextAlignment = TextAlignment.Center,
                                        TextColor = Color.Black,
                                        //image
                                    }
                                },
                            },
                            
                            new StackLayout
                            {
                                Orientation = StackOrientation.Vertical,
                                Children =
                                {
                                    new Label
                                    {
                                        Text="Email:",
                                        TextColor = Color.Black,
                                    },
                                    email,
                                }
                            },
                            new StackLayout
                            {
                                Orientation = StackOrientation.Vertical,
                                Children =
                                {
                                    new Label
                                    {
                                        Text="Password:",
                                        TextColor = Color.Black,
                                    },
                                    PassWord,
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
                        },
                    },
                    
                }
            };
        }


    }
}
