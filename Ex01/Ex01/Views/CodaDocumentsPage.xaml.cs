using Ex01.Models;
using Ex01.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ex01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CodaDocumentsPage : ContentPage
    {

        public CodaDocument MyDocument { get; set; }

        //geselecteerde document meegeven
        public CodaDocumentsPage(Models.CodaDocument selected)
        {
            InitializeComponent();
            //bijhouden


            MyDocument = selected;

            

            ShowPagesFromDocument();


        }



        //list van paginas van geselecteerde document ophalen

        private async void ShowPagesFromDocument()
        { 
            List<CodaPage>codaPages = await CodaRepository.GetPagesAsync(MyDocument.Id);
            //weergeven in de juiste listView
            lvwCodaPages.ItemsSource = codaPages;


        }


        //selecteren van CodaPage
        private void lvwCodaPages_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(lvwCodaPages.SelectedItem != null)
            {
                CodaPage codaPageSelected = (CodaPage)lvwCodaPages.SelectedItem;
                Navigation.PushAsync(new CodaDetailsPage(
                MyDocument,codaPageSelected));

                //deselecteren
                lvwCodaPages.SelectedItem = null;


            }
        }
    }
}