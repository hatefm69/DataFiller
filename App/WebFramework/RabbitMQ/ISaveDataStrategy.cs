using Entities.Models;
using System.Threading.Tasks;

namespace WebFramework.RabbitMQ
{
    public interface ISaveDataStrategy
    {
        Task<Person> Execute(Person person);
    }
}
