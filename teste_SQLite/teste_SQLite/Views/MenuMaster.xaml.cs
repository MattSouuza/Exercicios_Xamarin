using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace teste_SQLite.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuMaster : MasterDetailPage
    {
        public MenuMaster()
        {
            InitializeComponent();

            Detail = new NavigationPage(new Page1());
            IsPresented = false;
        }

        private void GoPage1(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new Page1());
            IsPresented = false;
        }
        private void GoPage2(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new Page2());
            IsPresented = false;
        }
        private void GoMainPage(object sender, System.EventArgs e)
        {
            Detail.Navigation.PushAsync(new MainPage());
            IsPresented = false;
        }
    }
}