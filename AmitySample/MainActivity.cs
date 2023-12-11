using Com.Amity.Socialcloud.Sdk.Api.Core;
using Com.Amity.Socialcloud.Sdk.Api.Core.Encryption;
using Com.Amity.Socialcloud.Sdk.Api.Core.Endpoint;
using Com.Amity.Socialcloud.Sdk.Model.Core.Session;

namespace AmitySample;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        AmityCoreClient.Instance.Setup("APIKEY", AmityEndpoint.US.Instance, AmityDBEncryption.NONE.Instance).Subscribe();

        System.Diagnostics.Debug.WriteLine("STATUS :: " + AmityCoreClient.Instance.CurrentSessionState.ToString());

        //AmityCoreClient.Instance.Login("academy9989",new Session )

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
    }

    public partial class MySessionHandler : Com.Amity.Socialcloud.Sdk.Model.Core.Session.
    {

    }
}



