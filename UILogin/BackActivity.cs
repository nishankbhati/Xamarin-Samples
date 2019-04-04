using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace UILogin
{
    [Activity(Label = "BackActivity")]
    public class BackActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_back);

            Button backButton = FindViewById<Button>(Resource.Id.GoListButton);
            Button viewPagerButton = FindViewById<Button>(Resource.Id.GoViewPager);
          Button bottomNavigationButton = FindViewById<Button>(Resource.Id.GoBottomNavigation);

            backButton.Click += (sender, e) =>
            {
                Intent intent = new Intent(this,typeof(ListActivity));
                StartActivity(intent);
            };

            viewPagerButton.Click+= (sender, e) =>
            {
                Intent intent = new Intent(this, typeof(ViewPagerActivity));
                StartActivity(intent);
            };

            bottomNavigationButton.Click += (sender, e) =>
            {
                Intent intent = new Intent(this,typeof(BottomNavigationActivity));
                StartActivity(intent);
            };
        }

//        private void BackButton_Click(object sender, EventArgs e)
//        {
//            //throw new NotImplementedException();
//            Intent intent = new Intent(this,typeof(MainActivity));
//            StartActivity(intent);
//        }
    }
}