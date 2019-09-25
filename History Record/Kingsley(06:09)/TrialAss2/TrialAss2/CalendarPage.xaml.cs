using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamForms.Controls;

namespace TrialAss2
{
    public partial class CalendarPage : ContentPage
    {
        public List<DateTime> listdate = new List<DateTime>();
        public static CustomerInfo Days = new CustomerInfo();

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

            Calendar calendar = new Calendar
            {
                SelectedDate = DateTime.Now,
                SelectedBorderColor = Color.Red,
                StartDay = DayOfWeek.Sunday,

            };

            calendar.SpecialDates = new List<SpecialDate> { };
            for (int i = 0; i < Menstrualdays; i++) //i 等于开始日子并且小于等于结束日子
                {
                    listdate.Add(specialdate.LmenstrualDay.AddDays(i));
                    calendar.SpecialDates.Add(new SpecialDate(listdate[i]));
                }
       
            foreach (SpecialDate s in calendar.SpecialDates)
            {
                //highlight here
                s.Selectable = true;
                s.BackgroundColor = Color.LightPink;
            }

            /*
            for (int j = 0; j <= Menstrualdays; j++)
            {
                calendar.SpecialDates = new List<SpecialDate>
                    {
                        new SpecialDate(daylist)
                        {

                        },
                    };
            }
            /*
                calendar.SpecialDates = new List<SpecialDate>
                    {
                        
                        new SpecialDate(listdate[j].Date)
                        {
                            Selectable = true,
                            BackgroundColor = Color.LightPink,
                        },
                        
                            new SpecialDate(specialdate.LmenstrualDay)//开始日子
                            {
                                Selectable = true,
                                BackgroundColor = Color.LightPink,
                            },

                            new SpecialDate(specialdate.LmenstrualDay.AddDays(Menstrualdays))//结束日子
                            {
                                Selectable = true,
                                BackgroundColor = Color.LightPink,
                            }
                };
            }

            /*
                calendar.SpecialDates = new List<SpecialDate>
                {

                    new SpecialDate(specialdate.LmenstrualDay)//开始日子
                    {
                        Selectable = true,
                        BackgroundColor = Color.LightPink,
                    },

                    new SpecialDate(specialdate.LmenstrualDay.AddDays(Menstrualdays))//结束日子
                    {
                        Selectable = true,
                        BackgroundColor = Color.LightPink,
                    },

                };
            */

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
