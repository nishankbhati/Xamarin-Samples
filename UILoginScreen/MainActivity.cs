using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace UILoginScreen
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        //private Button loginButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText emailText = FindViewById<EditText>(Resource.Id.EmailInput);

            var loginButton = FindViewById<Button>(Resource.Id.LoginButton);

            loginButton.Click += LoginButton_Click;
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
           // throw new System.NotImplementedException();
           var intent = new Intent(this,typeof(BackActivity));
           StartActivity(intent);
        }
    }
}