using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Support.V4.Util;
using Android.Util;
using Android.Widget;

namespace FragmentDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button addA = FindViewById<Button>(Resource.Id.addAbtn);
            Button addB = FindViewById<Button>(Resource.Id.addBbtn);
            Button remA = FindViewById<Button>(Resource.Id.remAbtn);
            Button remB = FindViewById<Button>(Resource.Id.remBbtn);

            addA.Click += AddA_Click;
            addB.Click += AddB_Click;
            remA.Click += RemA_Click;
            remB.Click += RemB_Click;

        }

        private void RemB_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void RemA_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void AddB_Click(object sender, System.EventArgs e)
        {
            FragmentB fragmentB = new FragmentB();
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            transaction.Add(Resource.Id.container, fragmentB, "fragB");
            transaction.Commit();
        }

        private void AddA_Click(object sender, System.EventArgs e)
        {
           Log.Info("KKKKKKK","Add A button Clicked");
           FragmentA  fragmentA = new FragmentA();
           FragmentTransaction transaction = FragmentManager.BeginTransaction();
           transaction.Add(Resource.Id.container, fragmentA, "fragA");
           transaction.Commit();
        }
    }
}