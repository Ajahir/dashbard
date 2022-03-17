using Fragment = AndroidX.Fragment.App.Fragment;
using Android.Content;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dashbard
{
    public class dashFragment : Fragment
    {
        private Context context;

        public dashFragment()
        {
        }

        public dashFragment(Context context)
        {
            this.context = context;
        }

        
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            View view = inflater.Inflate(Resource.Layout.layout2, container, false);
            return base.OnCreateView(inflater, container, savedInstanceState);
        }
    }
}