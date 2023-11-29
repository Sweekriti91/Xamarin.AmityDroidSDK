
//using Com.Amity.Socialcloud.Sdk.Api.Core;
//using Com.Amity.Socialcloud.Sdk.Api.Core.Endpoint;

namespace AmitySample;


[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        //AmityCoreClient

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
    }
}
