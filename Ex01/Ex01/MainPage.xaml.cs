using Ex01.Models;
using Ex01.Repositories;
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
                Debug.WriteLine("dit is een test",d.Name);
            }
        }
    }
}
