using Microsoft.AspNetCore.Components;

namespace RazorComponents.Components;

public class ControlBase : ComponentBase
{
    #region Properties
    [Parameter]
    public DataMember DataMember { get; set; } = null!;

    [Parameter]
    public bool IsVisible { get; set; } = true;

    [Parameter]
    public EventCallback CallbackStateChanged { get; set; }
    #endregion

    #region Internals
    internal async Task UpdateState()
    {
        if(this.CallbackStateChanged.HasDelegate)
        {
            await this.CallbackStateChanged.InvokeAsync();
        }
    }
    #endregion

    #region Protecteds
    protected override void OnInitialized()
    {
        if(this.DataMember is null)
        {
            throw new InvalidOperationException();
        }
    }
    #endregion
}