using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Front.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageMaster : MasterDetailPage
	{



        public PageMaster()
        {
            InitializeComponent();

            Detail = new NavigationPage(new MyAccount()) {
            BarBackgroundColor = Color.FromHex("#DAA520"), BarTextColor = Color.White
        };
          

            var ListMenuItem = new List<Items>()
            {
                new Items{ Title="My ACCOUNT"},
                new Items{ Title="SHOP"},
                new Items{ Title="FAQ"},
                new Items{ Title="NOTIFICATIONS", Notification="2"}
            };

            ListMenu.ItemsSource = ListMenuItem;
   
        }

        private void SelectedItem(object sender, SelectedItemChangedEventArgs e)
        {
            var Item = e.SelectedItem as Items;

            if (Item.Title.Equals("My ACCOUNT"))
            {
                Detail = new NavigationPage(new MyAccount())
                {
                    BarBackgroundColor = Color.FromHex("#DAA520"),
                    BarTextColor = Color.White
                };
                IsPresented = false;
            }


            else
               if (Item.Title.Equals("SHOP"))
            {
                Detail = new NavigationPage(new Shop())
                {
                    BarBackgroundColor = Color.FromHex("#DAA520"),
                    BarTextColor = Color.White
                };
                IsPresented = false;
            }
            else
               if (Item.Title.Equals("FAQ"))
            {
                Detail = new NavigationPage(new FAQ())
                {
                    BarBackgroundColor = Color.FromHex("#DAA520"),
                    BarTextColor = Color.White
                };
                IsPresented = false;
            }
            else
               if (Item.Title.Equals("NOTIFICATIONS"))
            {
                Detail = new NavigationPage(new Notifications())
                {
                    BarBackgroundColor = Color.FromHex("#DAA520"),
                    BarTextColor = Color.White
                };
                IsPresented = false;
            }


        }

    }
}