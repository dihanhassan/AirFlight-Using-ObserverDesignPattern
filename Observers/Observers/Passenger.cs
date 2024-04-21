using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observers
{
    public class Passenger : IFlightTicketListener
    {
        public void OnFlightTicketPriceChange(string flightName, double newPrice)
        {
            Console.WriteLine($"Passenger reacting to price change of {flightName}. New price: {newPrice}");
            // Implement passenger's reaction to price change
        }
    }
}
