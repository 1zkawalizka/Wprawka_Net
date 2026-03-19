using EventTickets.Data;
using EventTickets.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventTickets.Controllers;

public class HomeController : Controller
{
    private readonly EventData _context;

    public HomeController(EventData context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var events = _context.Events.ToList();
        return View(events);
    }
}