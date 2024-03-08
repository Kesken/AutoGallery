using System;
using Core.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Customer : EntityBase
    {
        public int UserId { get; set; }

        public string CompanyName { get; set; }

        public virtual User User { get; set; }

        public Customer()
        {

        }
        public Customer(int userId, string companyName)
        {
            UserId = userId;
            CompanyName = companyName;
        }
    }
}
