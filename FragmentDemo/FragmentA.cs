﻿using Android.App;
using Android.OS;
using Android.Views;

namespace FragmentDemo
{
    public class FragmentA : Fragment
    {
        //public override void OnCreate(Bundle savedInstanceState)
        //{
        //    base.OnCreate(savedInstanceState);

        //    // Create your fragment here
        //}

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            View view = inflater.Inflate(Resource.Layout.fragment_a, container, false);

            return view;
        }
    }
}