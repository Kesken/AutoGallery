using System;
using Core.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Rental : EntityBase
    {
        public int CarId { get; set; }
        public int CustomerId { get; set; }

        public DateTime RentDate { get; set; } = DateTime.Now;
        public DateTime? ReturnDate { get; set; }

        public virtual Car Car { get; set; }
        public virtual Customer Customer { get; set; }

        public Rental()
        {

        }
        public Rental(int carId, int customerId, DateTime rentDate, DateTime returnDate)
        {
            CarId = carId;
            CustomerId = customerId;
            RentDate = rentDate;
            ReturnDate = returnDate;
        }
    }
}
