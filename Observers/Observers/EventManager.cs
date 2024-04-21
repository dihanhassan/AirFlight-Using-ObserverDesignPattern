using System;
using System.Collections.Generic;

namespace Observers
{
   
     

    public class EventManager
    {
        private Dictionary<string, List<IFlightTicketListener>> subscribers = new Dictionary<string, List<IFlightTicketListener>>();

        // Method to subscribe a listener to a specific flight ticket
        public void Subscribe(string eventName, IFlightTicketListener listener)
        {
            if (!subscribers.ContainsKey(eventName))
            {
                subscribers[eventName] = new List<IFlightTicketListener>();
            }
            subscribers[eventName].Add(listener);
        }

        // Method to unsubscribe a listener from a specific flight ticket
        public void Unsubscribe(string eventName, IFlightTicketListener listener)
        {
            if (subscribers.ContainsKey(eventName))
            {
                subscribers[eventName].Remove(listener);
            }
        }

        // Method to simulate a change in flight ticket price
        public void ChangeFlightTicketPrice(string eventType, double newPrice)
        {
            if (subscribers.ContainsKey(eventType))
            {
                foreach (var listener in subscribers[eventType])
                {
                    listener.OnFlightTicketPriceChange(eventType, newPrice);
                }
            }
        }

        // Event for flight ticket price change
      

        public void ViewSubscribers(string eventName)
        {
            if (subscribers.ContainsKey(eventName))
            {
                Console.WriteLine($"Subscribers for {eventName}:");
                foreach (var listener in subscribers[eventName])
                {
                    Console.WriteLine(listener.GetType().Name);
                }
            }
            else
            {
                Console.WriteLine($"No subscribers for {eventName}");
            }
        }
    }
}
