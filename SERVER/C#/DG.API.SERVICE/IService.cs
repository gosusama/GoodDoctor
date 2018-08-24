using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DG.API.SERVICE
{
    public interface IService
    {
        IUnitOfWork UnitOfWork { get; }
    }
}