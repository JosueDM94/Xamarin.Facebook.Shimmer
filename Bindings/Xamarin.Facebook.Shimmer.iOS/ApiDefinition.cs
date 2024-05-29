using CoreAnimation;
using Foundation;
using ObjCRuntime;
using UIKit;
using System.Runtime.InteropServices;

namespace Facebook.Shimmer
{
	// @protocol FBShimmering <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface FBShimmering
	{
		// @required @property (getter = isShimmering, assign, readwrite, nonatomic) BOOL shimmering;
		[Abstract]
		[Export("shimmering")]
		bool Shimmering { [Bind("isShimmering")] get; set; }

		// @required @property (assign, readwrite, nonatomic) CFTimeInterval shimmeringPauseDuration;
		[Abstract]
		[Export("shimmeringPauseDuration")]
		double ShimmeringPauseDuration { get; set; }

		// @required @property (assign, readwrite, nonatomic) CGFloat shimmeringAnimationOpacity;
		[Abstract]
		[Export("shimmeringAnimationOpacity")]
		nfloat ShimmeringAnimationOpacity { get; set; }

		// @required @property (assign, readwrite, nonatomic) CGFloat shimmeringOpacity;
		[Abstract]
		[Export("shimmeringOpacity")]
		nfloat ShimmeringOpacity { get; set; }

		// @required @property (assign, readwrite, nonatomic) CGFloat shimmeringSpeed;
		[Abstract]
		[Export("shimmeringSpeed")]
		nfloat ShimmeringSpeed { get; set; }

		// @required @property (assign, readwrite, nonatomic) CGFloat shimmeringHighlightLength;
		[Abstract]
		[Export("shimmeringHighlightLength")]
		nfloat ShimmeringHighlightLength { get; set; }

		// @required @property (getter = shimmeringHighlightLength, assign, readwrite, nonatomic, setter = setShimmeringHighlightLength:) CGFloat shimmeringHighlightWidth;
		//[Introduced(PlatformName.iOS, 2, 0, message: "Use shimmeringHighlightLength instead.")]
		//[Deprecated(PlatformName.iOS, 12, 0, message: "Use shimmeringHighlightLength instead.")]
		//[Abstract]
		//[Export("shimmeringHighlightWidth")]
		//nfloat ShimmeringHighlightWidth { [Bind("shimmeringHighlightLength")] get; [Bind("setShimmeringHighlightLength:")] set; }

		// @required @property (assign, readwrite, nonatomic) FBShimmerDirection shimmeringDirection;
		[Abstract]
		[Export("shimmeringDirection", ArgumentSemantic.Assign)]
		FBShimmerDirection ShimmeringDirection { get; set; }

		// @required @property (assign, readwrite, nonatomic) CFTimeInterval shimmeringBeginFadeDuration;
		[Abstract]
		[Export("shimmeringBeginFadeDuration")]
		double ShimmeringBeginFadeDuration { get; set; }

		// @required @property (assign, readwrite, nonatomic) CFTimeInterval shimmeringEndFadeDuration;
		[Abstract]
		[Export("shimmeringEndFadeDuration")]
		double ShimmeringEndFadeDuration { get; set; }

		// @required @property (readonly, assign, nonatomic) CFTimeInterval shimmeringFadeTime;
		[Abstract]
		[Export("shimmeringFadeTime")]
		double ShimmeringFadeTime { get; }
	}

	// @interface FBShimmeringLayer : CALayer <FBShimmering>
	[BaseType(typeof(CALayer))]
	interface FBShimmeringLayer : FBShimmering
	{
		// @property (nonatomic, strong) CALayer * contentLayer;
		[Export("contentLayer", ArgumentSemantic.Strong)]
		CALayer ContentLayer { get; set; }
	}

	// @interface FBShimmeringView : UIView <FBShimmering>
	[BaseType(typeof(UIView))]
	interface FBShimmeringView : FBShimmering
	{
		// @property (nonatomic, strong) UIView * contentView;
		[Export("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; set; }
	}
}