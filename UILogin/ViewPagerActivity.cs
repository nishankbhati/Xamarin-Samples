using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;

namespace UILogin
{
    [Activity(Label = "ViewPagerActivity")]
    public class ViewPagerActivity : Activity
    {
        InternCatalog internCatalog;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_viewPager);

            ViewPager viewPager = FindViewById<ViewPager>(Resource.Id.viewPager);

            internCatalog=new InternCatalog();

            viewPager.Adapter=new InternPagerAdapter(this,internCatalog);
        }
    }
}