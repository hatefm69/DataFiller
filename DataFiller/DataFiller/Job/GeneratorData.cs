using DataFiller.Model;
using Quartz;
using System.Threading.Tasks;
using WebFramework.RabbitMQ;

namespace DataFiller.Job
{
    [DisallowConcurrentExecution]
    class GeneratorData : IJob
    {
        private IRabbitManager _rabbitManager;

        public GeneratorData(IRabbitManager rabbitManager)
        {
            _rabbitManager = rabbitManager;
        }
        public Task Execute(IJobExecutionContext context)
        {
            //add to rabbitMq
            var person = new Person("hatef", "mahdizadeh", 31);
            _rabbitManager.Publish<Person>(person, "direct_logs", "direct", "");

            return Task.CompletedTask;
        }
    }
}
