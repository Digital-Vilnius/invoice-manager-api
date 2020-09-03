﻿using System.ComponentModel.DataAnnotations;

namespace InvoiceManager.Contracts.Authentication
{
    public class LoginRequest : BaseRequest
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}