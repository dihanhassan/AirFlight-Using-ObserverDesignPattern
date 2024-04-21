using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observers
{
    public class TravelAgency : IFlightTicketListener
    {
        public void OnFlightTicketPriceChange(string flightName, double newPrice)
        {
            Console.WriteLine($"Travel agency reacting to price change of {flightName}. New price: {newPrice}");
            // Implement travel agency's reaction to price change
        }
    }
}
