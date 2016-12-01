using Android.App;
using Android.OS;
using Android.Widget;

namespace MenuActionBar
{
    [Activity(Label = "MenuActionBar", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            ActionBar.Title = "My Toolbar";

            //Add menu click handler
            toolbar.MenuItemClick += (sender, e) => {
                switch (e.Item.ItemId)
                {
                    case Resource.Id.menu_edit:
                        Toast.MakeText(this, "Bottom toolbar pressed: " + e.Item.TitleFormatted, ToastLength.Short).Show();
                        break;
                    case Resource.Id.menu_save:
                        Toast.MakeText(this, "Bottom toolbar pressed: " + e.Item.TitleFormatted, ToastLength.Short).Show();
                        break;
                    case Resource.Id.menu_preferences:
                        StartActivity(typeof(Creditos));
                        break;
                }
            };
        }

        public override bool OnCreateOptionsMenu(Android.Views.IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.top_menus, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        //public override bool OnOptionsItemSelected(Android.Views.IMenuItem item)
        //{//Al seleccionar un icono del actionbar se invoca este metodo
        //    Toast.MakeText(this, "Action selected: " + item.TitleFormatted,
        //        ToastLength.Short).Show();
        //    return base.OnOptionsItemSelected(item);
        //}
    }
}

