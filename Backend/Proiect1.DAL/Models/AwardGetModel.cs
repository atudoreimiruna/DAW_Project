using System;
using System.Linq.Expressions;

namespace Proiect1.DAL.Models
{
    public class AwardGetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contest { get; set; }
        public DateTime Data { get; set; }

        public int DesignerId { get; set; } // 1 : M

        public static Expression<Func<Entities.DesignerAward, AwardGetModel>> Projection => award => new AwardGetModel()
        {
            Id = award.Id,
            Name = award.Name,
            Contest = award.Contest,
            Data = award.Data
        };
    }
}
