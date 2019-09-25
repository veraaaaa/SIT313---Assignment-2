using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms;

namespace Assignment2
{
    public partial class AboutUsPage : ContentPage
    {
        public AboutUsPage()
        {
            InitializeComponent();
            var editor = new Label { Text = "loading...", HeightRequest = 300 };

            
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(AboutUsPage)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("Assignment2.Features.txt");

            string text = "";
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            

            editor.Text = text;

            Content = new StackLayout
            {
                Margin = new Thickness(20),
                VerticalOptions = LayoutOptions.StartAndExpand,
                Children =
                {
                    new Label { Text = "SIT313-Assignment 2 (Group Work)",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        FontAttributes = FontAttributes.Bold,
                        HorizontalTextAlignment = TextAlignment.Center,
                    }, editor
                }
            };
        }
    }
}
