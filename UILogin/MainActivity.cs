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
        private EditText emailEditText;
        private EditText passwordEditText;
        private Button loginButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            loginButton = FindViewById<Button>(Resource.Id.LoginButton);
            emailEditText = FindViewById<EditText>(Resource.Id.EmailInput);
            passwordEditText = FindViewById<EditText>(Resource.Id.PasswordInput);
            
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

        protected bool validateEmail()
        {
           bool validEmail = true;
           string email = emailEditText.Text.ToString();

           Log.Info("Validate email", email);
           return validEmail;
        }

        protected bool validatePassword()
        {
            string password = passwordEditText.Text.ToString();

            return (password.Length > 6);
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            if (validateEmail() && validatePassword())
            {
                var intent = new Intent(this, typeof(BackActivity));
                StartActivity(intent);
            }
        }

    }
} 