namespace PetControlSystem.Models
{
    public class OrderItem
    {
        public OrderItemPK Id = new();
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public OrderItem() { }

        public OrderItem(Order order, Product product, int quantity, decimal price)
        {
            Id.Order = order;
            Id.Product = product;
            Quantity = quantity;
            Price = price;
        }

        public Product GetProduct()
        {
            return Id.Product;
        }

        public void SetProduct(Product product)
        {
            Id.Product = product;
        }

        public Order GetOrder()
        {
            return Id.Order;
        }

        public void SetOrder(Order order)
        {
            Id.Order = order;
        }
    }
}