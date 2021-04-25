﻿using Common;
using Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class UnitOfWorkDapper : IUnitOfWorkDapper
    {
        public UnitOfWorkDapper(IPersonRepository personRepository)
        {
            People = personRepository;
        }
        public IPersonRepository People { get; }
    }
}
