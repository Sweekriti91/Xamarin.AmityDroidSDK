using Com.Amity.Socialcloud.Sdk.Api.Core;
using Com.Amity.Socialcloud.Sdk.Api.Core.Encryption;
using Com.Amity.Socialcloud.Sdk.Api.Core.Endpoint;

namespace AmitySample;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        _ = AmityCoreClient.Instance.Setup("", AmityEndpoint.US.Instance, AmityDBEncryption.NONE.Instance).Subscribe();

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
    }
}
