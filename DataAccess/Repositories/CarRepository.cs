using Business.Services.Repositories;
using Core.Repositories.Concrete;
using DataAccess.Contexts;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class CarRepository : RepositoryBase<Car, AppDbContext>, ICarRepository
    {
        public CarRepository(AppDbContext context) : base(context)
        {
        }
    }
}
