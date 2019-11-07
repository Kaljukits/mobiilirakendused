using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using StarWarsApp.Core;

namespace SWthingy
{
    [Activity(Label = "PlanetsActivity")]
    public class PlanetsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PlanetsLayout);

            var searchBar = FindViewById<EditText>(Resource.Id.searchTxtPlanets);
            var searchButton = FindViewById<Button>(Resource.Id.searchBtnPlanets);
            var peopleListView = FindViewById<ListView>(Resource.Id.planetsListView);

            searchButton.Click += async delegate
            {
                string searchWord = searchBar.Text;
                string queryString = "https://swapi.co/api/planets/?search=" + searchWord;
                var data = await DataServicePlanets.GetStarWarsPlanets(queryString);
                peopleListView.Adapter = new StarWarsPlanetsAdapter(this, data.Results);
            };

        }
    }
}
