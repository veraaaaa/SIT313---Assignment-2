using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Assignment2
{
    public partial class RegisterPage : ContentPage
    {
        public static List<CustomerInfo> NewCustomerList = new List<CustomerInfo>();
        public static CustomerInfo NewCustomer = new CustomerInfo();

        public RegisterPage()
        {
            InitializeComponent();

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

            Button Register = new Button
            {
                Text = "Submit",
                TextColor = Color.Gray,
                BorderWidth = 2,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                WidthRequest = 130,
            };
          
            Register.Clicked += register_clicked;
            async void register_clicked(object sender, EventArgs e)
            {
                var inputemail = email.Text;
                var inputpassword = PassWord.Text;
                bool _exist = false;
                foreach(var i in NewCustomerList)
                {
                    if (i.email.Equals(inputemail))
                    {
                        _exist = true;
                        break;
                    }
                }
                if (_exist)
                {
                    await DisplayAlert("Alert", "The email address already exist, please try another one", "OK");
                }
                else
                {
                    CustomerInfo _newCustomer = new CustomerInfo();
                    _newCustomer.email = inputemail;
                    _newCustomer.PassWord = inputpassword;
                    NewCustomer = _newCustomer;
                    NewCustomerList.Add(NewCustomer);
                    await DisplayAlert("Message", "congratulation, you have registered successfully", "OK");
                    await Navigation.PushAsync(new LoginPage());
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
                                        Text = "Register account",
                                        FontSize = 20,
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
                                
                                VerticalOptions = LayoutOptions.CenterAndExpand,
                                HorizontalOptions = LayoutOptions.Center,
                                Margin = new Thickness(0,100,0,0),

                                Children =
                                {
                                    
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
