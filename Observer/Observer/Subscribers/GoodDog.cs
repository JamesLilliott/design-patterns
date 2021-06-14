using System;
namespace Observer.Subscribers
{
    public class GoodDog: ISubscriber
    {
        EventManager eventManager;
        public bool fetchPost { get; set; }

        public GoodDog(EventManager eventManager)
        {
            this.eventManager = eventManager;
            this.eventManager.subscribe(this);
        }

        public void update(string doorEvent)
        {
            if (doorEvent == "POST"){
                this.getPost();
            }
        }

        public void getPost()
        {
            this.fetchPost = true;
        }
    }
}
