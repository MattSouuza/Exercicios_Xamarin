using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinExemplo.Listviews;

namespace XamarinExemplo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            List<Chimanze> Monkeys = new List<Chimanze>();
            Monkeys.Add(new Chimanze
            {
                Name = "Baboon",
                Location = "Africa and Asia",
                ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Faminoapps.com%2Fc%2Fotanix%2Fpage%2Fitem%2Fjaison-mendes-pai-de-familia%2FPqz8_Ywu3Ijz0WEmGaqBzYKrwZVKmzo0n&psig=AOvVaw1F4pinpOTE__lakCR2yhOb&ust=1593703841901000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCLjKv8-vrOoCFQAAAAAdAAAAABAJ",
            });

            Monkeys.Add(new Chimanze 
            {
                Name = "Lucas Pandolfi",
                Location = "Brazil and Middle East",
                ImageUrl = "https://www.google.com/url?sa=i&url=http%3A%2F%2Fg1.globo.com%2Fmundo%2Fnoticia%2F2016%2F05%2Fsaiba-o-que-aconteceu-com-al-qaeda-apos-morte-de-bin-laden.html&psig=AOvVaw1CH4eU3VQGbOAnFnvj33_u&ust=1593704062824000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNDwvLqwrOoCFQAAAAAdAAAAABAD",
            });

            Monkeys.Add(new Chimanze
            {
                Name = "Davi Alencar",
                Location = "Brazil",
                ImageUrl = "https://www.google.com/url?sa=i&url=http%3A%2F%2Fg1.globo.com%2Fmundo%2Fnoticia%2F2016%2F05%2Fsaiba-o-que-aconteceu-com-al-qaeda-apos-morte-de-bin-laden.html&psig=AOvVaw1CH4eU3VQGbOAnFnvj33_u&ust=1593704062824000&source=images&cd=vfe&ved=0CAIQjRxqFwoTCNDwvLqwrOoCFQAAAAAdAAAAABAD",
            });

            BindingContext = this;
        }

        void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Chimanze selectedItem = e.SelectedItem as Chimanze;
        }

        void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            Chimanze tappedItem = e.Item as Chimanze;
        }

    }
}