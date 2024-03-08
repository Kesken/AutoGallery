using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Color : EntityBase
    {
        public string Name { get; set; }

        public virtual ICollection<CarColor>? CarColors { get; set; }
        public Color()
        {

        }
        public Color(string name)
        {
            Name = name;
        }
    }
}
