using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace LLC
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button _button = FindViewById<Button>(Resource.Id.button1);
            _button.Click += _button_Click;

            Button _button2 = FindViewById<Button>(Resource.Id.button2);
            _button2.Click += _button2_Click;

            Button _button3 = FindViewById<Button>(Resource.Id.button3);
            _button3.Click += _button3_Click;

            Button _button4 = FindViewById<Button>(Resource.Id.button4);
            _button4.Click += _button4_Click;
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void _button_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Challenge1Activity));
            StartActivity(intent);
        }

        private void _button2_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Challenge2Activity));
            StartActivity(intent);
        }

        private void _button3_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Challenge3Activity));
            StartActivity(intent);
        }

        private void _button4_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(Challenge4Activity));
            StartActivity(intent);
        }
    }
}