using System;

namespace InvoiceManager.Dtos
{
    public class BaseDto
    {
        public int Id { get; set; }
        
        public DateTime Created { get; set; }
    }
}