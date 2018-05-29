
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
    [Activity(Label = "LottieControlsActivity")]
    public class LottieControlsActivity : Activity
    {
		Button HideButton, ShowButton;
		LottieAnimationView LottieRadioButtonBG, LottieShyWolf;

		bool isSelected; // for bool checkmark
		float WolfMidProgress = -1; // to be set as mid-point of wolf anim (hiding eyes)

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_controls);

			var tb = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(tb);
            ActionBar.SetDisplayHomeAsUpEnabled(true);

			setupRadio();         
			setupShyWolf();
        }

		void setupRadio() {
			
			// click listener on entire row, stores selected bool to know if to play anim 
            // forward or backwards
			var radioContainer = FindViewById(Resource.Id.radio_container);
            radioContainer.Click += (sender, e) => {
                this.isSelected = !this.isSelected;
                if (isSelected)
                    this.LottieRadioButtonBG.Speed = 1;
                else
                    this.LottieRadioButtonBG.Speed = -1;
                this.LottieRadioButtonBG.PlayAnimation();
            };

            this.LottieRadioButtonBG = FindViewById<LottieAnimationView>(Resource.Id.lottie_button_bg);
			// sets raw resource of anim (from file)
            this.LottieRadioButtonBG.SetAnimation(Resource.Raw.check);
		}

		void setupShyWolf() {
			
			this.LottieShyWolf = FindViewById<LottieAnimationView>(Resource.Id.lottie_wolf);

			// sets raw resource of anim (from file)
            this.LottieShyWolf.SetAnimation(Resource.Raw.shy_wolf);

            this.WolfMidProgress = 0.6f; // this bastard ain't linear

            this.HideButton = FindViewById<Button>(Resource.Id.hide_button);
            this.HideButton.Click += (sender, e) => {

                // already hiding
                if (this.LottieShyWolf.Progress == this.WolfMidProgress)
                    return;

				// limits animation to play from X% -> Y%
                this.LottieShyWolf.SetMinProgress(0f);
                this.LottieShyWolf.SetMaxProgress(this.WolfMidProgress);

                // reset to start.  by decereasing max progress, we can 
				// go 1.0f -> 0.6f, so check again for midpoint
                if (this.LottieShyWolf.Progress == 1f || 
				    this.LottieShyWolf.Progress == this.WolfMidProgress)
                    this.LottieShyWolf.Progress = 0f;

                this.LottieShyWolf.PlayAnimation();            
            };

            this.ShowButton = FindViewById<Button>(Resource.Id.show_button);
            this.ShowButton.Click += (sender, e) => {

                // limits animation to play from X% -> Y%
                this.LottieShyWolf.SetMinProgress(this.WolfMidProgress);
                this.LottieShyWolf.SetMaxProgress(1f);

                // if at start or end, is not hiding.
                if (this.LottieShyWolf.Progress == 1f || this.LottieShyWolf.Progress == 0f)
                    return;

                // is hiding, show!
                this.LottieShyWolf.PlayAnimation();
            };
		}
    }
}
