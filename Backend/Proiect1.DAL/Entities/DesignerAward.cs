using System;

namespace Proiect1.DAL.Entities
{
    public class DesignerAward
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contest { get; set; }
        public DateTime Data { get; set; }
        public int DesignerId { get; set; }

        public virtual Designer Designer { get; set; } // 1 : M
    }
}
