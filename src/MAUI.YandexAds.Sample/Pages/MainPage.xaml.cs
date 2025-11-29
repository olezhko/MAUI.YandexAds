using MAUI.YandexAds.Sample.Models;
using MAUI.YandexAds.Sample.PageModels;

namespace MAUI.YandexAds.Sample.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}