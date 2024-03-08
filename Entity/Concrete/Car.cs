using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Car : EntityBase
    {

        public int BrandId { get; set; }
        public decimal DailyPrice { get; set; }
        public int ModelYear { get; set; }
        public string Description { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual ICollection<CarColor>? CarColors { get; set; }

        public Car()
        {
        }

        public Car(int brandId, decimal dailyPrice, int modelYear, string description)
        {
            BrandId = brandId;
            DailyPrice = dailyPrice;
            ModelYear = modelYear;
            Description = description;
        }
    }
}
