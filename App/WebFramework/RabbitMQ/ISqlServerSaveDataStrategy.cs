using Entities.Models;
using System.Threading.Tasks;

namespace WebFramework.RabbitMQ
{
    public interface ISqlServerSaveDataStrategy: ISaveDataStrategy
    {
        Task<Person> Execute(Person person);
    }
}