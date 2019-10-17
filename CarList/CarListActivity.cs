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

namespace CarList
{
    [Activity(Label = "CarListActivity")]
    public class CarListActivity : ListActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            List<Car> _items;
            _items = new List<Car>()
            {
                new Car(){Manufacturer="Toyota",Model="Corolla", Year="2006", KW="81"},
                new Car(){Manufacturer="Nissan",Model="Note", Year="2010", KW="90"},
                new Car(){Manufacturer="BMW",Model="Birb", Year="2022", KW="110"},
                new Car(){Manufacturer="Hyndai",Model="Wig", Year="2021", KW="100"},
                new Car(){Manufacturer="Mercedes-Benz",Model="A250", Year="2019", KW="100"},
                new Car(){Manufacturer="Nissan",Model="Nii", Year="2030", KW="120"},
                new Car(){Manufacturer="Honda",Model="Whyyyy", Year="2023", KW="110"},
                new Car(){Manufacturer="Isuzu",Model="YesIam", Year="2023", KW="110"},
                new Car(){Manufacturer="Suzuki",Model="OraOraOra", Year="2023", KW="130"},
                new Car(){Manufacturer="Toyota",Model="ItWasMe", Year="2023", KW="100"}
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