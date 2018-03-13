using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShopApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Search : ContentPage
	{
		public Search ()
		{
			InitializeComponent ();

            var ListProductItem = new List<Products>()
            {
                new Products{ ProductName="Gucci Hand Bag Light Brown",Status="Almost New",Price="3000.00 SAR" },
                new Products{ ProductName="Gucci Hand Bag Light Brown",Status="Almost New",Price="3000.00 SAR" },
                new Products{ ProductName="Gucci Hand Bag Light Brown",Status="Almost New",Price="3000.00 SAR" },
                new Products{ ProductName="Gucci Hand Bag Light Brown",Status="Almost New",Price="3000.00 SAR" }
            };

            ListProductMenu.ItemsSource = ListProductItem;



    }
    }
}