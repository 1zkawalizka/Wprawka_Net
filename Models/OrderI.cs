namespace EventTickets.Models;

public class OrderI
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public float price_per_ticket { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; } = null!;
    public int TicketId { get; set; }
    public Ticket Ticket { get; set; } = null!;
}