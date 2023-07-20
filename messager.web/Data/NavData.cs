using messager.model;
namespace messager.web.Data;

public class NavData{
    private static readonly List<NavMenu> navMenus = new(){
        new NavMenu(){
            Icon = "images/kenn.JPG",
            Name = "Account"
        },
        new NavMenu(){
            Icon =  "images/mess.svg",
            Name = "message"
        },
        new NavMenu(){
            Icon =  "images/group.png",
            Name = "group"
        },
        new NavMenu(){
            Icon =  "images/notif.svg",
            Name = "notification"
        },
        new NavMenu(){
            Icon =  "images/sett.svg",
            Name = "settings"
        },
    };   
    public static NavMenu[] GetNavMenu(){
        return navMenus.ToArray();
    }
}