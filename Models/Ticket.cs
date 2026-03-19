namespace EventTickets.Models;

public class Ticket
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public float Price { get; set; }
    public int Seats { get; set; }
    public int FreeSeats { get; set; }
    public int EventId { get; set; }
    public Event Event { get; set; } = null!;
    public ICollection<OrderI> OrderIs { get; set; } = new List<OrderI>();
}