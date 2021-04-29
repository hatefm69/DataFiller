using Entities.Models;
using System.Threading.Tasks;

namespace WebFramework.RabbitMQ
{
    public interface IRedisSaveDataStrategy: ISaveDataStrategy
    {
        Task<Person> Execute(Person person);
    }
}