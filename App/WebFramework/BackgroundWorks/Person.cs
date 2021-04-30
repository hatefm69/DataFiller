using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.AutoMapepr;

namespace Infrastructure.BackgroundWorks
{
    public class Person : BaseDto<Person, PersonEntity>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
