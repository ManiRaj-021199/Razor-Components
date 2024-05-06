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
    public bool IsNeedToUpdateState { get; set; }

    [Parameter]
    public EventCallback CallbackStateChanged { get; set; }
    #endregion
}