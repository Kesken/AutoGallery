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
    public class ColorRepository : RepositoryBase<Color, AppDbContext>, IColorRepository
    {
        public ColorRepository(AppDbContext context) : base(context)
        {
        }
    }
}
