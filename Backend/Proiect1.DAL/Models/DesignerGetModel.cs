using System;
using System.Linq.Expressions;

namespace Proiect1.DAL.Models
{
    public class DesignerGetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public static Expression<Func<Entities.Designer, DesignerGetModel>> Projection => designer=> new DesignerGetModel()
        {
            Id = designer.Id,
            Name = designer.Name,
            Age = designer.Age,
            Gender = designer.Gender
        };
    }
}
