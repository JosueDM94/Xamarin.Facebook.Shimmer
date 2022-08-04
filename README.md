# Xamarin.Facebook.Shimmer

[![NuGet Badge](https://buildstats.info/nuget/Xamarin.Facebook.Shimmer)](https://www.nuget.org/packages/Xamarin.Facebook.Shimmer/)

This is a set of Xamarin bindings of Facebook Shimmer for iOS and Android

Shimmer is an easy way to add a shimmering effect to any view in your app. It's useful as an unobtrusive loading indicator.

![Shimmer](https://raw.githubusercontent.com/JosueDM94/Xamarin.Facebook.Shimmer/master/shimmer.gif)

## Table of Contents ##

- [Installation](#installation)
- [Example](#example)
- [Android](#facebook-shimmer-android)
- [iOS](#facebook-shimmer-ios)

## Installation ##

The latest stable release of the AffirmSDK is [available on NuGet](https://www.nuget.org/packages/Xamarin.Facebook.Shimmer).

## Example ##

A demo app that integrates Affirm is included in the repo. You may clone the [GitHub repository](https://github.com/JosueDM94/Xamarin.Facebook.Shimmer) into a new Visual Studio project folder and run the Examples project.

## Facebook Shimmer Android ##

## Usage Overview

The following snippet shows how you can use ShimmerFrameLayout

```xml
<com.facebook.shimmer.ShimmerFrameLayout
     android:id="@+id/shimmer_view_container"
     android:layout_width="wrap_content"
     android:layout_height="wrap_content">

     ...(your complex view here)...

</com.facebook.shimmer.ShimmerFrameLayout>
```

And thats it! If you specify `auto-start` to be false, then you can start the animation in code:

```cs
ShimmerFrameLayout container = FindViewById<ShimmerFrameLayout>(R.id.shimmer_view_container);
container.StartShimmer(); // If auto-start is set to false
```

## Facebook Shimmer iOS ##

## Usage Overview

To use Shimmer, create a `FBShimmeringView` or `FBShimmeringLayer` and add your content. To start shimmering, set the `Shimmering` property to `true`.

An example of making a label shimmer:

```cs
FBShimmeringView shimmeringView = new FBShimmeringView(this.View.Bounds);
this.View.AddSubview(shimmeringView);

UILabel loadingLabel = new UILabel(shimmeringView.Bounds);
loadingLabel.TextAlignment = UITextAlignment.Center;
loadingLabel.Text = @"Shimmer";
shimmeringView.ContentView = loadingLabel;

// Start shimmering.
shimmeringView.Shimmering = true;
```

There's also an example project. In the example, you can swipe horizontally and vertically to try various shimmering parameters, or tap to start or stop shimmering.