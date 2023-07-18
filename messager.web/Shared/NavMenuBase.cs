using Microsoft.AspNetCore.Components;

namespace messager.web.Shared;

public class NavMenuBase:ComponentBase{
    private messager.model.NavMenu[]? navMenus;
    protected override void OnInitialized()
    {
        navMenus = messager.web.Data.NavData.GetNavMenu();
    }
}