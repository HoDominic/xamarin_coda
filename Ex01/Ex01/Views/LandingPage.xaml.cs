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
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();

            //Gestures toevoegen aan frames voor navigatie tussen pagina's

            //Navigatie naar Locations
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += TapGestureRecognizer_Tapped; ;
            frmMainPage.GestureRecognizers.Add(tapGestureRecognizer);



            //Navigatie naar Movies
            TapGestureRecognizer tapGestureRecognizer1 = new TapGestureRecognizer();
            tapGestureRecognizer1.Tapped += TapGestureRecognizer1_Tapped; ;
            frmLocations.GestureRecognizers.Add(tapGestureRecognizer1);

            TapGestureRecognizer tapGestureRecognizer2 = new TapGestureRecognizer();
            tapGestureRecognizer2.Tapped += TapGestureRecognizer2_Tapped; ;
            frmPage.GestureRecognizers.Add(tapGestureRecognizer2);

        }

        private void TapGestureRecognizer2_Tapped(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TapGestureRecognizer1_Tapped(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}