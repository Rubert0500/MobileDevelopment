using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirtApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

       
        async void OnClicked(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(userEntry.Text) || String.IsNullOrEmpty(passwordEntry.Text))
            {
                
                await this.DisplayAlert("Error", "Los campos username y password no pueden estar vacios.", "OK");

            }
            else
            {               
                
                 await DisplayAlert("Bienvenido!", $"Hola, {userEntry.Text}", "OK");                         
   
            }   
        }
    }
}