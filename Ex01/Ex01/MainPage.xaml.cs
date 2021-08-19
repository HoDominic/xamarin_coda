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
            TestModels();
           LoadDocuments();


            //toevoegen van document
            TapGestureRecognizer tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += TapGesture_Tapped;
            lblAddDocument.GestureRecognizers.Add(tapGesture);
            


        }

        private void TapGesture_Tapped(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new SingleDocumentPage());
        }

        private async void LoadDocuments()
        {
            lvwDocuments.ItemsSource = await CodaRepository.GetDocumentsAsync();
        }



        private async  void  TestModels()
        {
            //test the GET Documents
            
            Debug.WriteLine("test models");
            List<CodaDocument> codaDocuments = await CodaRepository.GetDocumentsAsync();
            foreach(CodaDocument d in codaDocuments)
            {
                Debug.WriteLine("dit is een test",d.Name,d.CreatedAt);
            }


            // TEST we nemen de eerste document
        
            CodaDocument codaDocument = codaDocuments[0];

            //Get pages in a document
            List<CodaPage> codaPages = await CodaRepository.GetPagesAsync(codaDocument.Id);
            foreach (CodaPage p in codaPages)
            {
                Debug.WriteLine("test models 2");
                Debug.WriteLine(p.Name);
            }

            //test3: toevoegen  van document

            //CodaDocument newDocument = new CodaDocument() { Name = "demo nieuw document" };
            //await CodaRepository.AddDocumentsAsync(newDocument, codaDocument.Id, "testtitel" );


            //test4: update document (niet mogelijk via deze API..)
            CodaDocument firstDocument = codaDocuments[0];
            firstDocument.Name = "Updated Name";
            //await CodaRepository.UpdateDocumentsAsync(firstDocument);

            //test5: updaten van 1 pagina
            CodaPage firstPage = codaPages[0];
            firstPage.Name = "Updated page name";
            





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

        private void ButtonDeleteDocument_Clicked(object sender, EventArgs e)
        {

        }

        private async void btnCloseDocument_Clicked(object sender, EventArgs e)
        {
            CodaDocument codaDocument = (sender as Button).BindingContext as CodaDocument;
            await CodaRepository.DeleteDocumentsAsync(codaDocument.Id);
            
        }
    }
}
