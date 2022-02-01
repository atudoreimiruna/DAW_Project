using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.DAL.Models
{
    public class DesignerPostModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public int AddressId { get; set; }
        public int ClientsId { get; set; }
        public int AwardId { get; set; }
        public int CollectionId { get; set; }
        public string CollectionName { get; set; }
    }
}
