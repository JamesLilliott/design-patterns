using Stratergy.Resources;
using Stratergy.Workers;
using System;
using System.Collections.Generic;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void WorkingWood()
        {
            Resource wood = Resource.Wood;
            Dictionary<string, IWorker> workers = this.GetWorkers();

            Assert.Equal("false", workers["baker"].Work(wood));
            Assert.Equal("false", workers["sculpter"].Work(wood));
            Assert.Equal("chair", workers["carpenter"].Work(wood));
        }

        [Fact]
        public void WorkingStone()
        {
            Resource stone = Resource.Stone;
            Dictionary<string, IWorker> workers = this.GetWorkers();

            Assert.Equal("false", workers["baker"].Work(stone));
            Assert.Equal("statue", workers["sculpter"].Work(stone));
            Assert.Equal("false", workers["carpenter"].Work(stone));
        }

        [Fact]
        public void WorkingFlour()
        {
            Resource flour = Resource.Flour;
            Dictionary<string, IWorker> workers = this.GetWorkers();

            Assert.Equal("bread", workers["baker"].Work(flour));
            Assert.Equal("false", workers["sculpter"].Work(flour));
            Assert.Equal("false", workers["carpenter"].Work(flour));
        }

        private Dictionary<string, IWorker> GetWorkers()
        {
            return new Dictionary<string, IWorker> {
                { "baker", new Baker()},
                { "sculpter", new Sculpter()},
                { "carpenter", new Carpenter()}
            };
        }
    }
}
