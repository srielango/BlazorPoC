using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorPoC.Pages
{
    public partial class GoJsSample : ComponentBase
    {
        [Inject] IJSRuntime JSRuntime { get; set; }
        protected async override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                // This calls the script in gojs-scripts.js
                await JSRuntime.InvokeAsync<string>("initGoJS");
            }
        }

        protected async void Save()
        {
            await JSRuntime.InvokeAsync<string>("saveDiagram");
        }

        protected async void Load()
        {
            await JSRuntime.InvokeAsync<string>("loadDiagram");
        }
    }
}
