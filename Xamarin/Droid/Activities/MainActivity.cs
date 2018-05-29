
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

namespace LottieTest.Droid.Activities
{
	[Activity(Label = "MainActivity", MainLauncher = true)]
    public class MainActivity : Activity
    {
		TextView FromWeb, FromAssets, Controls;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_main);

			this.FromWeb = FindViewById<TextView>(Resource.Id.from_web);
			this.FromWeb.Click += (sender, e) => {
				var i = new Intent(this, typeof(LottieFromWebActivity));
                StartActivity(i);
			};

			this.FromAssets = FindViewById<TextView>(Resource.Id.from_assets);
			this.FromAssets.Click += (sender, e) => {
				var i = new Intent(this, typeof(LottieFromAssetsActivity));
				StartActivity(i);
			};

			this.Controls = FindViewById<TextView>(Resource.Id.controls);
			this.Controls.Click += (sender, e) => {
				var i = new Intent(this, typeof(LottieControlsActivity));
                StartActivity(i);
            };
        }
    }
}
