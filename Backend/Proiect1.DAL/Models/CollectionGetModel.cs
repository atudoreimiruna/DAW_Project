using System;
using System.Linq.Expressions;

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