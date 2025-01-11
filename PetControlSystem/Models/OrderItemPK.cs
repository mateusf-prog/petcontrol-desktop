namespace PetControlSystem.Models
{
    public class OrderItemPK
    {
        public Order Order { get; set; }
        public Product Product { get; set; }

        public OrderItemPK() { }
    }
}