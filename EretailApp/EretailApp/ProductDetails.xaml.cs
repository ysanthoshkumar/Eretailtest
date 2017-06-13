using EretailApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EretailApp
{
    public partial class ProductDetails : ContentPage
    {
       


        List<ProductModel> ll = new List<ProductModel>
        {
              new ProductModel
           {
        name="Shirt",
        Dept="PepiJeans",
                category="Mens",
                Icon="ic_user.png",
         },
           new ProductModel
           {
                name="Jeans",
                Dept="PepiJeans",
                category="Mens",
                Icon="ic_user.png",

           }
           ,

             new ProductModel
           {
               name="T-Shirt",
                Dept="Pan America",
                category="Womens",
                Icon="ic_user.png",

           }
             ,
                 new ProductModel
           {
               name=" Round Neck T-Shirt",
                Dept="Us Polo",
                category="Kids",
                Icon="ic_user.png",

           }
                 ,

                       new ProductModel
           {
               name="Gap-TShirt ",
                Dept="Lives",
                category="Branded Shirts",
                Icon="ic_user.png",

           }

,

        };

 




        public ProductDetails()
        {
            InitializeComponent();

            mylistvi.ItemsSource = ll;
            var catgList = new List<String>();


            catgList.Add("Mens");
            catgList.Add("Womens");
            catgList.Add("Kids");

            Catgpicker.ItemsSource = catgList;



            //Mainpicker.SetBinding(Picker.ItemsSourceProperty, "category");
            Deptpicker.Items.Add("PepiJeans");
            Deptpicker.Items.Add("Lives");
            Deptpicker.Items.Add("Us Polo");
            Deptpicker.Items.Add("Pan America");
        }



        private void onselecteditem(Object sender, EventArgs e)
        {

            var name = Catgpicker.Items[Catgpicker.SelectedIndex];
          //  DisplayAlert(name, "SelectedItem", "Okay");
            if (!name.Equals("") || !searchvalue.Text.Equals(""))
            {
                String str = searchvalue.Text;
                //if (!str.Equals(""))
                //{
                    //IEnumerable<ProductModel> searchresult = ll.Where(name1 => name1.name.Contains(str) || name1.name.Contains(name));
                    //mylistvi.ItemsSource = searchresult;
               // }

            }
        }

        private void Deptonselecteditem(Object sender, EventArgs e)
        {

            var name = Deptpicker.Items[Deptpicker.SelectedIndex];
            //DisplayAlert(name, "SelectedItem", "Okay");

            //if (!name.Equals(""))
            //{
            //    String str = searchvalue.Text;
            //    IEnumerable<ProductModel> searchresult = ll.Where(name1 => name1.name.Contains(str) || name1.name.Contains(name));
            //    mylistvi.ItemsSource = searchresult;
            //}



        }


        public void btnclick(Object o, EventArgs e)
        {

            String str = searchvalue.Text;
            String dpt = Deptpicker.Items[Deptpicker.SelectedIndex];
            String catg= Catgpicker.Items[Catgpicker.SelectedIndex];
            IEnumerable<ProductModel> searchresult = ll.Where(name1 => name1.name.Contains(str)||name1.Dept.Contains(dpt) ||name1.category.Contains(catg));
            mylistvi.ItemsSource = searchresult;

            //if (str.Equals(""))
            //{
            //    ll.Clear();
            //}

        }

        //public void back(Object o, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new MainPage());
        //}

        public void AddProduct(Object o, EventArgs e)
        {
            BindingContext = new SettingsViewModel();
            Navigation.PushModalAsync(new productMasterConfig());
        }
      
    }

}

