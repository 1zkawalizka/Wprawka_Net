namespace EventTickets.Models;

public class Order
{
    public int Id { get; set; }
    public float Price { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
    public ICollection<OrderI> OrderIs { get; set; } = new List<OrderI>();
}