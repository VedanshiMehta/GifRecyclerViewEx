using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using BumpTech.GlideLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GifRecyclerViewEx
{
    class GifAdapter : RecyclerView.Adapter
    {
        private List<int> gifs;
        private MainActivity mainActivity;

        public GifAdapter(List<int> gifs, MainActivity mainActivity)
        {
            this.gifs = gifs;
            this.mainActivity = mainActivity;
        }

        public override int ItemCount => gifs.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            GifViewHolder gifViewHolder = holder as GifViewHolder;
            Glide.With(mainActivity).Load(gifs[position]).Into(gifViewHolder._imageView);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.gifListLayout, parent, false);
            return new GifViewHolder(view);
        }

        class GifViewHolder : RecyclerView.ViewHolder
        {
            public ImageView _imageView;
            public GifViewHolder(View itemView) : base(itemView)
            {
                _imageView = itemView.FindViewById<ImageView>(Resource.Id.imageViewGif);
            }
        }
    }
}