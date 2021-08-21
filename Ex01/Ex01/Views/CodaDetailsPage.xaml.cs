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
    public partial class CodaDetailsPage : ContentPage
    {

        //info bijhoudern

        public CodaDocument MyDocument { get; set; }

        public CodaPage MyPage { get; set; }

        public CodaDetailsPage(CodaDocument codaDocument, CodaPage codaPage)
        {
            InitializeComponent();
            //info bewaren

            MyDocument = codaDocument;
            MyPage = codaPage;

            loadPage();

        }



        private  async void loadPage()
        {
            CodaPageSingle  singlePage = await CodaRepository.GetCodaPageByIdAsync(MyDocument.Id, MyPage.Id);
            //weergeven in XAML
            PageName.Text = string.Concat("Name: ", singlePage.Name);
            PageSubtitle.Text = string.Concat("Subtitle: ",singlePage.Subtitle);

            //updaten
            singlePage.Name = "Updated Name";
            //await  CodaRepository.UpdatePagesAsync(singlePage);
            

      
        }

        private void btnGoBack_Clicked(object sender, EventArgs e)
        {

        }

     
    }
}