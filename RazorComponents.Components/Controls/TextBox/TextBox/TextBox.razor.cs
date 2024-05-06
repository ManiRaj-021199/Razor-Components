using Microsoft.AspNetCore.Components;

namespace RazorComponents.Components;

public partial class TextBox : ControlBase
{
    #region Publics
    public async Task OnUserChanged(ChangeEventArgs e)
    {
        this.DataMember.SetMemberValue(e.Value?.ToString() ?? string.Empty);

        if(this.IsNeedToUpdateState)
        {
            await this.CallbackStateChanged.InvokeAsync();
        }
    }
    #endregion
}