
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
using Com.Airbnb.Lottie;

namespace LottieTest.Droid.Activities
{
    [Activity(Label = "LottieFromAssetsActivity")]
    public class LottieFromAssetsActivity : Activity
    {
		LottieAnimationView LottieRadioButtonBG, LottieShyWolf;
		TextView FileLocation;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_from_assets);

			var tb = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(tb);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

			this.FileLocation = FindViewById<TextView>(Resource.Id.file_location);
			setupRadio();
            setupShyWolf();
        }

        void setupRadio()
        {

            // click listener on entire row, stores selected bool to know if to play anim 
            // forward or backwards
            var radioContainer = FindViewById(Resource.Id.radio_container);
			radioContainer.Click += (sender, e) =>
			{
				this.LottieRadioButtonBG.PlayAnimation();
				this.FileLocation.Text = "R.raw.check / check.json";
			};

            this.LottieRadioButtonBG = FindViewById<LottieAnimationView>(Resource.Id.lottie_button_bg);
            // sets raw resource of anim (from file)
            this.LottieRadioButtonBG.SetAnimation(Resource.Raw.check);
        }

        void setupShyWolf()
        {

            this.LottieShyWolf = FindViewById<LottieAnimationView>(Resource.Id.lottie_wolf);         
            // sets raw resource of anim (from file)
            this.LottieShyWolf.SetAnimation(Resource.Raw.shy_wolf);
			this.LottieShyWolf.Click += (sender, e) =>
			{
				this.LottieShyWolf.PlayAnimation();
				this.FileLocation.Text = "R.raw.shy_wolf / shy_wolf.json";
			};
        }


    }
}
