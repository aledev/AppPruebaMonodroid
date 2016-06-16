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

namespace AndroidApplication01
{
    [Activity(Label = "My Activity", MainLauncher = false, Icon = "@drawable/icon")]
    public class SpinnerExample : Activity
    {
        Spinner state;
        TextView tvSp;
        ArrayAdapter<String> aas;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SpinerExample);

            state = FindViewById<Spinner>(Resource.Id.Sp);
            tvSp = FindViewById<TextView>(Resource.Id.tvSp);
            aas = new ArrayAdapter<string>(this,
                Android.Resource.Layout.SimpleSpinnerDropDownItem);
            state.Adapter = aas;
            
            aas.Add(String.Empty);
            aas.Add("Alabama");
            aas.Add("Arizona");
            aas.Add("California");
            aas.Add("Tenesse");
            aas.Add("Texas");
            aas.Add("Washington");

            state.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs>(state_ItemSelected);
        }

        protected void state_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            tvSp.Text = Convert.ToString(aas.GetItem(e.Position));
        }
    }
}