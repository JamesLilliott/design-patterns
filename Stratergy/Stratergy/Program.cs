using Stratergy.Resources;
using Stratergy.Workers;
using System;

namespace Stratergy
{
    class Program
    {
        static void Main(string[] args)
        {
            Resource stone = Resource.Stone;
            Resource wood = Resource.Wood;
            Resource flour = Resource.Flour;

            IWorker baker = new Baker();
            IWorker sculpter = new Sculpter();
            IWorker carpenter = new Carpenter();

            Program.work(baker, flour);
            Program.work(sculpter, stone);
            Program.work(carpenter, wood);
        }

        public static string work(IWorker worker, Resource resource)
        {
            return worker.Work(resource);
        }
    }
}
