using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace TrialAss2
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
                CheckboxImage = "https://freeicons.io/laravel/public/uploads/icons/png/12090335861556281944-512.png",
                ItemImage = "https://images-na.ssl-images-amazon.com/images/I/31tuF1Y%2Bg6L.png",
                ItemName = "Manage Peroid"

            });

            multiSelectListItems.Add(new ListItem()
            {
                CheckboxImage = "https://freeicons.io/laravel/public/uploads/icons/png/12090335861556281944-512.png",
                ItemImage = "https://is5-ssl.mzstatic.com/image/thumb/Purple123/v4/fa/e5/85/fae585f6-e1b1-aa83-2a28-7008c247103c/source/512x512bb.jpg",
                ItemName = "Pregnancy Preparation"
            });

            multiSelectListItems.Add(new ListItem()
            {
                CheckboxImage = "https://freeicons.io/laravel/public/uploads/icons/png/12090335861556281944-512.png",
                ItemImage = "https://imagev2.xmcdn.com/group53/M0B/63/18/wKgLfFwlsO3Rg1NHAAA_Tb9bXAI457.jpg",
                ItemName = "Gender Health"

            });

            MultiSelectListView.ItemsSource = multiSelectListItems;
        }


        private void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            _isSelectedItemTap = true;
            _selectedItemIndex = multiSelectListItems.IndexOf((ListItem)args.SelectedItem);
            
            multiSelectListItems[_selectedItemIndex].CheckboxImage = multiSelectListItems[_selectedItemIndex].CheckboxImage.Equals("https://freeicons.io/laravel/public/uploads/icons/png/12090335861556281944-512.png") ? "https://cdn0.iconfinder.com/data/icons/ui-22/24/174-512.png" : "https://freeicons.io/laravel/public/uploads/icons/png/12090335861556281944-512.png";

        }

        private void OnItemTapped(object sender, ItemTappedEventArgs itemTappedEventArgs)
        {
            if (!_isSelectedItemTap && null != itemTappedEventArgs.Item)
            {
                multiSelectListItems.IndexOf((ListItem)itemTappedEventArgs.Item);
                multiSelectListItems[_selectedItemIndex].CheckboxImage = multiSelectListItems[_selectedItemIndex].CheckboxImage.Equals("https://freeicons.io/laravel/public/uploads/icons/png/12090335861556281944-512.png") ? "https://cdn0.iconfinder.com/data/icons/ui-22/24/174-512.png" : "https://freeicons.io/laravel/public/uploads/icons/png/12090335861556281944-512.png";
                
            }
            MultiSelectListView.ItemsSource = null;
            MultiSelectListView.ItemsSource = multiSelectListItems;
            _isSelectedItemTap = false;

        }
        async void ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Details());
        }



        /*
        private void SelectItems(object sender, EventArgs eventArgs)
        {
            selectedItems = new List<ListItem>();
            string message = "";
            for (int index = 0; index < multiSelectListItems.Count; index++)
            {
                if (multiSelectListItems[index].CheckboxImage.Equals("https://cdn0.iconfinder.com/data/icons/ui-22/24/174-512.png"))
                {
                    selectedItems.Add(multiSelectListItems[index]);
                    message += index + " ";
                }
            }

            DisplayAlert("Items Selected", message, "OK");
        }
        */

    }

}
