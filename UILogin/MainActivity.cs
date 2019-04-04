using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Util;
using Android.Widget;

namespace UILogin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
//            ImageView logoImageView = FindViewById<ImageView>(Resource.Id.Logoimageview);
//            logoImageView.SetImageResource(Resource.Mipmap.starbucks);

            Button loginButton = FindViewById<Button>(Resource.Id.LoginButton);
            

            loginButton.Click += LoginButton_Click;
        }

        protected override void OnResume()
        {
            base.OnPause();
            Log.Info("OnResume","On Resume from Main Activity");
        }

        protected override void OnStop()
        {
            base.OnPause();
            Log.Info("OnStop","On Stop from Main Activity");

        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            Log.Info("OnDestroy","On Destroy from main activity");
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this,typeof(BackActivity));
            StartActivity(intent);
        }

    }
} 