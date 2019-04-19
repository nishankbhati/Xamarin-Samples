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
    [Activity(Label = "ListActivity")]
    public class ListActivity : Activity
    {

        private List<String> mItems;
        private ListView mListView;
        private Button signOutButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here

             SetContentView(Resource.Layout.activity_list);
            mListView = FindViewById<ListView>(Resource.Id.mylistView);

            mItems = new List<string>();
            mItems.Add("Aayush");
            mItems.Add("Aditya");
            mItems.Add("Arjun");
            mItems.Add("Nishank");
            mItems.Add("Priyanshi");

            ArrayAdapter<string> adapter= new ArrayAdapter<string>(this,Android.Resource.Layout.SimpleListItem1,mItems);

            mListView.Adapter = adapter;

            /*signOutButton = FindViewById<Button>(Resource.Id.SignOutButton);

            signOutButton.Click += SignOutButton_Click;

            mListView.ItemClick += delegate(object sender, AdapterView.ItemClickEventArgs args)
                {
                    Toast.MakeText(Application, ((TextView) args.View).Text, ToastLength.Short).Show();
                }; */
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Intent intent = new Intent(this,typeof(MainActivity));
            StartActivity(intent);
        }
    }
}