using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.RecyclerView.Extensions;
using Android.Views;
using Android.Widget;

namespace ListExercise
{
    [Activity(Label = "FirstExampleActivity")]
    public class FirstExampleActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            List<WeatherInfo> _items;
            var queryString = "https://www.metaweather.com/api/location/4418";
            //var data = Core.DataService.GetDataFromService(queryString);

            _items = new List<WeatherInfo>()
            {
                new WeatherInfo(){Name="Esmaspäev",Temperature="12C",WindSpeed="4m/s"},
                new WeatherInfo(){Name="Teisipäev",Temperature="10C",WindSpeed="5m/s"},
                new WeatherInfo(){Name="Kolmapäev",Temperature="12C",WindSpeed="4m/s"},
                new WeatherInfo(){Name="Neljapäev",Temperature="12C",WindSpeed="4m/s"},
                new WeatherInfo(){Name="Reede",Temperature="12C",WindSpeed="4m/s"},
                new WeatherInfo(){Name="Laupäev",Temperature="12C",WindSpeed="4m/s"},
                new WeatherInfo(){Name="Pühapäev",Temperature="12C",WindSpeed="4m/s"},
            };

            ListAdapter = new BasicAdapter(this, _items);
            ListView.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                //var item=_items[args]
                Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Short).Show();
            };
        }
    }
}