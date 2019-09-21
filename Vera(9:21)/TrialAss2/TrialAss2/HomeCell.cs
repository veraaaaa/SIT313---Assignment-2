using System;

using Xamarin.Forms;

namespace TrialAss2
{
    public class HomeCell : ViewCell
    {
        public HomeCell()
        {
            //instance for the view
            StackLayout cellWrapper = new StackLayout();
            StackLayout horizontalLayout = new StackLayout();
            Label left = new Label();
            Label right = new Label();

            //set Binding
            left.SetBinding(Label.TextProperty, "title");
            right.SetBinding(Label.TextProperty, "content");

            //set properities design
            cellWrapper.BackgroundColor = Color.Default;
            horizontalLayout.Orientation = StackOrientation.Horizontal;
            right.HorizontalOptions = LayoutOptions.EndAndExpand;
            left.TextColor = Color.Black;
            right.TextColor = Color.BurlyWood;

            //add view to the view hierachy
            horizontalLayout.Children.Add(left);
            horizontalLayout.Children.Add(right);
            cellWrapper.Children.Add(horizontalLayout);
            View = cellWrapper;
        }
    }
}

