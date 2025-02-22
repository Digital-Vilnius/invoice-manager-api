﻿using System.Collections.Generic;
using System.Net;

namespace InvoiceManager.Contracts
{
    public class BaseResponse
    {
        public BaseResponse(string message)
        {
            Message = message;
            IsValid = false;
        }
        
        public BaseResponse() {}
        
        public string Message { get; set; }
        public bool IsValid { get; set; } = true;
    }
}