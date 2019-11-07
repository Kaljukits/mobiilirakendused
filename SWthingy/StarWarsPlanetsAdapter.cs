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
using StarWarsApp.Core.Models;

namespace SWthingy
{
    class StarWarsPlanetsAdapter : BaseAdapter<PlanetsDetails>
    {
        List<PlanetsDetails> _items;
        Activity _context;

        public StarWarsPlanetsAdapter(Activity context, List<PlanetsDetails> items) : base()
        {
            this._context = context;
            this._items = items;
        }

        public override PlanetsDetails this[int position]
        {
            get { return _items[position]; }
        }

        public override int Count
        {
            get { return _items.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];

            View view = convertView;

            if (view == null)
            {
                view = _context.LayoutInflater.Inflate(Resource.Layout.planetsrow, null);
            }

            view.FindViewById<TextView>(Resource.Id.textViewP1).Text = "Name: " + item.Name;
            view.FindViewById<TextView>(Resource.Id.textViewP2).Text = "Orbital Period: " + item.Orbital_Period.ToString();
            view.FindViewById<TextView>(Resource.Id.textViewP3).Text = "Rotation Period: " + item.Rotation_Period.ToString();
            view.FindViewById<TextView>(Resource.Id.textViewP4).Text = "Gravity: " + item.Gravity;
            view.FindViewById<TextView>(Resource.Id.textViewP5).Text = "Climate: " + item.Climate;
            view.FindViewById<TextView>(Resource.Id.textViewP6).Text = "Terrain: " + item.Terrain;
            view.FindViewById<TextView>(Resource.Id.textViewP7).Text = "Population: " + item.Population.ToString();
            view.FindViewById<TextView>(Resource.Id.textViewP8).Text = "Surface Water: " + item.Surface_Water.ToString();
            view.FindViewById<TextView>(Resource.Id.textViewP9).Text = "Climate: " + item.Climate.ToString();

            return view;
        }
    }
}