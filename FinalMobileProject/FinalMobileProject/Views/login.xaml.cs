using System;
using Xamarin.Forms;


namespace FinalMobileProject.Views
{
    public partial class login : ContentPage
    {
        public login() {
            InitializeComponent();
        }
        

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var username = EntryUsername.Text;
                var password = EntryPassword.Text;
                try {
                    
                    
                }
                catch(Exception error)
                {
                    Console.WriteLine(error);
                }
                
                
            }
            catch(Exception err)
            {
                Console.WriteLine(err);
            }
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }

    }
}
