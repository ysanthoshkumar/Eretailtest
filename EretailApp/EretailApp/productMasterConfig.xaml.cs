using EretailApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EretailApp
{
    public partial class DummyproductForm : ContentPage
    {
        MasterViewModel vm;
        public DummyproductForm()
        {
            InitializeComponent();
            BindingContext = vm = new MasterViewModel();
            BindingContext = new SettingsViewModel();
            CheckFlags();
        }



        public void CheckFlags()
        {

            if (MasterViewModel.deptvalue == false)
            {
                DeptSl.IsVisible = false;

            }

            else if (MasterViewModel.deptvalue == true)
            {
                DeptSl.IsVisible = true;

            }


            if (MasterViewModel.Catgvalue == false)
            {
                CatgSl.IsVisible = false;

            }
            else if (MasterViewModel.Catgvalue == true)
            {
                CatgSl.IsVisible = true;

            }

            if (MasterViewModel.deptvalue == false && MasterViewModel.Catgvalue == false)
            {
                enryproductlvl.IsVisible = false;
                lblproductlvl.IsVisible = false;
                imgproductlvl.IsVisible = false;
            }
            else
            {
                enryproductlvl.IsVisible = true;
                lblproductlvl.IsVisible = true;
                imgproductlvl.IsVisible = true;

            }


            if (MasterViewModel.UomValue == false)
            {
                entryUom.Text = "No's";

            }
            else if (MasterViewModel.UomValue == true)
            {
                entryUom.Placeholder = "Enter UOM";
            }

            if (MasterViewModel.TaxValue == false)
            {
                
                entryTax.Text = "0%";
                //entryTax.Text = "0%";

            }
            else if (MasterViewModel.TaxValue == true)
            {
               
                entryTax.Placeholder = "Enter Tax";

            }

            if (MasterViewModel.MarkUpvalue == false)
            {
                entryMark.Placeholder = "Enter Markdown";
                  labelMark.Text = "Markdown";
            }
            else if (MasterViewModel.MarkUpvalue == true)
            {
                entryMark.Placeholder = "Enter Markup";
                labelMark.Text = "Markup";
            }


            if (MasterViewModel.Brandvalue == false)
            {
                BrandPicker.IsVisible = false;

            }
            else if (MasterViewModel.Brandvalue == true)
            {
                BrandPicker.IsVisible = true;

            }



        }



        public void back(Object o, EventArgs e)
        {
            Navigation.PushModalAsync(new MainPage());
        }



        public void hgclick(Object o, EventArgs e)
        {
            HgCv.IsVisible = true;
         
        }

    

        public void hgpopd(Object o, EventArgs e)
        {
            Hgpop.IsVisible = true;
            HgCv.IsVisible = false;

        }
        public void btnhgsave(Object o, EventArgs e)
        {
            Hgpop.IsVisible = false;
            HgCv.IsVisible = false;

        }




        //public void ImgAddHg(Object o, EventArgs e)
        //{

        //    Hgsl.IsVisible = true;
        //    // HgList.IsVisible = false;



        //}
        //public void HgPopup(Object o, EventArgs e)
        //{

        //    HgCv.IsVisible = true;
        //    Hgsl.IsVisible = false;
        //}

        //public void btnCancelHgP(Object o, EventArgs e)
        //{

        //    HgCv.IsVisible = false;

        //}
        //public void btnSaveHgP(Object o, EventArgs e)
        //{

        //    HgCv.IsVisible = false;

        //}

        //public void btnclick(Object o, EventArgs e)
        //{

        //    Hgsl.IsVisible = true;


        //}

    }
}

  