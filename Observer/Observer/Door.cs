using System;
namespace Observer
{
    public class Door
    {
        EventManager eventManager;

        public Door(EventManager eventManager)
        {
            this.eventManager = eventManager;
        }

        public void open()
        {
            this.eventManager.notify("OPEN");
        }

        public void doorBell()
        {
            this.eventManager.notify("RING");
        }

        public void post()
        {
            this.eventManager.notify("POST");
        }
    }
}
