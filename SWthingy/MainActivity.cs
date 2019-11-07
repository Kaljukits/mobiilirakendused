using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using StarWarsApp.Core;
using System;
using Android.Content;

namespace SWthingy
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            SetContentView(Resource.Layout.activity_main);

            var PeopleBtn = FindViewById<Button>(Resource.Id.PeopleButton);
            var PlanetsBtn = FindViewById<Button>(Resource.Id.PlanetsButton);

            PeopleBtn.Click += PeopleBtnClick;
            PlanetsBtn.Click += PlanetsBtnClick;

        }

        private void PlanetsBtnClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(PlanetsActivity));
            this.StartActivity(intent);
        }

        private void PeopleBtnClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(PeopleActivity));
            this.StartActivity(intent);
        }

    }
}