using System;

namespace Proiect1.DAL.Models
{
    public class AwardPostModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contest { get; set; }
        public DateTime Data { get; set; }

        public  int DesignerId { get; set; } // 1 : M
    }
}
