using System;
using Stratergy.Resources;

namespace Stratergy.Workers
{
    public class Carpenter : IWorker
    {
        public string Work(Resource resource)
        {
            return resource switch
            {
                Resource.Flour => "false",
                Resource.Stone => "false",
                Resource.Wood => "chair",
                _ => "false",
            };
    }
    }
}
