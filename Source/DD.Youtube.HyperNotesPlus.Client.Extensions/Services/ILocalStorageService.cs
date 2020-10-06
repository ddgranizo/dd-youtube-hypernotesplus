using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DD.Youtube.HyperNotesPlus.Client.Extensions.Services
{
    public interface ILocalStorageService
    {
        Task SetToLocalStorage(string key, string value);
        Task<string> GetFromLocalStorage(string key);
        Task RemoveFromLocalStorage(string key);
    }
}
