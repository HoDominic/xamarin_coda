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
        }


        private async  void  TestModels()
        {
            //test the GET REQUEST without nested object
            //printc"name" from  objects
            ///does not work because it's nested 
            Debug.WriteLine("test models");
            List<CodaDocument> codaDocuments = await CodaRepository.GetDocumentsAsync();
            foreach(CodaDocument d in codaDocuments)
            {
                Debug.WriteLine(d.Name);
            }
        }
    }
}
