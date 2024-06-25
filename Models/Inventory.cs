using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_NET1.Models
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string Name { get; set; }
    }

    // Models/Member.cs
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
    }

    // Models/Assignment.cs
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public int InventoryId { get; set; }
        public int MemberId { get; set; }
        public Inventory Inventory { get; set; }
        public Member Member { get; set; }
    }
}