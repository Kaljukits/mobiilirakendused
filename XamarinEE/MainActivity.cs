using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Xamarin.Essentials;

namespace XamarinEE
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView _batteryLevelView;
        TextView _state;
        TextView _source;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            _batteryLevelView = FindViewById<TextView>(Resource.Id.textView2);
            _state = FindViewById<TextView>(Resource.Id.textView4);
            _source = FindViewById<TextView>(Resource.Id.textView5);
            var batterylevel = Battery.ChargeLevel;
            float BLF = float.Parse(batterylevel.ToString()) * 100;
            _batteryLevelView.Text = BLF.ToString() + "%";

            var state = Battery.State;
            switch (state)
            {
                case BatteryState.Charging:
                    _state.Text = "Currently charging";
                    break;
                case BatteryState.Full:
                    _state.Text = "Battery is full";
                    break;
                case BatteryState.Discharging:
                case BatteryState.NotCharging:
                    _state.Text = "Currently discharging battery or not being charged";
                    break;
                case BatteryState.NotPresent:
                    _state.Text = "Battery doesn't exist in device (desktop computer)";
                    break;
                case BatteryState.Unknown:
                    _state.Text = "Unable to detect battery state";
                    break;
            }

            var source = Battery.PowerSource;
            switch (source)
            {
                case BatteryPowerSource.Battery:
                    _source.Text = "Being powered by the battery";
                    break;
                case BatteryPowerSource.AC:
                    _source.Text = "Being powered by A/C unit";
                    break;
                case BatteryPowerSource.Usb:
                    _source.Text = "Being powered by USB cable";
                    break;
                case BatteryPowerSource.Wireless:
                    _source.Text = "Powered via wireless charging";
                    break;
                case BatteryPowerSource.Unknown:
                    _source.Text = "Unable to detect power source";
                    break;
            }

            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }

        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            float BLF = float.Parse(Battery.ChargeLevel.ToString()) * 100;
            _batteryLevelView.Text = BLF.ToString() + "%";

            var state = Battery.State;
            switch (state)
            {
                case BatteryState.Charging:
                    _state.Text = "Currently charging";
                    break;
                case BatteryState.Full:
                    _state.Text = "Battery is full";
                    break;
                case BatteryState.Discharging:
                case BatteryState.NotCharging:
                    _state.Text = "Currently discharging battery or not being charged";
                    break;
                case BatteryState.NotPresent:
                    _state.Text = "Battery doesn't exist in device (desktop computer)";
                    break;
                case BatteryState.Unknown:
                    _state.Text = "Unable to detect battery state";
                    break;
            }

            var source = Battery.PowerSource;
            switch (source)
            {
                case BatteryPowerSource.Battery:
                    _source.Text = "Being powered by the battery";
                    break;
                case BatteryPowerSource.AC:
                    _source.Text = "Being powered by A/C unit";
                    break;
                case BatteryPowerSource.Usb:
                    _source.Text = "Being powered by USB cable";
                    break;
                case BatteryPowerSource.Wireless:
                    _source.Text = "Powered via wireless charging";
                    break;
                case BatteryPowerSource.Unknown:
                    _source.Text = "Unable to detect power source";
                    break;
            }

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}