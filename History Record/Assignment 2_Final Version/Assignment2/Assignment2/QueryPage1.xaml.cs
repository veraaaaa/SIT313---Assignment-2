using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Assignment2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly ObservableCollection<ListItem> multiSelectListItems;

        private bool _isSelectedItemTap;
        private int _selectedItemIndex;

        private IList<ListItem> selectedItems = new List<ListItem>();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            multiSelectListItems = new ObservableCollection<ListItem>();
            multiSelectListItems.Add(new ListItem()
            {
                CheckboxImage = "Checkbox.png",
                ItemImage = "Health.png",
                ItemName = "Manage Peroid"

            });

            multiSelectListItems.Add(new ListItem()
            {
                CheckboxImage = "Checkbox.png",
                ItemImage = "pregnancy.png",
                ItemName = "Pregnancy Preparation"
            });

            multiSelectListItems.Add(new ListItem()
            {
                CheckboxImage = "Checkbox.png",
                ItemImage = "gender.png",
                ItemName = "Gender Health"

            });

            MultiSelectListView.ItemsSource = multiSelectListItems;
        }
        private void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            _isSelectedItemTap = true;
            _selectedItemIndex = multiSelectListItems.IndexOf((ListItem)args.SelectedItem);

            multiSelectListItems[_selectedItemIndex].CheckboxImage = multiSelectListItems[_selectedItemIndex].CheckboxImage.Equals("Checkbox.png") ? "Confirm.png" : "Checkbox.png";

        }

        private void OnItemTapped(object sender, ItemTappedEventArgs itemTappedEventArgs)
        {
            if (!_isSelectedItemTap && null != itemTappedEventArgs.Item)
            {
                multiSelectListItems.IndexOf((ListItem)itemTappedEventArgs.Item);
                multiSelectListItems[_selectedItemIndex].CheckboxImage = multiSelectListItems[_selectedItemIndex].CheckboxImage.Equals("Confirm.png") ? "Checkbox.png" : "Checkbox.png";

            }
            MultiSelectListView.ItemsSource = null;
            MultiSelectListView.ItemsSource = multiSelectListItems;
            _isSelectedItemTap = false;

        }
        async void ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QueryPage2());
        }
    }
}
