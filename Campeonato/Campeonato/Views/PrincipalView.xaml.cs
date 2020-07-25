using Campeonato.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Campeonato.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalView : ContentPage
    {
        PrincipalViewModel vm = new PrincipalViewModel();
        public PrincipalView()
        {
            InitializeComponent();
            this.BindingContext = vm;
        }
    }
}