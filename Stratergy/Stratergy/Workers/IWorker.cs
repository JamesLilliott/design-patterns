using System;
namespace Stratergy.Workers
{
    public interface IWorker
    {
        public string Work(Resources.Resource resource);        
    }
}
