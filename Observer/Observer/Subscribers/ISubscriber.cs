using System;

namespace Observer.Subscribers
{
    public interface ISubscriber
    {
        public void update(string doorEvent);
    }
}
