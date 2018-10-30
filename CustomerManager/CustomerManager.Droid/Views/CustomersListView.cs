using Android.App;
using Android.Content.PM;
using Android.OS;
using CustomerManager.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace CustomerManager.Droid.Views
{
    [Activity(ScreenOrientation = ScreenOrientation.Portrait)]
    public class CustomersListView : MvxAppCompatActivity<CustomersListViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.customers_list);
        }
    }
}