using System.Collections.Generic;
using esports.MenuItems;

namespace esports.Basics.Module
{
    public interface ILoadMenu
    {
        List<MenuItemPage> GetMenuList();
    }
}