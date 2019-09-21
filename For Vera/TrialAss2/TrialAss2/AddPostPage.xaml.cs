using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace TrialAss2
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

            Editor postcontent = new Editor
            {
                Placeholder = "enter your post content here",
                MaxLength = 500,
                AutoSize = EditorAutoSizeOption.TextChanges,
                
            };
            

            Editor posttitle = new Editor
            {
                Placeholder = "enter your post title here",
                MaxLength = 500,
                AutoSize = EditorAutoSizeOption.TextChanges,
                
            };

            cancelBtn.Clicked += cancelBtn_clicked;
            SubmitBtn.Clicked += submitBtn_clicked;

            void cancelBtn_clicked(object sender, System.EventArgs e)
            {
                postcontent.Text = "";
                posttitle.Text = "";

            }
            async void submitBtn_clicked(object sender, System.EventArgs e)
            {

                post.PostContent = postcontent.Text;
                post.PostTitle = posttitle.Text;
                postlist.Add(post);
                await Navigation.PushAsync(new HomePage());
            }


            /*
            async void btnSubmit_Clicked(object sender, System.EventArgs e)
            {
                await App.MyDatabase.SaveInfo(new PostInfo { ID = post.Text, });
                await Navigation.PopAsync();
            }
            async void btnCancel_Clicked(object sender, System.EventArgs e)
            {

            }
            */
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
                            postcontent,
                            posttitle,
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
