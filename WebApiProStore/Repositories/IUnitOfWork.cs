using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProStore.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
