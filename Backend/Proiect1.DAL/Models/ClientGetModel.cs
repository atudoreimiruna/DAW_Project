using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.DAL.Models
{
    public class ClientGetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public static Expression<Func<Entities.Client, ClientGetModel>> Projection => client => new ClientGetModel()
        {
            Id = client.Id,
            Name = client.Name,
            Phone = client.Phone
        };
    }
}
