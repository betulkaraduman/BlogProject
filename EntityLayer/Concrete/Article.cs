using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        public string ArticleName { get; set; }
    }
}
