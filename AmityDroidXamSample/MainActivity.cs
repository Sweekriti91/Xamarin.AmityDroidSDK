using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Com.Amity.Socialcloud.Uikit;

namespace AmityDroidXamSample
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

        //    var endpoint = ""“https://api.us.amity.co”";
        //    //Authenticate Amity via ApiKey , 
        //    AmityCoreClient.setup(
        //    apiKey = "b0edec5932dff8304f658c4d060a178cd858deebb3673e29",
        //    httpEndpoint = ""“https://api.us.amity.co”",  // optional param, defaulted as SG region 
        //    socketEndpoint = “https://api.us.amity.co” // optional param, defaulted as SG region 
        //)

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
