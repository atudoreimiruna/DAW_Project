namespace Proiect1.DAL.Entities
{
    public class DesignerCollection
    {
        public int Id { get; set; }

        public int DesignerId { get; set; }
        public int CollectionId { get; set; }

        public virtual Designer Designer { get; set; }
        public virtual Collection Collection { get; set; }   // m:m
    }
}