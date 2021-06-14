using System;
using Observer;
using Xunit;

namespace ObserverTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestObserver()
        {
            // SETUP
            EventManager eventManager = new EventManager();
            Door frontDoor = new Door(eventManager);

            Observer.Subscribers.BadDog dog1 = new Observer.Subscribers.BadDog(eventManager);
            Observer.Subscribers.Human human = new Observer.Subscribers.Human(eventManager);
            Observer.Subscribers.GoodDog goodDog = new Observer.Subscribers.GoodDog(eventManager);

            // ACT
            frontDoor.open();
            frontDoor.doorBell();
            frontDoor.post();

            // ASSET
            Assert.True(dog1.barkCount == 3);
            Assert.True(human.answeredDoor);
            Assert.True(goodDog.fetchPost);
        }
    }
}
