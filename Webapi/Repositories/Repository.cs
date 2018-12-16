using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Webapi.Domains;
using Webapi.Entities;

namespace Webapi.Repositories
{
    public interface IRepository  
    { 
        Task<IEnumerable<IEntity>> GetAllAsync( CancellationToken cancellationToken);
    }
}