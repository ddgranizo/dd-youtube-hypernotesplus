using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DD.Youtube.HyperNotesPlus.Client.Extensions.Services.Implementations
{
    public class LocalStorageJsRuntimeService : ILocalStorageService
    {
        public LocalStorageJsRuntimeService(IJSRuntime js)
        {
            Js = js ?? throw new ArgumentNullException(nameof(js));
        }

        public IJSRuntime Js { get; }

        public async Task<string> GetFromLocalStorage(string key)
        {
            return await Js.InvokeAsync<string>("localStorage.getItem", key);
        }

        public async Task RemoveFromLocalStorage(string key)
        {
            await Js.InvokeVoidAsync("localStorage.removeItem", key);
        }

        public async Task SetToLocalStorage(string key, string value)
        {
            await Js.InvokeVoidAsync("localStorage.setItem", key, value);
        }
    }
}
