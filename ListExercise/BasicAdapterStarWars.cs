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
using ListExercise.Core;

namespace ListExercise
{
    class BasicAdapterStarWars : BaseAdapter<PeopleDetails>
    {
        List<PeopleDetails> _items;
        Activity _context;

        public BasicAdapterStarWars(Activity context, List<PeopleDetails> items) : base()
        {
            this._context = context;
            this._items = items;
        }

        public override PeopleDetails this[int position]
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
                view = _context.LayoutInflater.Inflate(Resource.Layout.SWapiLayout, null);

            view.FindViewById<TextView>(Resource.Id.textview1).Text = "Name: " + item.Name;
            view.FindViewById<TextView>(Resource.Id.textview2).Text = "Gender: " + item.Gender;
            view.FindViewById<TextView>(Resource.Id.textview3).Text = "Eye Color: " + item.EyeColor;
            view.FindViewById<TextView>(Resource.Id.textview4).Text = "Skin Color: " + item.SkinColor;
            view.FindViewById<TextView>(Resource.Id.textview5).Text = "Hair Color: " + item.HairColor;
            view.FindViewById<TextView>(Resource.Id.textview6).Text = "Mass: " + item.Mass.ToString();
            view.FindViewById<TextView>(Resource.Id.textview7).Text = "Height: " + item.Height.ToString();
            view.FindViewById<TextView>(Resource.Id.textview8).Text = "Birth Year: " + item.BirthYear;
            return view;
        }
    }
}
