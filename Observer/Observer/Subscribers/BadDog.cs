using System;
namespace Observer.Subscribers
{
    public class BadDog : ISubscriber
    {
        EventManager eventManager;
        public int barkCount { get; set; }

        public BadDog(EventManager eventManager)
        {
            this.eventManager = eventManager;
            eventManager.subscribe(this);
        }

        public void update(string doorEvent)
        {
            this.bark();
        }

        public void bark()
        {
            this.barkCount++;
        }
    }
}
