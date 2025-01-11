namespace PetControlSystem.Models
{
    public class OrderItem
    {
        public OrderItemPK Id { get; set; } = new();
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }

        public OrderItem() { }

        public OrderItem(Order order, Product product, int quantity, decimal price)
            : this(order, product)
        {
            Quantity = quantity;
            Price = price;
        }

        public OrderItem(Order order, Product product)
        {
            Id.Order = order;
            Id.Product = product;
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