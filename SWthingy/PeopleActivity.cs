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
    [Activity(Label = "PeopleActivity")]
    public class PeopleActivity : Activity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.PeopleLayout);

            var searchBar = FindViewById<EditText>(Resource.Id.searchTxt);
            var searchBtn = FindViewById<Button>(Resource.Id.searchBtn);
            var peopleListView = FindViewById<ListView>(Resource.Id.peopleListView);

            searchBtn.Click += async delegate
            {
                string searchWord = searchBar.Text;
                string queryString = "https://swapi.co/api/people/?search=" + searchWord;
                var data = await DataServicePeople.GetStarWarsPeople(queryString);
                peopleListView.Adapter = new StarWarsPeopleAdapter(this, data.Results);
            };
        }
    }
}
