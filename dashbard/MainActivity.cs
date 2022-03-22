using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.App;
using dashbard.Resources;
using Google.Android.Material.BottomNavigation;
using static Google.Android.Material.BottomNavigation.BottomNavigationView;

namespace dashbard
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnNavigationItemSelectedListener
    {
        private dashFragment _dashboardFragment;
        private locationFragment _locationFragment;
        private favFragment _favouriteFragment;
        private BottomNavigationView bottomNavigationView;
        private personsFragment _personFragment;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            bottomNavigationView = FindViewById<BottomNavigationView>(Resource.Id.bottomNavigationView);
            bottomNavigationView.SetOnNavigationItemSelectedListener(this);
            _dashboardFragment = new dashFragment();
            _locationFragment = new locationFragment();
            _favouriteFragment=new favFragment();
            _personFragment=new personsFragment();
            SupportFragmentManager.BeginTransaction().Replace(Resource.Id.framelayoutdata, _dashboardFragment).Commit();

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.home:

                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.framelayoutdata, _dashboardFragment).Commit();
                    break;
                case Resource.Id.location:

                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.framelayoutdata, _locationFragment).Commit();
                    break;
                case Resource.Id.favourite:

                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.framelayoutdata, _favouriteFragment).Commit();
                    break;
                case Resource.Id.person:

                    SupportFragmentManager.BeginTransaction().Replace(Resource.Id.framelayoutdata, _personFragment).Commit();
                    break;

            }
            return true;
        }
    }
}