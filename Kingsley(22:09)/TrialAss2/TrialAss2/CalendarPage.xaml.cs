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

        private static void SetSex(DateTime dt, bool flag)
        {
            foreach (RecordDetails Selectdate in CalenderEntry)
            {
                if (IsSameDay(Selectdate.SpecificDate, dt))
                {
                    Selectdate.sex = flag;
                    return;
                }
            }
            RecordDetails _selectdate = new RecordDetails();
            _selectdate.sex = flag;
            _selectdate.SpecificDate = dt;
            CalenderEntry.Add(_selectdate);
        }
        private static void SetDysmenorrha(DateTime dt, bool flag)
        {
            foreach (RecordDetails Selectdate in CalenderEntry)
            {
                if (IsSameDay(Selectdate.SpecificDate, dt))
                {
                    Selectdate.dysmenorrha = flag;
                    return;
                }
            }
            RecordDetails _selectdate = new RecordDetails();
            _selectdate.sex = flag;
            _selectdate.SpecificDate = dt;
            CalenderEntry.Add(_selectdate);
        }
        private static void SetHeadache(DateTime dt, bool flag)
        {
            foreach (RecordDetails Selectdate in CalenderEntry)
            {
                if (IsSameDay(Selectdate.SpecificDate, dt))
                {
                    Selectdate.headache = flag;
                    return;
                }
            }
            RecordDetails _selectdate = new RecordDetails();
            _selectdate.headache = flag;
            _selectdate.SpecificDate = dt;
            CalenderEntry.Add(_selectdate);
        }
        private static void SetDizziness(DateTime dt, bool flag)
        {
            foreach (RecordDetails Selectdate in CalenderEntry)
            {
                if (IsSameDay(Selectdate.SpecificDate, dt))
                {
                    Selectdate.dizziness = flag;
                    return;
                }
            }
            RecordDetails _selectdate = new RecordDetails();
            _selectdate.dizziness = flag;
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
                //SelectedDate = DateTime.Now,
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
            //start sex yes/no
            var sex_label = new Label
            {
                Text = "No",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Black,
            };
            sex_label.FontSize = 15;
            Switch sex = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                IsToggled = false,
            };

            sex.Toggled += sex_Toggled;
            void sex_Toggled(object sender, ToggledEventArgs e)
            {
                bool value = e.Value;
                if (value == true)
                {
                    SetSex(CurrentDateTime, true);
                    sex_label.Text = String.Format("Yes");
                }
                else
                {
                    SetSex(CurrentDateTime, false);
                    sex_label.Text = String.Format("No");
                }
            }
            //end sex yes/no
            //start dysmenorrha yes/no
            Switch dysmenorrha = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                IsToggled = false,
            };
            var dysmenorrha_label = new Label
            {
                Text = "No",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Black,
            };
            dysmenorrha_label.FontSize = 15;
            dysmenorrha.Toggled += dysmenorrha_Toggled;
            void dysmenorrha_Toggled(object sender, ToggledEventArgs e)
            {
                bool value = e.Value;
                if (value == true)
                {
                    SetDysmenorrha(CurrentDateTime, true);
                    dysmenorrha_label.Text = String.Format("Yes");
                }
                else
                {
                    SetDysmenorrha(CurrentDateTime, false);
                    dysmenorrha_label.Text = String.Format("No");
                }
            }
            //end dysmenorrha yes/no
            //start headache yes/no
            Switch headache = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                IsToggled = false,
            };
            var headache_label = new Label
            {
                Text = "No",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Black,
            };
            headache_label.FontSize = 15;
            headache.Toggled += headache_Toggled;
            void headache_Toggled(object sender, ToggledEventArgs e)
            {
                bool value = e.Value;
                if (value == true)
                {
                    SetHeadache(CurrentDateTime, true);
                    headache_label.Text = String.Format("Yes");
                }
                else
                {
                    SetHeadache(CurrentDateTime, false);
                    headache_label.Text = String.Format("No");
                }
            }
            //end headache yes/no
            //start dizziness yes/no
            Switch dizziness = new Switch
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                IsToggled = false,
            };
            var dizziness_label = new Label
            {
                Text = "No",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                TextColor = Color.Black,
            };
            dizziness_label.FontSize = 15;
            dizziness.Toggled += dizziness_Toggled;
            void dizziness_Toggled(object sender, ToggledEventArgs e)
            {
                bool value = e.Value;
                if (value == true)
                {
                    SetDizziness(CurrentDateTime, true);
                    dizziness_label.Text = String.Format("Yes");
                }
                else
                {
                    SetDizziness(CurrentDateTime, false);
                    dizziness_label.Text = String.Format("No");
                }
            }
            //end headache yes/no
            //click event
            calendar.DateClicked += (object sender2, DateTimeEventArgs a) =>
            {
                CurrentDateTime = a.DateTime;
                bool sex_flag = false;
               
                foreach (RecordDetails Selectdate in CalenderEntry)
                {
                    if (Selectdate.SpecificDate.Equals(a.DateTime) && Selectdate.sex == true)
                    {
                        sex_flag = true;
                        break;
                    }
                }
                sex.IsToggled = sex_flag;
                sex_label.Text = String.Format(sex_flag ? "Yes" : "No");
               
            };
            calendar.DateClicked += (object sender2, DateTimeEventArgs a) =>
            {
                CurrentDateTime = a.DateTime;
                bool dysmenorrha_flag = false;

                foreach (RecordDetails Selectdate in CalenderEntry)
                {
                    if (Selectdate.SpecificDate.Equals(a.DateTime) && Selectdate.dysmenorrha == true)
                    {
                        dysmenorrha_flag = true;
                        break;

                    }
                }
                dysmenorrha.IsToggled = dysmenorrha_flag;
                dysmenorrha_label.Text = String.Format(dysmenorrha_flag ? "Yes" : "No");
            };
            calendar.DateClicked += (object sender2, DateTimeEventArgs a) =>
            {
                CurrentDateTime = a.DateTime;
                bool headache_flag = false;

                foreach (RecordDetails Selectdate in CalenderEntry)
                {
                    if (Selectdate.SpecificDate.Equals(a.DateTime) && Selectdate.headache == true)
                    {
                        headache_flag = true;
                        break;

                    }
                }
                headache.IsToggled = headache_flag;
                headache_label.Text = String.Format(headache_flag ? "Yes" : "No");
            };
            calendar.DateClicked += (object sender2, DateTimeEventArgs a) =>
            {
                CurrentDateTime = a.DateTime;
                bool dizziness_flag = false;

                foreach (RecordDetails Selectdate in CalenderEntry)
                {
                    if (Selectdate.SpecificDate.Equals(a.DateTime) && Selectdate.dizziness == true)
                    {
                        dizziness_flag = true;
                        break;

                    }
                }
                dizziness.IsToggled = dizziness_flag;
                dizziness_label.Text = String.Format(dizziness_flag ? "Yes" : "No");
            };
            //end click event
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
                                        Text="Had Sex Today?",
                                        Margin = new Thickness(0,5,0,0)

                                    }
                                }
                            },
                            new StackLayout
                            {
                                WidthRequest = 30,
                                Children =
                                {

                                    sex_label,
                                }
                            },
                            new StackLayout
                            {
                                Children =
                                {
                                   sex,
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
                                        Text="Had dysmenorrha Today?",
                                        Margin = new Thickness(0,5,0,0)

                                    }
                                }
                            },
                            new StackLayout
                            {
                                WidthRequest = 30,
                                Children =
                                {

                                    dysmenorrha_label,
                                }
                            },
                            new StackLayout
                            {
                                Children =
                                {
                                   dysmenorrha,
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
                                        Text="Had Headache Today?",
                                        Margin = new Thickness(0,5,0,0)

                                    }
                                }
                            },
                            new StackLayout
                            {
                                WidthRequest = 30,
                                Children =
                                {

                                    headache_label,
                                }
                            },
                            new StackLayout
                            {
                                Children =
                                {
                                   headache,
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
                                        Text="Had Dizziness Today?",
                                        Margin = new Thickness(0,5,0,0)

                                    }
                                }
                            },
                            new StackLayout
                            {
                                WidthRequest = 30,
                                Children =
                                {

                                    dizziness_label,
                                }
                            },
                            new StackLayout
                            {
                                Children =
                                {
                                   dizziness,
                                }
                            }
                        }
                    },
                }
            };
        }
    }
}

