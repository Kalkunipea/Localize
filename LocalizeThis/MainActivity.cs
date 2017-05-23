using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;

namespace LocalizeThis
{
    [Activity(Label = "LocalizeThis", MainLauncher = true, Theme = "@android:style/Theme.NoTitleBar",
        ConfigurationChanges = ConfigChanges.Locale | ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var lang = Resources.Configuration.Locale; // eg. "es_ES"





            SetContentView (Resource.Layout.Main);
            var button = FindViewById<Button>(Resource.Id.button1);

            button.Click += delegate {
                var Text = Resources.GetText(Resource.String.Localization);
                var asi = FindViewById<TextView>(Resource.Id.textView1);
                asi.Text = Text;
            };

        }
    }
}

