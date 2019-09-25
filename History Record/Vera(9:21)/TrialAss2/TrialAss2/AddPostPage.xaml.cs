using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace TrialAss2
{
    public partial class AddPostPage : ContentPage
    {
       
        public AddPostPage()
        {
            InitializeComponent();
            //Button cancelBtn = new Button
            //{
            //    Text = "Cancel",
            //    TextColor = Color.Gray,
            //    BorderWidth = 2,
            //    HorizontalOptions = LayoutOptions.StartAndExpand,
            //    WidthRequest = 130,
            //    BindingContext = "cancelBtn",
            //};
            //Button SubmitBtn = new Button
            //{
            //    Text = "Submit",
            //    TextColor = Color.Gray,
            //    BorderWidth = 2,
            //    HorizontalOptions = LayoutOptions.EndAndExpand,
            //    WidthRequest = 130,
            //    BindingContext = "submitBtn",
            //};
            //Editor post = new Editor
            //{
            //    Placeholder = "enter your post here",
            //    MaxLength = 500,
            //    AutoSize = EditorAutoSizeOption.TextChanges,
            //    BindingContext = "content",
            //};
            //async void btnSubmit_Clicked(object sender, System.EventArgs e)
            //{
            //    await App.MyDatabase.SaveInfo(new PostInfo { ID = post.Text, });
            //    await Navigation.PopAsync();
            //}
            //async void btnCancel_Clicked(object sender, System.EventArgs e)
            //{
                
            //}
            //cancelBtn.Clicked += btnCancel_Clicked;
            //SubmitBtn.Clicked += btnSubmit_Clicked;
            //Content = new StackLayout
            //{
            //    Orientation = StackOrientation.Vertical,
            //    FlowDirection = FlowDirection.LeftToRight,
            //    Children =
            //    {
            //        new StackLayout
            //        {
            //            Orientation = StackOrientation.Horizontal,
            //            Children =
            //            {
            //                //用户头像
            //                new Image
            //                {
                                
            //                },
            //                new Label
            //                {
            //                    //用户名字
            //                }
            //            }
            //        },
            //        new StackLayout
            //        {
            //           //Orientation = StackOrientation.Vertical,
            //            Children =
            //            {
            //                post,
            //            }
            //        },
            //        new StackLayout
            //        {
            //           Orientation = StackOrientation.Horizontal,
            //            Children =
            //            {
            //                cancelBtn,
            //                SubmitBtn,
            //            }
            //        },
            //    }
            //};
        }
        async void cancelBtn_clicked(object sender, System.EventArgs e)
        {

        }
        async void submitBtn_clicked(object sender, System.EventArgs e)
        {
            await App.MyDatabase.SaveInfo(new PostInfo { title = title.Text, Content = content.Text });
            await Navigation.PopAsync();
        }
    }
}
