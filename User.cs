﻿namespace CustomerApi
{
    public class User
    {

        public string Username { get; set; }= string.Empty;

        public byte[] PasswordHash  { get; set; }

        public string PasswordSalt   { get; set; }
    }
}
