using UIKit;
using System;
using Foundation;
using ObjCRuntime;
using CoreAnimation;

namespace Facebook.Shimmer
{
    // @protocol FBShimmering <NSObject>
    [Protocol, Model]
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

        //TODO Find fix for selector issue
        // @required @property (getter = shimmeringHighlightLength, assign, readwrite, nonatomic, setter = setShimmeringHighlightLength:) CGFloat shimmeringHighlightWidth;
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

    interface IFBShimmering { }

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

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern double ShimmerVersionNumber;
    //    [Field("ShimmerVersionNumber", "__Internal")]
    //    double ShimmerVersionNumber { get; }

    //    // extern const unsigned char [] ShimmerVersionString;
    //    [Field("ShimmerVersionString", "__Internal")]
    //    byte[] ShimmerVersionString { get; }
    //}
}