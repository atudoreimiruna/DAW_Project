using System;
using System.Linq.Expressions;

namespace Proiect1.DAL.Models
{
    public class DesignerAddressGetModel
    {
        public int Id { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }
        public int DesignerId { get; set; }

        public static Expression<Func<Entities.DesignerAddress, DesignerAddressGetModel>> Projection => address => new DesignerAddressGetModel()
        {
            Id = address.Id,
            City = address.City,
            Zipcode = address.Zipcode,
            DesignerId = address.DesignerId
        };
    }
}
