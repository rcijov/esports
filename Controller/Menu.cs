using esports.ViewModel;
using esports.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using esports.Basics.Module;

namespace esports.Controller
{

    public partial class Menu : MasterDetailPage
    {
        public ILoadMenu menu;

        private List<MenuItemPage> menuList { get; set; }

        public Menu()
        {
            InitializeComponent();
            menuList = LoadMenu.Instance.GetMenuList();
            LoadingMenu();
        }

        public Menu(ILoadMenu menu)
        {
            this.menu = menu;
            menuList = menu.GetMenuList();
        }

        public void LoadingMenu()
        {
            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(Page1)));
        }

        // Event for Menu Item selection, here we are going to handle navigation based
        // on user selection in menu ListView
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MenuItemPage)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }

        public List<MenuItemPage> GetMenuList()
        {
            return menuList;
        }
    }
}
