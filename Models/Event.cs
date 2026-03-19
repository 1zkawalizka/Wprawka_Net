namespace EventTickets.Models;

public class Event
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Place { get; set; } = null!;
    public DateTime Date { get; set; }
    public EventCategory Category { get; set; }
    public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}