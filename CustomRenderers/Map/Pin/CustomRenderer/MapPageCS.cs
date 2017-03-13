using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace CustomRenderer
{
	public class MapPageCS : ContentPage
	{
        double ChesterLat = 53.190964;
        double ChesterLong = -2.887349;

        double Falmouth_Lat = 50.149625;
        double Falmouth_Long = -5.071072;

        public MapPageCS ()
		{
			var customMap = new CustomMap {
				MapType = MapType.Street,
				WidthRequest = App.ScreenWidth,
				HeightRequest = App.ScreenHeight
			};

			var pin = new CustomPin {
				Pin = new Pin {
					Type = PinType.Place,
					Position = new Position (ChesterLat, ChesterLong),
					Label = "Steve - Coffee Shop",
					Address = "Marks and Spencer, Chester"
				},
				Id = "Steve",
				Url = "http://www.mmst.org/"
			};

            var pin2 = new CustomPin
            {
                Pin = new Pin
                {
                    Type = PinType.Place,
                    Position = new Position(Falmouth_Lat, Falmouth_Long),
                    Label = "Falmouth Uni",
                    Address = "Falmouth University, Plymouth"
                },
                Id = "Uni",
                Url = "http://www.falmouth.ac.uk"
            };

            customMap.CustomPins = new List<CustomPin> { pin, pin2 };
            customMap.Pins.Add(pin.Pin);
            customMap.Pins.Add(pin2.Pin);

            customMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.79752, -122.40183), Distance.FromMiles(1.0)));

            Content = customMap;
		}
	}
}
