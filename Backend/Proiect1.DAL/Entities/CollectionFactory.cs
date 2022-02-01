using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.DAL.Entities
{
    public class CollectionFactory
    {
        public int Id { get; set; }
        public string FactoryName { get; set; }
        public int Contact { get; set; }
        public string FactoryAddress { get; set; }
        public int CollectionId { get; set; }
        public virtual Collection Collection { get; set; }  // 1:m
    }
}
