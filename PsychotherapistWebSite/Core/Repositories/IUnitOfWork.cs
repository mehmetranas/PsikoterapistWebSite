using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychotherapistWebSite.Core.Repositories
{
    public interface IUnitOfWork
    {
         IServiceRepository Service { get; }

        void Complete();    
    }
}
