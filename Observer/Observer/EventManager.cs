using System;
using System.Collections.Generic;

namespace Observer
{
    public class EventManager
    {
        List<Subscribers.ISubscriber> subscribers = new List<Subscribers.ISubscriber>();
        
        public void subscribe(Subscribers.ISubscriber subscriber)
        {
            this.subscribers.Add(subscriber);
        }

        public void unSubscribe(Subscribers.ISubscriber subscriber)
        {
            this.subscribers.Remove(subscriber);
        }

        public void notify(string doorEvent)
        {
            foreach(Subscribers.ISubscriber subscriber in this.subscribers)
            {
                subscriber.update(doorEvent); 
            }
        }
    }
}
