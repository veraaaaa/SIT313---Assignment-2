using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamForms.Controls;

namespace TrialAss2
{
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            InitializeComponent();

            Calendar calendar = new Calendar
            {
                SelectedDate = DateTime.Now,
                SelectedBorderColor = Color.Red,
            };
            calendar.

            Content = new StackLayout
            {
                Children =
                {
                    calendar,
                }
            };

        }
    }
}
