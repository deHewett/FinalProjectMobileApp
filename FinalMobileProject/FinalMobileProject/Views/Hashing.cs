﻿using System;
using System.Collections.Generic;
using System.Text;
using BCrypt.Net;

namespace FinalMobileProject.Views
{
    public class Hashing
    {
        private static string GetRandomSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt(10);
        }

        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, GetRandomSalt());
        }

        public static bool ValidatePassword(string password, string correctHash)
        {
            try
            {
                return BCrypt.Net.BCrypt.Verify(password, correctHash);
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }
    }
}
