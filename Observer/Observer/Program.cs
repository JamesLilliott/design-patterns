using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();
            Door frontDoor = new Door(eventManager);

            Subscribers.BadDog dog1 = new Subscribers.BadDog(eventManager);
            Subscribers.Human human = new Subscribers.Human(eventManager);
            Subscribers.GoodDog goodDog = new Subscribers.GoodDog(eventManager);

            Console.WriteLine("Opening Door");
            frontDoor.open();
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("-------");
            Console.WriteLine("Doorbell ring");
            frontDoor.doorBell();
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("-------");
            Console.WriteLine("Post Delivererd");
            frontDoor.post();
            System.Threading.Thread.Sleep(1000);

        }
    }
}
