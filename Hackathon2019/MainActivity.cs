using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Gms.Maps;

namespace Hackathon2019
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnMapReadyCallback
    {
        GoogleMap mainMap;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            SupportMapFragment mapFragment = (SupportMapFragment)SupportFragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            mainMap = googleMap;
        }

       
    }
}