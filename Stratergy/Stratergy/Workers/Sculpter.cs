using System;
using Stratergy.Resources;

namespace Stratergy.Workers
{
    public class Sculpter : IWorker
    {
        public string Work(Resource resource)
        {
            return resource switch
            {
                Resource.Flour => "false",
                Resource.Stone => "statue",
                Resource.Wood => "false",
                _ => "false",
            };
        }
    }
}
