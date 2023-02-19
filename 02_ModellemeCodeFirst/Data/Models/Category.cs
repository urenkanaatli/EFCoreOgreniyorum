using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ModellemeCodeFirst.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string? Icon { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
