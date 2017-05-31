using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EretailApp.Views
{
    public partial class CombiMaster : ContentPage
    {
      //  string SCombiCode, SCombiName, SCombiQty, SCombiPrice;
      //  int total = 0;

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
      //  private int buttonclick;

        public CombiMaster()
        {
            InitializeComponent();
            CombiList.ItemsSource = ll;


        }

      //public   class click

      // {  public static int buttonclick = 1;}


    public void SearchCombiclick(Object o, EventArgs e)
        {

            String str = searchCombi.Text;
            IEnumerable<ProductModel> searchresult = ll.Where(name1 => name1.CombiCode.Contains(str));
            CombiList.ItemsSource = searchresult;



        }



        async void  popup(object sender, ToggledEventArgs e)
        {
            //switc.Text = "Switch is" + e.Value.ToString();
            if (e.Value.ToString().Equals("True"))
            {
                //  var page = new MyPopupPage();

                //Navigation.PushModalAsync(page);

                var Det = new DisplayAlert();

                await Navigation.PushModalAsync(new DisplayAlert());

                // CombiCV.IsVisible = true;

            }
            else
            {
               // CombiCV.IsVisible = false;
            }
        }

        public async void AddIconCombiItemclicked(Object o, EventArgs e)
        {
            // click.buttonclick++;

            var action = await DisplayActionSheet("ActionSheet: SavePhoto?", "Cancel", "Delete", "Photo Roll", "Email");

            Debug.WriteLine("Action: " + action);




         //   CombiListSL.IsVisible = true;
            ll.Clear();
            //SCombiCode = entryCombiCode.Text;
            //SCombiName = entryCombiName.Text;
            //SCombiQty = entryCombiQty.Text;
            //SCombiPrice = entryCombiPrice.Text;

          //  for (total= -20; total <= buttonclick; total++)
       //   if(buttonclick>0)
                
            { 

                ll.Add(new ProductModel
                {
                    CombiCode = entryCombiCode.Text,
                    CombiName = entryCombiName.Text,
                    CombiQty = entryCombiQty.Text,
                   // CombiPrice = entryCombiPrice.Text,

                });

            }


         

            CombList.ItemsSource = ll;


        }





        }
}
