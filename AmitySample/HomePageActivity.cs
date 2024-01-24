using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using AmityDroid;
namespace AmitySample;

[Activity(Label = "HomePageActivity")]
public class HomePageActivity : AppCompatActivity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Create your application here
        SetContentView(Resource.Layout.activity_homepage);

        LoadFragment();
    }

    public void LoadFragment()
    {
        var fragmentManager = SupportFragmentManager.BeginTransaction();
        //var homefrag = AmityCommunityHomePageFragment
        fragmentManager.Replace(Resource.Id.fragmentContainer, homefrag);
        fragmentManager.Commit();
    }
}
