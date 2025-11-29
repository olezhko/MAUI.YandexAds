using Android.Util;
using Com.Yandex.Mobile.Ads.Banner;
using Com.Yandex.Mobile.Ads.Common;
using MAUI.YandexAds.Sample.Pages.Controls;
using Microsoft.Maui.Handlers;

namespace MAUI.YandexAds.Sample.Handlers.AdsBanner
{
    public partial class AdViewHandler : ViewHandler<AdView, BannerAdView>
    {
        public static IPropertyMapper<AdView, AdViewHandler> PropertyMapper = new PropertyMapper<AdView, AdViewHandler>(ViewHandler.ViewMapper)
        {
            [nameof(AdView.AdUnitId)] = MapAdUnitId
        };

        public AdViewHandler() : base(PropertyMapper)
        {
        }

        public AdViewHandler(IPropertyMapper mapper, CommandMapper? commandMapper = null) : base(mapper, commandMapper)
        {
        }

        protected override void ConnectHandler(BannerAdView platformView)
        {
            base.ConnectHandler(platformView);
        }

        protected override void DisconnectHandler(BannerAdView platformView)
        {
            platformView.Dispose();
            base.DisconnectHandler(platformView);
        }

        protected override BannerAdView CreatePlatformView()
        {
            var adView = new BannerAdView(Context)
            {
                
            };

            LoadAd(adView);

            return adView;
        }

        private static void MapAdUnitId(AdViewHandler handler, AdView view)
        {
            handler.PlatformView?.SetAdUnitId(handler.VirtualView?.AdUnitId!);
        }


        private void LoadAd(BannerAdView adView)
        {
            var requestBuilder = new AdRequest.Builder();
            var adRequest = requestBuilder.Build();

            adView.SetAdUnitId(VirtualView?.AdUnitId!);
            adView.SetAdSize(AdSize.StickySize(GetScreenWidth()));
            adView.LoadAd(adRequest);

            //VirtualView.HeightRequest = adView.AdSize!.Height;
            //VirtualView.WidthRequest = adView.AdSize!.Width;
        }

        private int GetScreenWidth()
        {
            DisplayMetrics displayMetrics;

            if (OperatingSystem.IsAndroidVersionAtLeast(30))
            {
                displayMetrics = new DisplayMetrics();
                Context.Display!.GetMetrics(displayMetrics);
            }
            else
            {
                displayMetrics = Context.Resources!.DisplayMetrics!;
            }

            return (int)(displayMetrics.WidthPixels / displayMetrics.Density);
        }
    }
}
