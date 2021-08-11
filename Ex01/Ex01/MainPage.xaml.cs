using Ex01.Models;
using Ex01.Repositories;
using Ex01.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ex01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //TestModels();
            LoadDocuments();
        }


        private async void LoadDocuments()
        {
            lvwDocuments.ItemsSource = await CodaRepository.GetDocumentsAsync();
        }



        private async  void  TestModels()
        {
            //test the GET REQUEST without nested object
            
            Debug.WriteLine("test models");
            List<CodaDocument> codaDocuments = await CodaRepository.GetDocumentsAsync();
            foreach(CodaDocument d in codaDocuments)
            {
                Debug.WriteLine("dit is een test",d.Name,d.CreatedAt);
            }


            // TEST we nemen de eerste document
            CodaDocument codaDocument = codaDocuments[0];
            List<CodaPage> codaPages = await CodaRepository.GetPagesAsync(codaDocument.Id);
            foreach (CodaPage p in codaPages)
            {
                Debug.WriteLine("test models 2");
                Debug.WriteLine(p.Name);
            }


        }

        private void lvwDocuments_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (lvwDocuments.SelectedItem != null)
            {
                // er is een document geselecteerd
                CodaDocument selected = (CodaDocument)lvwDocuments.SelectedItem;
                // naar een andere pagina
                Navigation.PushAsync(new CodaDocumentsPage(selected));
                //selected document deselecteren
                lvwDocuments.SelectedItem = null;
            }
        }
    }
}
