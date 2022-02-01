using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.DAL.Entities
{
    public class Designer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public virtual DesignerAddress DesignerAddress { get; set; } // 1:1
        public virtual ICollection<DesignerAward> DesignerAwards { get; set; } // 1 : M
        public virtual ICollection<DesignerClient> DesignerClients { get; set; } // " M : M "
        public virtual ICollection<DesignerCollection> DesignerCollections { get; set; } // " M : M "
    }
}
