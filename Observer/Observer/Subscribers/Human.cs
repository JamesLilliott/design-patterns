using System;
namespace Observer.Subscribers
{
    public class Human: ISubscriber
    {
        EventManager eventManager;
        public Boolean answeredDoor { set; get; } 

        public Human(EventManager eventManager)
        {
            this.eventManager = eventManager;
            this.eventManager.subscribe(this);
        }

        public void update(string doorEvent)
        {
            if (doorEvent == "RING") {
                this.answerDoor();
            }
        }

        public void answerDoor()
        {
            this.answeredDoor = true;
        }
    }
}
