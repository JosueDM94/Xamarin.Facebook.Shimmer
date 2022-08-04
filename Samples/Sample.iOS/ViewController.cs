using System;
using CoreGraphics;
using Facebook.Shimmer;
using UIKit;

namespace Sample.iOS
{
    public partial class ViewController : UIViewController
    {
        UIImageView _wallpaperView;
        FBShimmeringView _shimmeringView;
        UILabel _logoLabel;
        UILabel _valueLabel;

        nfloat _panStartValue;
        bool _panVertical;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override bool PrefersStatusBarHidden()
        {
            return true;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.View.BackgroundColor = UIColor.Black;

            _wallpaperView = new UIImageView(this.View.Bounds);
            _wallpaperView.Image = UIImage.FromBundle(@"Wallpaper");
            _wallpaperView.ContentMode = UIViewContentMode.ScaleAspectFill;
            this.View.AddSubview(_wallpaperView);

            CGRect valueFrame = this.View.Bounds;
            valueFrame.Size = new CGSize(valueFrame.Size.Width, valueFrame.Size.Height * 0.25);

            _valueLabel = new UILabel(valueFrame);
            _valueLabel.Font = UIFont.FromName(name: @"HelveticaNeue-UltraLight", size: 32.0f);
            _valueLabel.TextColor = UIColor.White;
            _valueLabel.TextAlignment = UITextAlignment.Center;
            _valueLabel.Lines = 0;
            _valueLabel.Alpha = 0.0f;
            _valueLabel.BackgroundColor = UIColor.Clear;
            this.View.AddSubview(_valueLabel);

            _shimmeringView = new FBShimmeringView();
            _shimmeringView.ShimmeringBeginFadeDuration = 0.3;
            _shimmeringView.ShimmeringOpacity = 0.3f;
            this.View.AddSubview(_shimmeringView);
            _shimmeringView.Shimmering = true;

            _logoLabel = new UILabel(_shimmeringView.Bounds);
            _logoLabel.Text = @"Shimmer";
            _logoLabel.Font = UIFont.FromName(name: @"HelveticaNeue-UltraLight", size: 60f);
            _logoLabel.TextColor = UIColor.White;
            _logoLabel.TextAlignment = UITextAlignment.Center;
            _logoLabel.BackgroundColor = UIColor.Clear;
            _shimmeringView.ContentView = _logoLabel;

            UITapGestureRecognizer tapRecognizer = new UITapGestureRecognizer(Tapped);
            this.View.AddGestureRecognizer(tapRecognizer);

            UIPanGestureRecognizer panRecognizer = new UIPanGestureRecognizer(Panned);
            this.View.AddGestureRecognizer(panRecognizer);
        }

        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();
            CGRect shimmeringFrame = this.View.Bounds;
            shimmeringFrame.Y = shimmeringFrame.Size.Height * 0.68f;
            shimmeringFrame.Height = shimmeringFrame.Size.Height * 0.32f;
            _shimmeringView.Frame = shimmeringFrame;
        }

        public void Tapped(UITapGestureRecognizer tapRecognizer)
        {
            _shimmeringView.Shimmering = !_shimmeringView.Shimmering;            
        }

        public void Panned(UIPanGestureRecognizer panRecognizer)
        {
            CGPoint translation = panRecognizer.TranslationInView(this.View);
            CGPoint velocity = panRecognizer.VelocityInView(this.View);

            if(panRecognizer.State == UIGestureRecognizerState.Began)
            {
                _panVertical = MathF.Abs((float)velocity.Y) > MathF.Abs((float)velocity.X);

                if (_panVertical)
                {
                    _panStartValue = _shimmeringView.ShimmeringSpeed;
                }
                else
                {
                    _panStartValue = _shimmeringView.ShimmeringOpacity;
                }

                this.AnimateValueLabelVisible(true);
            }
            else if (panRecognizer.State == UIGestureRecognizerState.Changed)
            {
                nfloat directional = (_panVertical ? translation.Y : translation.X);
                nfloat possible = (_panVertical ? this.View.Bounds.Size.Height : this.View.Bounds.Size.Width);

                nfloat progress = (directional / possible);

                if (_panVertical)
                {
                    _shimmeringView.ShimmeringSpeed = MathF.Max(0.0f, MathF.Min(1000.0f, (float)(_panStartValue + progress * 200.0f)));
                    _valueLabel.Text = string.Format($"Speed\n{_shimmeringView.ShimmeringSpeed:F1}");
                }
                else
                {
                    _shimmeringView.ShimmeringOpacity = MathF.Max(0.0f, MathF.Min(1.0f, (float)(_panStartValue + progress * 0.5f)));
                    _valueLabel.Text = string.Format($"Opacity\n{_shimmeringView.ShimmeringOpacity:F2}");
                }
            } else if(panRecognizer.State == UIGestureRecognizerState.Ended ||
                panRecognizer.State == UIGestureRecognizerState.Cancelled)
            {
                this.AnimateValueLabelVisible(false);
            }
        }

        public void AnimateValueLabelVisible(bool visible)
        {
            UIViewAnimationOptions options = UIViewAnimationOptions.BeginFromCurrentState;
            UIView.Animate(duration: 0.5, delay: 0.0, options: options, animation: ()=>
            {
                _valueLabel.Alpha = visible ? 1.0f : 0.0f;
            }, completion: null);
        }
    }
}