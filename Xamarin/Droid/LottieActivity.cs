using System;
using System.IO;
using Android.App;
using Android.OS;
using Android.Widget;
using Com.Airbnb.Lottie;
using MyStrength.Droid.Base;
using MyStrength.Injected;
using MyStrength.Services;

namespace MyStrength.Droid.Testing
{
    [Activity(Label = "Lottie Test")]
    public class LottieActivity : BaseActivity
    {

        #region Variables
        public override bool UpEnabled() => true;
        Button Example1Button, Example2Button, Example3Button;
        LottieAnimationView LottieView;
        #endregion

        #region Life Cycle
        public LottieActivity() { }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ActivityTestingLottie);
            setupToolbarTitle("Lottie Sample");
            FindViews();
        }
        #endregion

        #region View Model
        public override void ConfigureAccess()
        {
            throw new NotImplementedException();
        }

        public override void FindViews()
        {
            this.Example1Button = FindViewById<Button>(Resource.Id.example_1);
            this.Example1Button.Click += (sender, e) => { load(0); };

            this.Example2Button = FindViewById<Button>(Resource.Id.example_2);
            this.Example2Button.Click += (sender, e) => { load(1); };

            this.Example3Button = FindViewById<Button>(Resource.Id.example_3);
            this.Example3Button.Click += (sender, e) => { load(2); };

            this.LottieView = FindViewById<LottieAnimationView>(Resource.Id.lottie);
        }
        #endregion

        async void load(int idx) {
            var url = "";
            switch(idx) {
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
        }
    }
}
