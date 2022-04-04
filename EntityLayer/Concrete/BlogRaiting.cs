using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class BlogRaiting
    {
        public int BlogRaitingId { get; set; }

        public int BlogId { get; set; }
        public int BlogTotalScore { get; set; }
        public int BlogRaitingCount{ get; set; }

    }
}
