using System;

namespace Observers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();

            // Create subscribers
            Passenger passenger1 = new Passenger();
            Passenger passenger2 = new Passenger();
            TravelAgency agency = new TravelAgency();
            TravelAgency agency2 = new TravelAgency();
            // Subscribe subscribers to the flight ticket of interest
            eventManager.Subscribe("FlightToDhaka", passenger1);
            eventManager.Subscribe("FlightToDhaka", passenger2);
            eventManager.Subscribe("FlightToUSA", agency);
            eventManager.Subscribe("FlightToUSA", agency2);

            // Simulate flight ticket price change
            eventManager.ChangeFlightTicketPrice("FlightToDhaka", 500.00);
            eventManager.ChangeFlightTicketPrice("FlightToUSA", 350.00);
            /* market.OnFlightTicketPriceChange("FlightToDhaka", 150.00);*/

            Console.ReadKey();
        }
    }
}
