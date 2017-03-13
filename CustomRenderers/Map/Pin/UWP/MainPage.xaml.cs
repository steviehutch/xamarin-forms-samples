namespace CustomRenderer.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            var BING_MAPS_KEY = "9diqx2Yylc2nGObz2vJe~72boTGI_Y95nNZXXwDeTfw~AgeKkBxU76GeWMtJT8L1T6pDZ48q_OmQj8jalKdp8GDIvs6oHnPWngqusYPsbTPV";

            this.InitializeComponent();
            Xamarin.FormsMaps.Init(BING_MAPS_KEY);
            this.LoadApplication(new CustomRenderer.App());
        }
    }
}
