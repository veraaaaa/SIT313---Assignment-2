using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
namespace Assignment2
{
    public partial class AddPostPage : ContentPage
    {
        public static List<Post> postlist = new List<Post>();
        public static Post post = new Post();
        public static ObservableCollection<Post> itemList = new ObservableCollection<Post>();

        public AddPostPage()
        {
            InitializeComponent();
            Button cancelBtn = new Button
            {
                Text = "Cancel",
                TextColor = Color.Gray,
                BorderWidth = 2,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                WidthRequest = 130,

            };
            Button SubmitBtn = new Button
            {
                Text = "Submit",
                TextColor = Color.Gray,
                BorderWidth = 2,
                HorizontalOptions = LayoutOptions.EndAndExpand,
                WidthRequest = 130,

            };
            Editor posttitle = new Editor
            {
                Placeholder = "enter your post title here",
                MaxLength = 500,
                AutoSize = EditorAutoSizeOption.TextChanges,

            };
            Editor postcontent = new Editor
            {
                Placeholder = "enter your post content here",
                MaxLength = 500,
                AutoSize = EditorAutoSizeOption.TextChanges,
            };


            cancelBtn.Clicked += cancelBtn_clicked;
            SubmitBtn.Clicked += submitBtn_clicked;

            async void cancelBtn_clicked(object sender, System.EventArgs e)
            {
                postcontent.Text = "";
                posttitle.Text = "";
                await DisplayAlert("Alert", "Are you sure to give up current edit context", "Confirm");
            }
            async void submitBtn_clicked(object sender, System.EventArgs e)
            {
                //Post _post = new Post();
                //_post.PostContent = postcontent.Text;
                //_post.PostTitle = posttitle.Text;
                //post = _post;
                //postlist.Add(post);
                //await Navigation.PushAsync(new HomePage());
                Post _post = new Post();
                _post.PostContent = postcontent.Text;
                _post.PostTitle = posttitle.Text;
                post = _post;
                postlist.Add(post);
                var tabbedpage = new TabbedPage();
                tabbedpage.Children.Add(new HomePage { Title = "HomePage" });
                tabbedpage.Children.Add(new CalendarPage { Title = "Calendar" });
                tabbedpage.Children.Add(new AddPostPage { Title = "Post" });
                tabbedpage.Children.Add(new ProfilePage { Title = "Profile" });

                await Navigation.PushAsync(tabbedpage);
                await DisplayAlert("congratulation", "You have successfully submit you post", "Okay");
            }

            Content = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                FlowDirection = FlowDirection.LeftToRight,
                Children =
                {
                    /*
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            //用户头像
                            new Image
                            {
                              
                            },
                            new Label
                            {
                                //用户名字
                            }
                        }
                    },
                    */
                    new StackLayout
                    {
                       Orientation = StackOrientation.Vertical,
                        Children =
                        {
                            posttitle,
                            postcontent,
                        }
                    },
                    new StackLayout
                    {
                       Orientation = StackOrientation.Horizontal,
                        Children =
                        {
                            cancelBtn,
                            SubmitBtn,
                        }
                    },
                }
            };
        }
    }
}
