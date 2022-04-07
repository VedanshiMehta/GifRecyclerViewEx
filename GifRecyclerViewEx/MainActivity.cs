using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.RecyclerView.Widget;
using BumpTech.GlideLib;
using System;
using System.Collections.Generic;

namespace GifRecyclerViewEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private RecyclerView _recyclerView;
        private RecyclerView.LayoutManager _layoutManager;
        private GifAdapter _gifAdapter;
        private List<int> _gifs;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //_imageView = FindViewById<ImageView>(Resource.Id.imageViewGif);
            //Glide.With(this).Load(Resource.Drawable.minion).Into(_imageView);

            _recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerViewGif);

            GetGifs();
            _layoutManager = new GridLayoutManager(this,2,GridLayoutManager.Vertical,false);
            _recyclerView.SetLayoutManager(_layoutManager);

            _gifAdapter = new GifAdapter(_gifs, this);
            _recyclerView.SetAdapter(_gifAdapter);
        }

        private List<int> GetGifs()
        {
            _gifs = new List<int>();
            _gifs.Add(Resource.Drawable.minion);
            _gifs.Add(Resource.Drawable.minion2);
            _gifs.Add(Resource.Drawable.minon3);
            _gifs.Add(Resource.Drawable.minion4);
            _gifs.Add(Resource.Drawable.minon5);
            _gifs.Add(Resource.Drawable.minion);
            _gifs.Add(Resource.Drawable.minion2);
            _gifs.Add(Resource.Drawable.minon3);
            _gifs.Add(Resource.Drawable.minion4);
            _gifs.Add(Resource.Drawable.minon5);
            _gifs.Add(Resource.Drawable.minion);
            _gifs.Add(Resource.Drawable.minion2);
            _gifs.Add(Resource.Drawable.minon3);
            _gifs.Add(Resource.Drawable.minion4);
            _gifs.Add(Resource.Drawable.minon5);



            return _gifs;

        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}