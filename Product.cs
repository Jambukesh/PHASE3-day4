using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleProjects
{
    internal class Product
    {
        public string Pname { get; set; }
        public int Pprice { get; set; }
        public string? Pbrand { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
