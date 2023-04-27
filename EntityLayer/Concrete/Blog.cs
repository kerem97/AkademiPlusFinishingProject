using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int BLogID { get; set; }
        public string BlogName { get; set; }
        public DateTime AddDate { get; set; }
        public string Title { get; set; }
    }
}
