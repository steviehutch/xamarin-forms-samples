using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace CustomRenderer
{
	public partial class MapPage : ContentPage
	{
        double FalmouthLat = 50.149181;
        double FalmouthLong = -5.070855;

        double CoffeeChesterLat = 53.191012;
        double CoffeeChesterLong = -2.887430;

        public MapPage ()
		{
			InitializeComponent ();

            var pin = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(37.79752, -122.40183),
                    Label = "Xamarin San Francisco Office",
                    Address = "394 Pacific Ave, San Francisco CA"
                },
                Id = "Xamarin",
                Url = "http://xamarin.com/about/"
            };

            var pin1 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(CoffeeChesterLat, CoffeeChesterLong),
                    Label = "StevieHutch",
                    Address = "Coffee shop in Chester"
                },
                Id = "StevieHutch",
                Url = "http://mmst.org/"
            };

            var pin2 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(FalmouthLat, FalmouthLong),
                    Label = "Falmouth University",
                    Address = "394 Pacific Ave, San Francisco CA"
                },
                Id = "Falmouth",
                Url = "http://falmouth.ac.uk/"
            };

            customMap.CustomPins = new List<CustomPin> { pin, pin1, pin2 };
			customMap.Pins.Add(pin.Pin);
            customMap.Pins.Add(pin1.Pin);
            customMap.Pins.Add(pin2.Pin);

            customMap.MoveToRegion (MapSpan.FromCenterAndRadius (new Position (CoffeeChesterLat, CoffeeChesterLong), Distance.FromMiles (1.0)));
		}
	}
}
