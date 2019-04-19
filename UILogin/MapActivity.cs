using System;
using Android.App;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Support.V4.App;

namespace UILogin
{
    [Activity(Label = "MapActivity")]
    public class MapActivity : FragmentActivity, IOnMapReadyCallback
    {
        private GoogleMap mMap;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_maps);
            SetUpMap();
        }

        private void SetUpMap()
        {
            if (mMap == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.Gmap).GetMapAsync(this);
            }
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            this.mMap = googleMap;
            mMap.UiSettings.ZoomControlsEnabled = true;

            LatLng latlng = new LatLng(Convert.ToDouble(13.0291),Convert.ToDouble(80.2083));
            CameraUpdate camera = CameraUpdateFactory.NewLatLngZoom(latlng, 10);
            mMap.MoveCamera(camera);

            MarkerOptions options = new MarkerOptions().SetPosition(latlng).SetTitle("Chennai")
                .SetSnippet("Chennai Super Kings ").Draggable(true);

            mMap.AddMarker(options);

            mMap.AddMarker(new MarkerOptions().SetPosition(latlng).SetTitle("Marker 2"));

            mMap.MarkerClick += MMap_MarkerClick;
            mMap.MarkerDragEnd += MMap_MarkerDragEnd;
        }

        private void MMap_MarkerClick(object sender, GoogleMap.MarkerClickEventArgs e)
        {
            LatLng pos = e.Marker.Position;
            mMap.AnimateCamera(CameraUpdateFactory.NewLatLngZoom(pos,10));
        }

        private void MMap_MarkerDragEnd(object sender, GoogleMap.MarkerDragEndEventArgs e)
        {
            LatLng pos = e.Marker.Position;
            Console.WriteLine(pos.ToString());
        }
    }
}