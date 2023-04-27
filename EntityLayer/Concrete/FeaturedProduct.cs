using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class FeaturedProduct
    {
        public int FeaturedProductID { get; set; }

        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
