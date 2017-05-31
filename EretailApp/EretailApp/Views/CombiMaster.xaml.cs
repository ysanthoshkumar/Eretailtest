using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EretailApp.Views
{
    public partial class CombiMaster : ContentPage
    {
        List<ProductModel> ll = new List<ProductModel>
        {
              new ProductModel
           {
        CombiCode="oo1",
        CombiPrice="100",
             
         },
           new ProductModel
           {
                 CombiCode="oo2",
                 CombiPrice="200",

           }
           ,

             new ProductModel
           {
                         CombiCode="oo3",
                         CombiPrice="300",


           }
             ,
};



        public CombiMaster()
        {
            InitializeComponent();
            CombiList.ItemsSource = ll;


        }

        public void SearchCombiclick(Object o, EventArgs e)
        {

            String str = searchCombi.Text;
            IEnumerable<ProductModel> searchresult = ll.Where(name1 => name1.CombiCode.Contains(str));
            CombiList.ItemsSource = searchresult;



        }



      void  popup(object sender, ToggledEventArgs e)
        {
            //switc.Text = "Switch is" + e.Value.ToString();
            if (e.Value.ToString().Equals("True"))
            {
                var page = new MyPopupPage();

              Navigation.PushModalAsync(page);

            }
            else
            {
               
            }
        }





    }
}
