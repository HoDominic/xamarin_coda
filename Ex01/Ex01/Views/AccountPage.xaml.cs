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
    public partial class AccountPage : ContentPage
    {
        public AccountPage()
        {
            InitializeComponent();

            LoadAccountInfo();
           
        }




        private async void LoadAccountInfo()
        {
            Account account = await CodaRepository.GetAccountInfoAsync();

            AccountName.Text = string.Concat("Name: ", account.Name);
            AccountId.Text = string.Concat("LoginId: ", account.LoginId);
            AccountType.Text = string.Concat("Account type: ", account.Type);

        }


      


      

    }
    

}
