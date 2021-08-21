using Ex01.Models;
using Ex01.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ex01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoriesPage : ContentPage
    {
        public CategoriesPage()
        {
            InitializeComponent();
            TestCategories();
            LoadCategories();
        }




        private async void TestCategories()
        {
            List<Categories> codaCategories = await CodaRepository.GetCategoriesAsync();
            foreach ( Categories c in codaCategories)
            {
                Debug.WriteLine(c.Name);
            }

        }

        private async void LoadCategories()
        {
            lvwCategories.ItemsSource = await CodaRepository.GetCategoriesAsync(); ;
        }

    }
}