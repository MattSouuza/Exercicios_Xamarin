using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace teste_SQLite
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetPessoaAsync();
        }

        public async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(entryName.Text))
            {
                await App.Database.SavePessoaAsync(new Models.Pessoa
                {
                    Name = entryName.Text,
                });
            }

            entryName.Text = string.Empty;

            listView.ItemsSource = await App.Database.GetPessoaAsync();
        }
    }
}
