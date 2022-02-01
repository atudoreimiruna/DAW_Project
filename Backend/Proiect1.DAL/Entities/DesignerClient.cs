using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.DAL.Entities
{
    public class DesignerClient
    {
        public int Id { get; set; }
        public int DesignerId { get; set; }
        public int ClientId { get; set; }

        public virtual Designer Designer { get; set; }
        public virtual Client Client { get; set; }
    }
}
