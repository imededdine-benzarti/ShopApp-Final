using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopApp.View
{

	public partial class Shop : ContentPage
	{
        List<Products> ListProductItem = new List<Products>()
            {
                new Products{ ProductName ="Gucci Hand Bag Light Brown", Status="Almost New", Price="3000.00 SAR", Image="handbag.png"},
                new Products{ ProductName= "Gucci Hand Bag Light Brown",Status="Almost New",Price="3000.00 SAR", Image="handbag.png"},
                new Products{ ProductName= "Gucci Hand Bag Light Brown",Status="Almost New",Price="3000.00 SAR", Image="handbag.png"},
                new Products{ ProductName= "Gucci Hand Bag Light Brown",Status="Almost New",Price="3000.00 SAR", Image="handbag.png"}
            };


        public Shop ()
		{
			InitializeComponent ();

           
            ProductMenu.ItemsSource = ListProductItem;
        }


        private void HandleTextChanged(object sender, TextChangedEventArgs e)
        {
            ProductMenu.ItemsSource = ProductSearch(e.NewTextValue);

        }




        public List<Products> ProductSearch(string searchtext = null)
        {
            var ListProd = ListProductItem; 

            if (string.IsNullOrWhiteSpace(searchtext))
            {
                return ListProd;
            }

            return ListProd.Where(c => c.ProductName.ToLower().StartsWith(searchItem.Text)).ToList();


        }

    }
}