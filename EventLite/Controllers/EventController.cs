using EventLite.Data;
using EventLite.Models;
using Microsoft.AspNetCore.Mvc;

namespace EventLite.Controllers
{
    public class EventController : Controller
    {

        private readonly ApplicationDbContext _db;
        public EventController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Event> objEventList = _db.Events.ToList();
            return View(objEventList);
        }
    }
}
