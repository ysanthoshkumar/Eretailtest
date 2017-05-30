using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EretailApp.Views
{
    public partial class MenuMasterConfig : ContentPage
    {
        public MenuMasterConfig()
        {
            InitializeComponent();
        }

        public void back(Object o, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }
    }
}
