using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observers
{
    public interface IFlightTicketListener
    {
        void OnFlightTicketPriceChange(string flightName, double newPrice);
    }
}
