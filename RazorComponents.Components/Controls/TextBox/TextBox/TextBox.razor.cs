using Microsoft.AspNetCore.Components;

namespace RazorComponents.Components;

public partial class TextBox : ControlBase
{
    #region Privates
    private async Task OnUserChange(ChangeEventArgs args)
    {
        await HandleEvents(args);
    }

    private async Task OnUserInput(ChangeEventArgs args)
    {
        await HandleEvents(args);
    }

    private async Task HandleEvents(ChangeEventArgs args)
    {
        this.DataMember.SetMemberValue(args.Value?.ToString() ?? string.Empty);

        await UpdateState();
    }
    #endregion
}