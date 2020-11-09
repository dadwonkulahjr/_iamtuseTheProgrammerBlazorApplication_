using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace tuseTheProgrammer.Component
{
    public class DeleteConfirmationBase : ComponentBase
    {
        protected bool ShowConfirmation { get; set; }
        [Parameter]
        public string ConfirmationTitle { get; set; } = "Delete Confirmation";
        [Parameter]
        public string ConfirmationMessage { get; set; } = "Are you sure you want to delete?";
        public void Show()
        {
            ShowConfirmation = true;
            StateHasChanged(); 
        }
        [Parameter]
        public EventCallback<bool> ConfirmationChanged { get; set; }
        protected async Task OnConfirmationChanged(bool value)
        {
            ShowConfirmation = false;
            await ConfirmationChanged.InvokeAsync(value);
        }
    }
}
