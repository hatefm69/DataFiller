using Quartz;
using System.Threading.Tasks;

namespace DataFiller.Job
{
    [DisallowConcurrentExecution]
    class GeneratorData : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            //add to rabbitMq

            return Task.CompletedTask;
        }
    }
}
