using Core.Repositories.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
    }

}
