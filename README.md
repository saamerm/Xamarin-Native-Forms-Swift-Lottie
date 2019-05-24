Denver-IUDG Meetup-Lottie Animations
============
GitHub repository for the iOS User Developer Group Meetup on May 29th 2018 at Slalom 1899 Wynkoop St Suite 800, Denver, CO 80202. Greg Fein and Saamer Mansoor will be presenting Lottie as a tool to create beautiful vector animations

Contents
-------------

### 1. What is Lottie? 2-5 minute -S 
Lottie is a light weight iOS, Android, and React Native library that makes it easy to add high quality animation to any app. The library renders After Effects animations in real time, allowing apps to use animations as easily as they use static images. Lottie provides a flexible animation format that is playable on multiple platforms - Web, iOS and Android, thus enabling companies to provide a uniform UX and UI. 

### 2. How Lottie works -G
Implementation and Description

### 3. Show implementation of Lottie when stored on device & web -G

### 4. JSON Description -S
The JSON contains different values for after effects features 
https://github.com/airbnb/lottie-ios#supported-after-effects-features


You also have the ability to change colors be manipulating the JSON file 
https://github.com/airbnb/lottie-ios#now-lets-change-their-colors

### 5. Pipeline Video -G
There's a video put together that shows from beginning to end of creating a Lottie Animation in this repository (.mov) file

### 6. Xamarin Native, Swift, Xamarin Forms, React Native -G and -S
Demo Controls w/Examples and ways to build project

Radio Button - G

Swift Example from scratch

### 7. Going fancy-Easing & other features -S

##### Easing
Is easing available, does it exist? Not from the get go, but you could potentially edit the animation object properties to edit speed

##### Translation
You can use the standard iOS (platform specific) animation functionalities to perform functions like translation
```
let translation = gesture.getTranslationInView(self.view)
let progress = translation.y / self.view.bounds.size.height;
animationView.animationProgress = progress
```

##### Interpolation and Reversability
Interpolation, Running person ->Trips if fails -> Crosses finish line if failed

Definitely a possibility
```
animationView.play(fromProgress: 0, toProgress: 0.25, withCompletion: nil)
animationView.play(fromProgress: 0.5, toProgress: 1, withCompletion: nil)
```


Forward and Backward animations-

```
animationView.play(fromProgress: 0.25, toProgress: 0.5, withCompletion: nil)
animationView.play(fromProgress: 0.5, toProgress: 0.25, withCompletion: nil)
```

### 8. Alternatives, Pros & Cons -G and -S

##### Pros
* Allows A/B testing by supporting  loading JSON files over the network
* Optional caching mechanism
* Can change animation speed in app
* Animations can be driven by gestures
* Easy to create with AfterEffects

##### Cons


##### Alternatives-
Marcus Eckert’s Squall- Only supports iOS, but popular because of the After Effects preview app. 

Facebook’s Keyframes- Only supports a small set of After Effects features to support, since they were focusing mainly on reactions

Framer- 

### 9. LottieFiles.com -S

CoFounder is on Forbes 30 over 30.

An online community to find, test, edit, and share Lottie animations.
