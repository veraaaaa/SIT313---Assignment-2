using System;
using System.Collections.Generic;
using System.Linq;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using XamForms.Controls;

namespace TrialAss2
{
    public partial class CalendarPage : ContentPage
    {
        public static List<RecordDetails> CalenderEntry = new List<RecordDetails>();
        public static RecordDetails NewSpecifcday = new RecordDetails();
        public List<DateTime> Cycleloop = new List<DateTime>();
        public List<DateTime> Menlistdate = new List<DateTime>();
        public List<DateTime> Ovualistdate = new List<DateTime>();
        public static CustomerInfo Days = new CustomerInfo();

        private DateTime CurrentDateTime = DateTime.Now;

        private static bool IsSameDay(DateTime ldt, DateTime rdt)
        {
            return ldt.Year == rdt.Year && ldt.Month == rdt.Month && ldt.Day == rdt.Day;
        }

        private static void SetBreakfast(DateTime dt, bool flag)
        {
            foreach (RecordDetails Selectdate in CalenderEntry)
            {
                if (IsSameDay(Selectdate.SpecificDate, dt))
                {
                    Selectdate.breakfast = flag;
                    return;
                }
            }
            RecordDetails _selectdate = new RecordDetails();
            _selectdate.breakfast = flag;
            _selectdate.SpecificDate = dt;
            CalenderEntry.Add(_selectdate);
        }
        public CalendarPage()
        {
            InitializeComponent();

            List<CustomerInfo> customerInfos = Details.CustomerInfo;
            CustomerInfo specialdate = Details.customerInfo;

            var Menstrualdays = Convert.ToInt32(specialdate.MenstrualDay);//经期天数
            var _periodStartday = specialdate.LmenstrualDay.Day.ToString();
            var PeriodStartday = Convert.ToInt32(_periodStartday); //经期开始日子
            var _periodEndday = specialdate.LmenstrualDay.AddDays(Menstrualdays).Day.ToString();
            var PeriodEndday = Convert.ToInt32(_periodEndday);//经期结束日子
            int CyclePeriod = Convert.ToInt32(specialdate.CycleDay);
            int Ovualation = 10;
            var BCyclePeriod = 14;
            var Cycleday = CyclePeriod - BCyclePeriod;

            //Set new Calendar:
            Calendar calendar = new Calendar
            {
                SelectedDate = DateTime.Now,
                SelectedBorderColor = Color.Red,
                HeightRequest = 300,
            };
            List<SpecialDate> newList = new List<SpecialDate>();
            List<SpecialDate> newList2 = new List<SpecialDate>();
            List<SpecialDate> newList3 = new List<SpecialDate>();
            //Set calendar specialdate color:
            calendar.SpecialDates = new List<SpecialDate>();
            for (int z = 0; z < CyclePeriod; z++)
            {
                var Alldate = specialdate.LmenstrualDay.AddDays(z);
                Cycleloop.Add(Alldate);
                newList.Add(new SpecialDate(Cycleloop[z]));
            }
            for (int c = Cycleday; c < Cycleday + Ovualation; c++)
            {
                newList2.Add(newList[c]);
                foreach (SpecialDate a in newList2)
                {
                    a.Selectable = true;
                    a.BackgroundColor = Color.MediumPurple;
                }
            }
            for (int i = 0; i < Menstrualdays; i++)
            {
                Menlistdate.Add(specialdate.LmenstrualDay.AddDays(i));

                newList3.Add(new SpecialDate(Menlistdate[i]));

                foreach (SpecialDate s in newList3)
                {
                    s.Selectable = true;
                    s.BackgroundColor = Color.HotPink;
                }

            }
            for (int a = 0; a < Menstrualdays; a++)
            {
                newList2.Add(newList3[a]);
                bool _istrue = true;
                if (_istrue)
                {
                    calendar.SpecialDates = newList2;
                }

            }
            //Color statement:
            BoxView boxView2 = new BoxView
            {
                Color = Color.MediumPurple,
                WidthRequest = 30,
                HeightRequest = 30,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            BoxView boxView = new BoxView
            {
                Color = Color.HotPink,
                WidthRequest = 30,
                HeightRequest = 30,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            //dateclicked yes/no
            var label = new Label
            {
                Text = "No",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Black,
            };
            label.FontSize = 15;
            Switch breakfast = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                IsToggled = false,
            };
            calendar.DateClicked += (object sender2, DateTimeEventArgs a) =>
            {
                CurrentDateTime = a.DateTime;
                bool breakfast_flag = false;
                foreach (RecordDetails Selectdate in CalenderEntry)
                {
                    if (Selectdate.SpecificDate.Equals(a.DateTime) && Selectdate.breakfast == true)
                    {
                        breakfast_flag = true;
                        break;
                    }
                }
                breakfast.IsToggled = breakfast_flag;
                label.Text = String.Format(breakfast_flag ? "Yes" : "No");
            };
            breakfast.Toggled += breakfast_Toggled;
            void breakfast_Toggled(object sender, ToggledEventArgs e)
            {
                bool value = e.Value;
                if (value == true)
                {
                    SetBreakfast(CurrentDateTime, true);
                    label.Text = String.Format("Yes");
                }
                else
                {
                    SetBreakfast(CurrentDateTime, false);
                    label.Text = String.Format("No");
                }
            }
            

            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,

                Children =
                    {
                    new StackLayout
                    {
                        BackgroundColor = Color.White,
                        Children =
                        {
                            calendar,
                        }
},
                    new StackLayout
                    {
                        Orientation = StackOrientation.Vertical,
                        BackgroundColor = Color.GhostWhite,

                        Children =
                        {
                            new StackLayout
                            {
                                Orientation=StackOrientation.Horizontal,
                                Margin = new Thickness(20,0,0,0),
                                Children =
                                {
                                    boxView,
                                    new Label
                                    {
                                        Text="Predicted Menstrual Period",
                                        HorizontalOptions = LayoutOptions.Center,

                                    }
                                }
                            },
                            new StackLayout
                            {
                                Orientation=StackOrientation.Horizontal,
                                Margin = new Thickness(20,0,0,0),
                                Children =
                                {
                                    boxView2,
                                    new Label
                                    {
                                        Text="Predicted Ovulatory Period",
                                        HorizontalOptions = LayoutOptions.Center,
                                    }
                                }
                            }
                        }
                    },
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
                                        Text="Had Breakfast Today?",
                                    }
                                }
                            },
                            new StackLayout
                            {
                                Children =
                                {

                                    label,
                                }
                            },
                            new StackLayout
                            {
                                Children =
                                {
                                   breakfast,
                                }
                            }
                        }
                    },


                }
            };
        }
    }
}

