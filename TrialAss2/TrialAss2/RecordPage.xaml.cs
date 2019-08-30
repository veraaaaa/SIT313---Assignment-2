using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamForms.Controls;

namespace TrialAss2
{
    [DesignTimeVisible(false)]
    public partial class RecordPage : ContentPage
    {
        public RecordPage()
        {
            InitializeComponent();
            var Dates = new List<SpecialDate>();
            NavigationPage.SetHasNavigationBar(this, false);
            DateTime testdate = new DateTime(2018, 06, 26);
        }
    }
}
