using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using InternPortalCore;

namespace UILogin
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private EditText emailEditText;
        private EditText passwordEditText;
        private Button loginButton;
        public string email;
        public string password;
        private ValidateEmailandPassword validateEmailandPassword;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            loginButton = FindViewById<Button>(Resource.Id.LoginButton);
            emailEditText = FindViewById<EditText>(Resource.Id.EmailInput);
            passwordEditText = FindViewById<EditText>(Resource.Id.PasswordInput);


            validateEmailandPassword= new ValidateEmailandPassword();
            
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

        private void LoginButton_Click(object sender, EventArgs e)
        {

            email = emailEditText.Text;
            password = passwordEditText.Text;

            Log.Info("email", email);
            Log.Info("password", password);
            Console.WriteLine(email + " *Email&Password* " + password);

            if (validateEmailandPassword.validatePassword(password) && validateEmailandPassword.validateEmail(email))
            {
                var intent = new Intent(this, typeof(BackActivity));
                StartActivity(intent);
            }

           else
           {
               if (!validateEmailandPassword.validateEmail(email))
               {
                   Log.Info("INVALID"," --email");
               }
               else
               {
                   Log.Info("INVALID", " --password");
               }
           }
        }

    }
} 