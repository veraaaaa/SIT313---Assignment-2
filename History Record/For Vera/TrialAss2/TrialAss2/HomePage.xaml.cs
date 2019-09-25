using System;
using System.Collections.Generic;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using System.Collections.ObjectModel;

namespace TrialAss2
{
    public partial class HomePage
    {
        Post listview = AddPostPage.post;
        List<Post> postlist = AddPostPage.postlist;


        public HomePage()
        {
            InitializeComponent();
            Post newpost = new Post();
            ListView listView = new ListView
            {
                RowHeight = 60,
            };
            var label1 = new Label
            {
                Text = listview.PostTitle,
                TextColor=Color.Black,
            };
            var label2 = new Label
            {
                Text = listview.PostContent,
                TextColor = Color.Red,
            };
            listView.IsPullToRefreshEnabled = false;
            listView.ItemsSource = label1.Text+label2.Text;

            var searchBar = new SearchBar
            {
                Placeholder = "Enter search item here",
                BackgroundColor = Color.GhostWhite,

            };
            var canvasView = new SKCanvasView
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HeightRequest = 250
            };
            canvasView.PaintSurface += OnCanvasViewPaintSurface;

            void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
            {
                var info = args.Info;
                var surface = args.Surface;
                var canvas = surface.Canvas;


                canvas.Clear();

                var paint = new SKPaint
                {
                    Style = SKPaintStyle.Stroke,
                    Color = Color.Red.ToSKColor(),
                    StrokeWidth = 25
                };
                canvas.DrawCircle(info.Width / 2, info.Height / 2, 200, paint);

                paint.Style = SKPaintStyle.Fill;
                paint.Color = SKColors.Blue;
                canvas.DrawCircle(info.Width / 2, info.Height / 2, 100, paint);
            }



            //Weekly Datetime setup
            var start = DateTime.Now;
            var secondday = start.AddDays(1);
            var thirdday = start.AddDays(2);
            var fourthday = start.AddDays(3);
            var fifthday = start.AddDays(4);
            var sixthday = start.AddDays(5);
            var end = start.AddDays(6);

            WeeklyDates startday = new WeeklyDates();
            startday.Today = start;
            startday.SecondDay = secondday;
            startday.ThirdDay = thirdday;
            startday.FourthDay = fourthday;
            startday.FifthDay = fifthday;
            startday.SixthDay = sixthday;
            startday.Sevenday = end;

            List<DateTime> listDays = new List<DateTime>();
            listDays.Add(start);
            listDays.Add(secondday);
            listDays.Add(thirdday);
            listDays.Add(fourthday);
            listDays.Add(fifthday);
            listDays.Add(sixthday);
            listDays.Add(end);

            var _startday = listDays[0];
            var _secday = listDays[1];
            var _thday = listDays[2];
            var _fofday = listDays[3];
            var _fifday = listDays[4];
            var _sixday = listDays[5];
            var _sevday = listDays[6];

            bool _isString = true;

            String Today = _startday.DayOfWeek.ToString();
            if (_isString)
            {
                Today = "Today";
            }



            String Secday = _secday.DayOfWeek.ToString();
            String Thday = _thday.DayOfWeek.ToString();
            String Fofday = _fofday.DayOfWeek.ToString();
            String Fifday = _fifday.DayOfWeek.ToString();
            String Sixday = _sixday.DayOfWeek.ToString();
            String Sevday = _sevday.DayOfWeek.ToString();


            if (Secday.Contains("Monday"))
            {
                Secday = "Mon";
            }
            else if (Secday.Contains("Tuesday"))
            {
                Secday = "Tue";
            }
            else if (Secday.Contains("Wednesday"))
            {
                Secday = "Wed";
            }
            else if (Secday.Contains("Thursday"))
            {
                Secday = "Thur";
            }
            else if (Secday.Contains("Friday"))
            {
                Secday = "Fri";
            }
            else if (Secday.Contains("Saturday"))
            {
                Secday = "Sat";
            }
            else if (Secday.Contains("Sunday"))
            {
                Secday = "Sun";
            }


            if (Thday.Contains("Monday"))
            {
                Thday = "Mon";
            }
            else if (Thday.Contains("Tuesday"))
            {
                Thday = "Tue";
            }
            else if (Thday.Contains("Wednesday"))
            {
                Thday = "Wed";
            }
            else if (Thday.Contains("Thursday"))
            {
                Thday = "Thur";
            }
            else if (Thday.Contains("Friday"))
            {
                Thday = "Fri";
            }
            else if (Thday.Contains("Saturday"))
            {
                Thday = "Sat";
            }
            else if (Thday.Contains("Sunday"))
            {
                Thday = "Sun";
            }


            if (Fofday.Contains("Monday"))
            {
                Fofday = "Mon";
            }
            else if (Fofday.Contains("Tuesday"))
            {
                Fofday = "Tue";
            }
            else if (Fofday.Contains("Wednesday"))
            {
                Fofday = "Wed";
            }
            else if (Fofday.Contains("Thursday"))
            {
                Fofday = "Thur";
            }
            else if (Fofday.Contains("Friday"))
            {
                Fofday = "Fri";
            }
            else if (Fofday.Contains("Saturday"))
            {
                Fofday = "Sat";
            }
            else if (Fofday.Contains("Sunday"))
            {
                Fofday = "Sun";
            }


            if (Fifday.Contains("Monday"))
            {
                Fifday = "Mon";
            }
            else if (Fifday.Contains("Tuesday"))
            {
                Fifday = "Tue";
            }
            else if (Fifday.Contains("Wednesday"))
            {
                Fifday = "Wed";
            }
            else if (Fifday.Contains("Thursday"))
            {
                Fifday = "Thur";
            }
            else if (Fifday.Contains("Friday"))
            {
                Fifday = "Fri";
            }
            else if (Fifday.Contains("Saturday"))
            {
                Fifday = "Sat";
            }
            else if (Fifday.Contains("Sunday"))
            {
                Fifday = "Sun";
            }


            if (Sixday.Contains("Monday"))
            {
                Sixday = "Mon";
            }
            else if (Sixday.Contains("Tuesday"))
            {
                Sixday = "Tue";
            }
            else if (Sixday.Contains("Wednesday"))
            {
                Sixday = "Wed";
            }
            else if (Sixday.Contains("Thursday"))
            {
                Sixday = "Thur";
            }
            else if (Sixday.Contains("Friday"))
            {
                Sixday = "Fri";
            }
            else if (Sixday.Contains("Saturday"))
            {
                Sixday = "Sat";
            }
            else if (Sixday.Contains("Sunday"))
            {
                Sixday = "Sun";
            }


            if (Sevday.Contains("Monday"))
            {
                Sevday = "Mon";
            }
            else if (Sevday.Contains("Tuesday"))
            {
                Sevday = "Tue";
            }
            else if (Sevday.Contains("Wednesday"))
            {
                Sevday = "Wed";
            }
            else if (Sevday.Contains("Thursday"))
            {
                Sevday = "Thur";
            }
            else if (Sevday.Contains("Friday"))
            {
                Sevday = "Fri";
            }
            else if (Sevday.Contains("Saturday"))
            {
                Sevday = "Sat";
            }
            else if (Sevday.Contains("Sunday"))
            {
                Sevday = "Sun";
            }


            var fir = new Label
            {
                Text = Today,
                HorizontalTextAlignment = TextAlignment.Center
            };
            var sec = new Label
            {
                Text = Secday,
                HorizontalTextAlignment = TextAlignment.Center
            };
            var thir = new Label
            {
                Text = Thday,
                HorizontalTextAlignment = TextAlignment.Center
            };
            var four = new Label
            {
                Text = Fofday,
                HorizontalTextAlignment = TextAlignment.Center
            };
            var fif = new Label
            {
                Text = Fifday,
                HorizontalTextAlignment = TextAlignment.Center
            };
            var six = new Label
            {
                Text = Sixday,
                HorizontalTextAlignment = TextAlignment.Center
            };
            var sev = new Label
            {
                Text = Sevday,
                HorizontalTextAlignment = TextAlignment.Center
            };

            var today = new Label
            {
                Text = start.Day.ToString(),
                HorizontalTextAlignment = TextAlignment.Center,

            };
            var secondy = new Label
            {
                Text = secondday.Day.ToString(),
                HorizontalTextAlignment = TextAlignment.Center
            };
            var third = new Label
            {
                Text = thirdday.Day.ToString(),
                HorizontalTextAlignment = TextAlignment.Center
            };
            var fourth = new Label
            {
                Text = fourthday.Day.ToString(),
                HorizontalTextAlignment = TextAlignment.Center
            };
            var fifth = new Label
            {
                Text = fifthday.Day.ToString(),
                HorizontalTextAlignment = TextAlignment.Center
            };
            var sixth = new Label
            {
                Text = sixthday.Day.ToString(),
                HorizontalTextAlignment = TextAlignment.Center
            };
            var seven = new Label
            {
                Text = end.Day.ToString(),
                HorizontalTextAlignment = TextAlignment.Center
            };
            //Weekly Date time finish


            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                BackgroundColor = Color.White,

                Children =
                {
                    new StackLayout
                    {
                        Orientation = StackOrientation.Vertical,
                        BackgroundColor = Color.GhostWhite,
                        Children =
                        {
                            new StackLayout
                            {
                                Orientation = StackOrientation.Horizontal,
                                BackgroundColor = Color.GhostWhite,

                                Children =
                                {
                                    searchBar,
                                }

                            },
                            new StackLayout
                            {
                                Orientation = StackOrientation.Horizontal,
                                BackgroundColor = Color.GhostWhite,
                                WidthRequest = 700,

                                Children =
                                {
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Vertical,
                                        WidthRequest = 100,


                                        Children =
                                        {
                                            fir,
                                            today,
                                        }
                                    },
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Vertical,
                                        WidthRequest = 100,

                                        Children =
                                        {
                                            sec,
                                            secondy,
                                        }
                                    },
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Vertical,
                                        WidthRequest = 100,

                                        Children =
                                        {
                                            thir,
                                            third,
                                        }
                                    },
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Vertical,
                                        WidthRequest = 100,

                                        Children =
                                        {
                                            four,
                                            fourth,
                                        }
                                    },
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Vertical,
                                        WidthRequest = 100,

                                        Children =
                                        {
                                            fif,
                                            fifth,
                                        }
                                    },

                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Vertical,
                                        WidthRequest = 100,

                                        Children =
                                        {
                                            six,
                                            sixth,
                                        }
                                    },
                                    new StackLayout
                                    {
                                        Orientation = StackOrientation.Vertical,
                                        WidthRequest = 100,

                                        Children =
                                        {
                                            sev,
                                            seven,
                                        }
                                    }
                                }
                            },
                            new StackLayout
                            {

                                HeightRequest = 250,
                                Children =
                                {
                                    canvasView,
                                }
                            },
                            new StackLayout
                            {

                                HeightRequest = 250,
                                Children =
                                {
                                    listView,
                                }
                            },
                        },

                    },

                }
            };

        }

    }
}
