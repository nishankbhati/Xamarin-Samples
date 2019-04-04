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
    public class InternCatalog
    {
        public static InternModel[] internBuiltInCatalog =
        {
            new InternModel
            {
                imageId = Resource.Mipmap.aayush,
                Name = "Aayush"
            },
            new InternModel
            {
                imageId = Resource.Mipmap.aditya,
                Name = "Aditya"
            },
            new InternModel
            {
                imageId = Resource.Mipmap.arjun,
                Name = "Arjun"
            },
            new InternModel
            {
                imageId = Resource.Mipmap.nishank,
                Name = "Nishank"
            },
            new InternModel
            {
                imageId = Resource.Mipmap.priyanshi,
                Name ="Priyanshi"
            },
       };

        private InternModel[] internPage;

        public InternCatalog()
        {
            internPage = internBuiltInCatalog;
        }

        public InternModel this[int i]
        {
            get { return internPage[i]; }
        }

        public int NumInterns
        {
            get { return internPage.Length; }
        }

    }
}