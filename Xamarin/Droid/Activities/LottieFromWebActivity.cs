
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Airbnb.Lottie;

namespace LottieTest.Droid.Activities
{
    [Activity(Label = "LottieFromWebActivity")]
    public class LottieFromWebActivity : Activity
    {

		Button Test1, Test2, Test3;
		LottieAnimationView LottieView;
		TextView FileLocation;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_from_web);

			this.FileLocation = FindViewById<TextView>(Resource.Id.file_location);

			var tb = FindViewById<Toolbar>(Resource.Id.toolbar);
			SetActionBar(tb);
			ActionBar.SetDisplayHomeAsUpEnabled(true);

			this.Test1 = FindViewById<Button>(Resource.Id.button_1);
			this.Test1.Click += (sender, e) => {
                loadTest(0);
            };

			this.Test2 = FindViewById<Button>(Resource.Id.button_2);
			this.Test2.Click += (sender, e) => {
                loadTest(1);
            };

			this.Test3 = FindViewById<Button>(Resource.Id.button_3);
			this.Test3.Click += (sender, e) => {
                loadTest(2);
            };

			this.LottieView = FindViewById<LottieAnimationView>(Resource.Id.lottie);
        }

		async void loadTest(int index) {
			var url = "";
            switch (index)
            {
                case 0:
                    url = "https://www.lottiefiles.com/storage/datafiles/jW5K6vtuzJFJSxd/data.json";
                    break;
                case 1:
                    url = "https://www.lottiefiles.com/storage/datafiles/30e6f85b10d28931e85c2e0fcffa2f59/data.json";
                    break;
                case 2:
                default:
                    url = "https://www.lottiefiles.com/storage/datafiles/8UjWgBkqvEF5jNoFcXV4sdJ6PXpS6DwF7cK4tzpi/Check%20Mark%20Success/Check%20Mark%20Success%20Data.json";
                    break;
            }

            byte[] imageData = null;
            using (var wc = new System.Net.WebClient())
                imageData = wc.DownloadData(url);
            var stream = new MemoryStream(imageData);

            var comp = await LottieComposition.Factory.FromInputStreamAsync(this, stream);
            this.LottieView.Composition = comp;
            this.LottieView.PlayAnimation();
            this.LottieView.RepeatCount = -1;
			this.FileLocation.Text = url;
		}
    }
}
