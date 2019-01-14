using System;
using Lottie.Forms;
using Xamarin.Forms;

namespace XamarinForms
{
	public class MyPage : ContentPage
	{
		public MyPage()
		{
			var x = "Off";
			var animationView = new AnimationView()
			{
				Animation = "https://www.lottiefiles.com/storage/datafiles/kuhWLbtVdLIP4PK/data.json",
				Loop = true,
				AutoPlay = false,
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				IsEnabled = true,
				IsVisible = true
			};
			//animationView.IsPlaying = true;
			var playButton = new Button()
			{
				Text = "Play"
			};
			playButton.Clicked += (sender, e) => animationView.Play();


			var tap = new TapGestureRecognizer
			{
				Command = new Command(() =>
				{
					animationView.IsPlaying = true;
					if (x == "Off")
						x = "On";
					else
						x = "Off";
				}),
				NumberOfTapsRequired = 1
			};
			animationView.GestureRecognizers.Add(tap);

			Content = new StackLayout
			{
				Children = {
					animationView,
					playButton,
					new Label { Text = x }
				},
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
		}
	}
}

