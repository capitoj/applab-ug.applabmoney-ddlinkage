﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Security.Cryptography;

namespace DigitizingDataAdminWebService
{
    public class PasswordHash
    {
        // constructor
        public PasswordHash()
        {
        }
        public string hashedPassword(string password)
        {
            if (password == null)
            {
                return null;
            }
            MD5CryptoServiceProvider cryptography = new MD5CryptoServiceProvider();
            byte[] _bytes = System.Text.Encoding.UTF8.GetBytes(password);
            _bytes = cryptography.ComputeHash(_bytes);
            StringBuilder _string = new StringBuilder();
            foreach (byte b in _bytes)
            {
                _string.Append(b.ToString("x2").ToLower());
            }
            return _string.ToString();
        }
    }
}