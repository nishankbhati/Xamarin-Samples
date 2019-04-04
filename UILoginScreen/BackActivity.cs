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

namespace UILoginScreen
{
    [Activity(Label = "BackActivity")]
    public class BackActivity : Activity
    {
        //private Button backbtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.activity_list);
            //Button backbtn = FindViewById<Button>(Resource.Id.gobackbtn);
            //Button backButton = FindViewById<Button>(Resource.Id.gobackbtn);

            //gobackbtn.Click += Backbtn_Click;
          //  backButton.Click += BackButton_Click;

        }

//        private void BackButton_Click(object sender, EventArgs e)
//        {
//           // throw new NotImplementedException();
//            Intent intent = new Intent(this, typeof(MainActivity));
//            StartActivity(intent);
//        }
//
//        private void Backbtn_Click(object sender, EventArgs e)
//        {
//            //throw new NotImplementedException();
//        
 //       }
    }
}