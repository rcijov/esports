using esports.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using esports.Controller;

namespace esports.Basics.Module
{

    public class LoadMenu : ILoadMenu
    {
        private static LoadMenu instance;

        public static LoadMenu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoadMenu();
                }
                return instance;
            }
        }

        private List<MenuItemPage> menuList { get; set; }

        private LoadMenu()
        {
            menuList = new List<MenuItemPage>();

            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            var page1 = new MenuItemPage() { Title = "Page 1", Icon = "itemIcon1.png", TargetType = typeof(Page1) };
            var page2 = new MenuItemPage() { Title = "Page 2", Icon = "itemIcon2.png", TargetType = typeof(Page2) };
            var page3 = new MenuItemPage() { Title = "Page 3", Icon = "itemIcon3.png", TargetType = typeof(Page3) };

            // Adding menu items to menuList
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
        }

        public List<MenuItemPage> GetMenuList()
        {
            return menuList;
        }
    }
}
