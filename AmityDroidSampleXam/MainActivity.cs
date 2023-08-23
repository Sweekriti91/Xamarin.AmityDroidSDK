using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Com.Amity.Socialcloud.Sdk.Api.Core;
using Com.Amity.Socialcloud.Sdk.Api.Core.Endpoint;

namespace AmityDroidSampleXam
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            AmityCoreClient.Instance.Setup("<api_key>", AmityEndpoint.US.Instance);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
