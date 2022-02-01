using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.DAL.Models
{
    public class CollectionGetModel
    {
        public int Id { get; set; }
        public string CollectionName { get; set; }
        public int NumberOfItems { get; set; }
        public DateTime ReleaseDate { get; set; }

        public static Expression<Func<Entities.Collection, CollectionGetModel>> Projection => collection=> new CollectionGetModel()
        {
            Id = collection.Id,
            CollectionName = collection.CollectionName,
            NumberOfItems = collection.NumberOfItems,
            ReleaseDate = collection.ReleaseDate
        };
    }
}