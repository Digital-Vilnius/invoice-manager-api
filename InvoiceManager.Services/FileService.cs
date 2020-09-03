﻿using System;
using System.Threading.Tasks;
using InvoiceManager.Models.Services;

namespace InvoiceManager.Services
{
    public class FileService : IFileService
    {
        public async Task<Tuple<string, long>> UploadFileAsync()
        {
            return await Task.FromResult(new Tuple<string, long>("test", 12));
        }
    }
}