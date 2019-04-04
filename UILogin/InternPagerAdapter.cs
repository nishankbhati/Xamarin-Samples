using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace UILogin
{
    public class InternPagerAdapter : PagerAdapter
    {
        private Context context;
        public InternCatalog internCatalog;

        public InternPagerAdapter(Context context,InternCatalog internCatalog)
        {
            this.context = context;
            this.internCatalog = internCatalog;
        }

        public override int Count => internCatalog.NumInterns;

        public override Java.Lang.Object InstantiateItem(View container, int position)
        {
            var imageView = new ImageView(context);           // Instantiate the ImageView and give it an image
            imageView.SetImageResource(internCatalog[position].imageId);

            var viewPager = container.JavaCast<ViewPager>();  //Add image to the viewPager
            viewPager.AddView((imageView));

            return imageView;
        }

        public override void DestroyItem(View container, int position, Java.Lang.Object view)
        {
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.RemoveView(view as View);
        }

        public override bool IsViewFromObject(View view, Java.Lang.Object @object)
        {
            return view == @object;
        }

        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            return new Java.Lang.String(internCatalog[position].Name);
        }
    }
}