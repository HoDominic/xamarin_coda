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
    public partial class SingleDocumentPage : ContentPage
    {
        //info bijhouden

        


        public SingleDocumentPage()
        {
            InitializeComponent();

            

            
        }

        private void btnCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private async void  btnSave_Clicked(object sender, EventArgs e)
        {
            //opslaan nieuwe CodaDocument
            string name = editName.Text;

            CodaDocument newCodaDocument = new CodaDocument();
            newCodaDocument.Name  = name;

           await CodaRepository.AddDocumentsAsync(newCodaDocument, "new document");

          await  Navigation.PopAsync();
                
        }
    }
}