﻿namespace WebShopApi.Models
{
    public class LoginViewModel
    {
        /// <summary>
        /// Пошта користувача
        /// </summary>
        /// <example>marko@gmail.com</example>
        public string Email { get; set; }
        /// <summary>
        /// Пароль користувача
        /// </summary>
        /// <example>123456</example>
        public string Password { get; set; }
    }
    public class RegisterUserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ImageBase64 { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
