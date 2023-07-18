using messager.model;
namespace messager.web.Data;

public class NavData{
    private static readonly List<NavMenu> navMenus = new(){
        new NavMenu(){
            Icon = "images/kenn.JPG",
        },
        new NavMenu(){
            Icon =  "images/mess.svg"
        },
        new NavMenu(){
            Icon =  "images/group.png"
        },
        new NavMenu(){
            Icon =  "images/notif.svg"
        },
        new NavMenu(){
            Icon =  "images/sett.svg"
        },
    };   
    public static NavMenu[] GetNavMenu(){
        return navMenus.ToArray();
    }
    public void seting(){

    } 
}