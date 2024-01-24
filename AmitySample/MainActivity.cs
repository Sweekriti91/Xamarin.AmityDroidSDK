using System.Diagnostics;
using Android.Content;
using AndroidX.AppCompat.App;
using Com.Amity.Socialcloud.Sdk.Api.Core;
using Com.Amity.Socialcloud.Sdk.Api.Core.Encryption;
using Com.Amity.Socialcloud.Sdk.Api.Core.Endpoint;
using Com.Amity.Socialcloud.Sdk.Core.Session;
using Com.Amity.Socialcloud.Sdk.Model.Core.Session;
using Java.Interop;
using ReactiveX.RxJava3.Functions;

namespace AmitySample;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : AppCompatActivity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        AmityCoreClient.Instance.Setup("", AmityEndpoint.US.Instance, AmityDBEncryption.NONE.Instance).Subscribe();

        System.Diagnostics.Debug.WriteLine("STATUS :: " + AmityCoreClient.Instance.CurrentSessionState.ToString());

        AmityCoreClient.Instance
            .Login("", new MySessionHandler())
            .AuthToken("")
            .DisplayName("")
            .Build()
            .Submit()
            .DoOnComplete(new CompleteAction())
            .DoOnError(new ErrorAction())
            .Subscribe();

        System.Diagnostics.Debug.WriteLine("STATUS :: " + AmityCoreClient.Instance.CurrentSessionState.ToString());
        System.Diagnostics.Debug.WriteLine("STATUS :: " + AmityCoreClient.Instance.CurrentSessionState.ToString());
        System.Diagnostics.Debug.WriteLine("STATUS :: " + AmityCoreClient.Instance.CurrentSessionState.ToString());

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
        var btn = FindViewById<Button>(Resource.Id.homeshowbutton);
        btn.Click += (s, e) =>
        {
            System.Diagnostics.Debug.WriteLine("STATUS :: " + AmityCoreClient.Instance.CurrentSessionState.ToString());
            var intent = new Intent(this, typeof(HomePageActivity));
            StartActivity(intent);
        };

    }

    public partial class MySessionHandler : Java.Lang.Object,ISessionHandler,IJavaPeerable
    {
        public void SessionWillRenewAccessToken(IAccessTokenRenewal renewal)
        {
            renewal.Renew();
        }
    }

    public partial class CompleteAction : Java.Lang.Object, IAction, IJavaPeerable
    {
        public void Run()
        {
            Debug.WriteLine("LOGIN COMPLETE ACTION");
        }
    }

    public class ErrorAction : Java.Lang.Object, IConsumer, IJavaPeerable
    {
        public void Accept(Java.Lang.Object? t)
        {
            Debug.WriteLine("LOGIN ERRPR  :: " + t);
        }
    }

}



