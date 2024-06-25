using MVC_NET1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_NET1.Controllers
{
    public class DashboardController : Controller
    {
        private static List<Inventory> inventories = new List<Inventory>
    {
        new Inventory { InventoryId = 1, Name = "Laptop" },
        new Inventory { InventoryId = 2, Name = "Projector" },
        new Inventory { InventoryId = 3, Name = "Whiteboard" },
        new Inventory { InventoryId = 4, Name = "Marker" },
        new Inventory { InventoryId = 5, Name = "Chair" }
    };

        private static List<Member> members = new List<Member>
    {
        new Member { MemberId = 1, Name = "Alice" },
        new Member { MemberId = 2, Name = "Bob" },
        new Member { MemberId = 3, Name = "Charlie" },
        new Member { MemberId = 4, Name = "David" },
        new Member { MemberId = 5, Name = "Eve" }
    };

        private static List<Assignment> assignments = new List<Assignment>
    {
        new Assignment { AssignmentId = 1, InventoryId = 1, MemberId = 1 },
        new Assignment { AssignmentId = 2, InventoryId = 2, MemberId = 2 },
        new Assignment { AssignmentId = 3, InventoryId = 3, MemberId = 3 },
        new Assignment { AssignmentId = 4, InventoryId = 4, MemberId = 1 }
    };

        public ActionResult Index()
        {
            var viewModel = new DashboardViewModel
            {
                Inventories = inventories,
                Members = members,
                Assignments = assignments
            };

            return View(viewModel);
        }
    }

    // Models/DashboardViewModel.cs
    public class DashboardViewModel
    {
        public List<Inventory> Inventories { get; set; }
        public List<Member> Members { get; set; }
        public List<Assignment> Assignments { get; set; }
    }
}