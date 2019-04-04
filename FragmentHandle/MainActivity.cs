using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace FragmentHandle
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button addA = FindViewById<Button>(Resource.Id.addAButton);
            Button addB = FindViewById<Button>(Resource.Id.addBButton);
            Button remA = FindViewById<Button>(Resource.Id.remAButton);
            Button remB = FindViewById<Button>(Resource.Id.remBButton);

            addA.Click += addA_Click;
            addB.Click += addB_Click;
            remA.Click += remA_Click;
            remB.Click += remB_Click;

        }

        private void remB_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void remA_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void addB_Click(object sender, EventArgs e)
        {
            Fragment_B fragmentB = new Fragment_B();

            FragmentTransaction transaction = this.FragmentManager.BeginTransaction();
            transaction.Add(Resource.Id.container, fragmentB, "fragB");
            transaction.Commit();
        }

        private void addA_Click(object sender, EventArgs e)
        {
            Fragment_A fragmentA = new Fragment_A();

            FragmentTransaction transaction = this.FragmentManager.BeginTransaction();
            transaction.Add(Resource.Id.container, fragmentA, "fragA");
            transaction.Commit();
        }
    }
}