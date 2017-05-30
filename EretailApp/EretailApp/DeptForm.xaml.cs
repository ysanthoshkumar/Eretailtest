﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EretailApp
{
    public partial class DeptForm : ContentPage
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

  public DeptForm()
        {
            InitializeComponent();
            DepartmentList.ItemsSource = ll;
        }

        public void SearchDepartmentclick(Object o, EventArgs e)
        {

            String str = searchDepartment.Text;
            IEnumerable<ProductModel> searchresult = ll.Where(name1 => name1.name.Contains(str));
            DepartmentList.ItemsSource = searchresult;



        }

        public void AddDepartment(Object o, EventArgs e)
        {
            // Navigation.PushModalAsync(new AddCategoryForm());
            DeptTitle.Text = "Department";
            CreateCategory.IsVisible = true;
        }


      
    }
}