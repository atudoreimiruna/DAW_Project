namespace Proiect1.DAL.Models
{
    public class FactoryPostModel
    {
        public int Id { get; set; }
        public string FactoryName { get; set; }
        public int Contact { get; set; }
        public string FactoryAddress { get; set; }

        public int CollectionId { get; set; }

    }
}