using Android.Animation;
using Android.App;
using Android.OS;
using Android.Widget;
using AndroidX.AppCompat.App;
using Facebook.Shimmer;

namespace Sample.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private ShimmerFrameLayout shimmerViewContainer;
        private Button[] presetButtons;
        private int currentPreset = -1;
        private Toast toast = null;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            shimmerViewContainer = FindViewById<ShimmerFrameLayout>(Resource.Id.shimmer_view_container);

            presetButtons = new Button[]{
                FindViewById<Button>(Resource.Id.preset_button0),
                FindViewById<Button>(Resource.Id.preset_button1),
                FindViewById<Button>(Resource.Id.preset_button2),
                FindViewById<Button>(Resource.Id.preset_button3),
                FindViewById<Button>(Resource.Id.preset_button4),
                FindViewById<Button>(Resource.Id.preset_button5),
                FindViewById<Button>(Resource.Id.preset_button6),
            };

            for (int i = 0; i < presetButtons.Length; i++)
            {
                int preset = i;
                presetButtons[i].Click += (s, e) =>
                {
                    SelectPreset(preset, true);
                };
            }

            SelectPreset(0, false);
        }

        protected override void OnResume()
        {
            base.OnResume();
            shimmerViewContainer.StartShimmer();
        }


        protected override void OnPause()
        {
            shimmerViewContainer.StopShimmer();
            base.OnPause();
        }

        private void SelectPreset(int preset, bool showToast)
        {
            if (currentPreset == preset)
            {
                return;
            }

            if (currentPreset >= 0)
            {
                presetButtons[currentPreset].SetBackgroundResource(Resource.Color.preset_button_background);
            }

            currentPreset = preset;
            presetButtons[currentPreset].SetBackgroundResource(Resource.Color.preset_button_background_selected);

            // If a toast is already showing, hide it
            toast?.Cancel();

            var shimmerBuilder = new Shimmer.AlphaHighlightBuilder();
            switch (preset)
            {
                case 1:
                    // Slow and reverse
                    toast = Toast.MakeText(this, "Slow and reverse", ToastLength.Short);
                    shimmerBuilder.SetDuration(5000L).SetRepeatMode(ValueAnimatorRepeatMode.Reverse);
                    break;
                case 2:
                    // Thin, straight and transparent
                    shimmerBuilder.SetBaseAlpha(0.1f).SetDropoff(0.1f).SetTilt(0f);
                    toast = Toast.MakeText(this, "Thin, straight and transparent", ToastLength.Short);
                    break;
                case 3:
                    // Sweep angle 90
                    shimmerBuilder.SetDirection(Shimmer.Direction.TopToBottom).SetTilt(0f);
                    toast = Toast.MakeText(this, "Sweep angle 90", ToastLength.Short);
                    break;
                case 4:
                    // Spotlight
                    shimmerBuilder
                        .SetBaseAlpha(0f)
                        .SetDuration(2000L)
                        .SetDropoff(0.1f)
                        .SetIntensity(0.35f)
                        .SetShape(Shimmer.Shape.Radial);
                    toast = Toast.MakeText(this, "Spotlight", ToastLength.Short);
                    break;
                case 5:
                    // Spotlight angle 45
                    shimmerBuilder
                        .SetBaseAlpha(0f)
                        .SetDuration(2000L)
                        .SetDropoff(0.1f)
                        .SetIntensity(0.35f)
                        .SetTilt(45f)
                        .SetShape(Shimmer.Shape.Radial);
                    toast = Toast.MakeText(this, "Spotlight angle 45", ToastLength.Short);
                    break;
                case 6:
                    // Off
                    toast = Toast.MakeText(this, "Off", ToastLength.Short);
                    shimmerBuilder = null;
                    break;
                default:
                    toast = Toast.MakeText(this, "Default", ToastLength.Short);
                    shimmerBuilder = default(Shimmer.AlphaHighlightBuilder);
                    break;
            }
            shimmerViewContainer.SetShimmer(shimmerBuilder?.Build());

            // Show toast describing the chosen preset, if necessary
            if (showToast)
            {
                toast?.Show();
            }            
        }
    }
}