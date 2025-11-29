namespace MAUI.YandexAds.Sample.Pages.Controls
{
    public class AdView : View
    {
        public static readonly BindableProperty AdUnitIdProperty =
            BindableProperty.Create(nameof(AdUnitId), typeof(string), typeof(AdView));

        public string AdUnitId
        {
            get => (string)GetValue(AdUnitIdProperty);
            set => SetValue(AdUnitIdProperty, value);
        }
    }
}
