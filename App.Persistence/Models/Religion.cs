using System;
using System.Collections.Generic;

namespace App.Persistence.Models
{
    public partial class Religion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }
}
