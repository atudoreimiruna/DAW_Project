using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.DAL.Entities
{
    public class DesignerAddress
    {
        public int Id { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public int DesignerId { get; set; }
        public virtual Designer Designer{ get; set; } // 1 : 1
    }
}
