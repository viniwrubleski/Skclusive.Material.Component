using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Skclusive.Material.Script
{
    public class RadioGroupHelper : IAsyncDisposable
    {
        public RadioGroupHelper(IJSRuntime jsruntime)
        {
            JSRuntime = jsruntime;
        }

        private IJSRuntime JSRuntime { get; }

        public async ValueTask FocusAsync(ElementReference? nodeRef)
        {
            if (nodeRef.HasValue)
            {
                await JSRuntime.InvokeVoidAsync("Skclusive.Material.Script.focusRadioGroup", nodeRef);
            }
        }

        public ValueTask DisposeAsync()
        {
            return default;
        }
    }
}