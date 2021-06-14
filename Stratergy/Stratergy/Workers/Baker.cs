using System;
using Stratergy.Resources;

namespace Stratergy.Workers
{
    public class Baker: IWorker
    {
        public string Work(Resource resource)
        {
            return resource switch
            {
                Resource.Flour => "bread",
                Resource.Stone => "false",
                Resource.Wood => "false",
                _ => "false",
            };
        }
    }
}
