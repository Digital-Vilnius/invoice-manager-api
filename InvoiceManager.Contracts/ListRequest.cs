﻿using InvoiceManager.Constants.Enums;

namespace InvoiceManager.Contracts
{
    public class ListRequest : BaseRequest
    {
        public int? Limit { get; set; }
        public int? Offset { get; set; }
        
        public string SortColumn { get; set; }
        public SortTypes? SortType { get; set; }
    }
}