using System;
using System.Threading.Tasks;

namespace InvoiceManager.Models.Services
{
    public interface IFileService
    {
        Task<Tuple<string, long>> UploadFileAsync();
    }
}