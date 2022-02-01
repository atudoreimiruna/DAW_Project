using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.DAL.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<DesignerClient> DesignerClients { get; set; } // " M : M "
        public virtual ClientAddress ClientAddress { get; set; } // 1 : 1
    }
}