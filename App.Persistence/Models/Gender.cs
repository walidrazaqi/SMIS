using System;
using System.Collections.Generic;

namespace App.Persistence.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Profile = new HashSet<Profile>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Profile> Profile { get; set; }
    }
}
