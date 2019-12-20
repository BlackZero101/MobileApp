using MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace MobileApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppShell : Shell
	{
        //private List<ProfileMenuItem> _authUserMenuItems = new List<ProfileMenuItem>();

        //public List<ProfileMenuItem> CreateAuthMenuItems()
        //{
        //    if (true)
        //    {
        //        _authUserMenuItems = new List<ProfileMenuItem>()
        //        {
        //            new ProfileMenuItem
        //            {
        //                Title = "dashboard",
        //                IconImage = "home.png",
        //                Id = AppPages.Dashboard,
        //                Pages = new List<MyPage>
        //                {
        //                    new MyPage
        //                    {
        //                        TabIndx=0,
        //                        IconImage = "home.png",
        //                        Title ="dashboard",
        //                        Page = new DashboardPage(),
        //                        Id = AppPages.Dashboard
        //                    },
        //                    new MyPage
        //                    {
        //                        TabIndx=3,
        //                        IconImage = "home.png",
        //                        Title = "profile",
        //                        Page = new ProfilePage(),
        //                        Id = AppPages.Profile
        //                    },
        //                    new MyPage
        //                    {
        //                        TabIndx=4,
        //                        IconImage = "home.png",
        //                        Title = "privacy",
        //                        Page = new PrivacyPage(),
        //                        Id = AppPages.Privacy
        //                    },
        //                    new MyPage
        //                    {
        //                        TabIndx=5,
        //                        IconImage = "home.png",
        //                        Title = "list",
        //                        Page = new ListPage(),
        //                        Id = AppPages.List
        //                    }
        //                }
        //            },
        //            new ProfileMenuItem
        //            {
        //                TabIndx=1,
        //                Title = "menu 11", IconImage = "home.png",
        //                Id = AppPages.Favorite,
        //                Pages = new List<MyPage>
        //                    {new MyPage {IconImage = "home.png", Title = "Title 1", Page = new FavoritePage()}}
        //            },
        //            new ProfileMenuItem
        //            {
        //                TabIndx=2,
        //                Title = "menu 22", IconImage = "home.png",
        //                Id = AppPages.Login,
        //                Pages = new List<MyPage>
        //                    {new MyPage {IconImage = "home.png", Title = "Title 1", Page = new LoginPage()}}
        //            },
        //        };
        //    }

        //    return _authUserMenuItems;
        //}

        //private List<MenuItem> _menuItems = new List<MenuItem>();

        //public List<MenuItem> CreateMenuItems()
        //{
        //    if (true)
        //    {
        //        _menuItems = new List<MenuItem>()
        //        {
        //            new MenuItem
        //            {
        //                Text = "menu 1",
        //                IconImageSource = "home.png",
        //                Command=new Command(async ()=>
        //                {
        //                    ShellNavigationState state = Shell.Current.CurrentState;
        //                    await Shell.Current.Navigation.PushAsync(new ListPage());
        //                    Shell.Current.FlyoutIsPresented = false;
        //                })
        //            },
        //            new MenuItem
        //            {
        //                Text = "menu 2",
        //                IconImageSource = "home.png",
        //                Command=new Command(async ()=>
        //                {
        //                    ShellNavigationState state = Shell.Current.CurrentState;
        //                    await Shell.Current.Navigation.PushAsync(new ListPage());
        //                    Shell.Current.FlyoutIsPresented = false;
        //                })
        //            },
        //            new MenuItem
        //            {
        //                Text = "menu 3",
        //                IconImageSource = "home.png",
        //                Command=new Command(async ()=>
        //                {
        //                    ShellNavigationState state = Shell.Current.CurrentState;
        //                    await Shell.Current.Navigation.PushAsync(new ListPage());
        //                    Shell.Current.FlyoutIsPresented = false;
        //                })
        //            },
        //        };
        //    }

        //    return _menuItems;
        //}

        public AppShell()
        {
            InitializeComponent();

            Shell.SetTabBarIsVisible(this, false);

            //CreateAuthMenuItems().Select(x => x.ToProfileMenuFlyoutItem()).ForEach(Items.Add);

            //foreach (var item in CreateMenuItems())
            //{
            //    Items.Add(item);
            //}
        }

        //protected override void OnNavigating(ShellNavigatingEventArgs e)
        //{
        //    if (e.Target.Location.OriginalString.Contains("//info"))
        //    {
        //        Shell.Current.CurrentItem.Route = "//info/inPage";
        //        e.Cancel();
        //    }
        //}

        //protected override bool OnBackButtonPressed()
        //{
        //    if (Shell.Current.FlyoutIsPresented)
        //    {
        //        Shell.Current.FlyoutIsPresented = false;
        //        return true;
        //    }
        //    else if (Shell.Current.Navigation.NavigationStack.Count() <= 1)
        //    {
        //        if (Shell.Current.CurrentItem.CurrentItem.Route == AppPages.HomeTab.ToString())
        //        {
        //            return false;
        //        }
        //        if (Shell.Current.CurrentItem.Route == AppPages.StoreLocator.ToString())
        //        {
        //            if (DependencyService.Get<StoreLocatorViewModel>().IsOutlet)
        //            {
        //                DependencyService.Get<StoreLocatorViewModel>().IsOutlet = false;
        //                DependencyService.Get<OutletStoreViewModel>().IsShowOutlet = false;
        //                _navigationService.NavigateShell(AppPages.OutletTab);
        //                return true;
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Shell.Current.Navigation.PopAsync();
        //        return true;
        //    }

        //    if (Shell.Current.CurrentItem.Route == AppPages.Login.ToString())
        //    {
        //        return false;
        //    }
        //    _navigationService.NavigateShell(AppPages.HomeTab);
        //    return true;
        //}
    }

    //static class NavigationItemExtension
    //{
    //    public static FlyoutItem ToProfileMenuFlyoutItem(this ProfileMenuItem item)
    //    {
    //        var flyout = new FlyoutItem
    //        {      
    //            Title = item.Title,
    //            Icon = item.IconImage,
    //            Route = item.Id.ToString(),
    //            TabIndex = item.TabIndx,
    //    };

    //        if (item.Pages.Count > 0 && item.Pages != null)
    //        {
    //            if (item.Pages.Count == 1)
    //            {
    //                var singlePage = item.Pages.First();
    //                flyout.Items.Add(new ShellContent { Content = singlePage.Page });
    //            }
    //            else
    //            {
    //                flyout.FlyoutDisplayOptions = FlyoutDisplayOptions.AsMultipleItems;
    //                foreach (var ItemPage in item.Pages)
    //                {
    //                    flyout.Items.Add(new ShellSection
    //                    {
    //                        Items = { new ShellContent { Content = ItemPage.Page } },
    //                        Icon = ItemPage.IconImage,
    //                        Title = ItemPage.Title,
    //                        Route = ItemPage.Id.ToString(),
    //                    });
    //                }
    //            }
    //        }

    //        return flyout;
    //    }
    //}

    //public class LoginMenuItem
    //{
    //    public AppPages Id { get; set; }
    //    public Page Page { get; set; }
    //}

    //public enum AppPages
    //{
    //    Login,
    //    Dashboard,
    //    Favorite,
    //    List,
    //    More,
    //    Privacy,
    //    Profile
    //}

    //public class ProfileMenuItem
    //{
    //    public AppPages Id { get; set; }
    //    public int TabIndx { get; set; }
    //    public string Title { get; set; }
    //    public string IconImage { get; set; }
    //    public List<MyPage> Pages { get; set; }
    //    public bool HasImage => IconImage != null;
    //}

    //public class MyMenuItem
    //{
    //    public AppPages Id { get; set; }

    //    public string Title { get; set; }
    //    public string IconImage { get; set; }
    //    public ICommand Command { get; set; }
    //}

    //public class MyPage
    //{
    //    public int TabIndx { get; set; }
    //    public AppPages Id { get; set; }
    //    public string Title { get; set; }
    //    public string IconImage { get; set; }
    //    public Page Page { get; set; }
    //    public bool HasImage => IconImage != null;
    //}
}