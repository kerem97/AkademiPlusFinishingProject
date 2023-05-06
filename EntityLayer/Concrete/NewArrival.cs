using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class NewArrival
    {
        public int NewArrivalID { get; set; }

        public string Name { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }

        public double OldPrice { get; set; }
        public double NewPrice { get; set; }

        public int Discount { get; set; }
        public string? Description { get; set; }
        public string? Description2 { get; set; }

        public DateTime AddDate { get; set; }
    }
}
