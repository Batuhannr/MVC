using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [StringLength(50)]
        public string CatgoryName { get; set; }

        [StringLength(200)]
        public string CatgoryDescription { get; set; }
        public bool CatgoryStatus { get; set; }
        public ICollection<Heading> Headings  { get; set; }


    }
}
