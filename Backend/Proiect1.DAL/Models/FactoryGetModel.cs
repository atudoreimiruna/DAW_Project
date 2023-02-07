using System;
using System.Linq.Expressions;

namespace Proiect1.DAL.Models
{
    public class FactoryGetModel
    {
        public int Id { get; set; }
        public string FactoryName { get; set; }
        public int Contact { get; set; }
        public string FactoryAddress { get; set; }
        public int CollectionId { get; set; }

        public static Expression<Func<Entities.CollectionFactory, FactoryGetModel>> Projection => factory=> new FactoryGetModel()
        {
            Id = factory.Id,
            FactoryName = factory.FactoryName,
            Contact = factory.Contact,
            FactoryAddress = factory.FactoryAddress,
            CollectionId = factory.CollectionId
        };
    }
}