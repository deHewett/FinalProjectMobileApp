﻿using System;
using Xamarin.Forms;
using FinalMobileProject.Models;


namespace FinalMobileProject.Views
{
    public partial class login : ContentPage
    {
        SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.db_path);
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
                    conn.CreateTable<User>();
                    var users = conn.Table<User>().ToList();
                    for(int i = 0; i< users.Capacity; i++)
                    {
                        if(users[i].Username == username)
                        {
                            
                            if(Hashing.ValidatePassword(password, users[i].Password))
                            {
                                Navigation.PushAsync(new PayNow());
                            }
                        }
                    }
                    //Datalist.ItemsSource = users;

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
