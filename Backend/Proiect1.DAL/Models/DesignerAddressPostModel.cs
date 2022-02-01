using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.DAL.Models
{
    public class DesignerAddressPostModel
    {
        public int Id { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public int DesignerId { get; set; }
    }
}
