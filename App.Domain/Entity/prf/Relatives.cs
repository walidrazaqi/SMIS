using App.Domain.Entity.look;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Entity.prf
{
  public partial class Relatives
    {
        public int Id { get; set; }
        public int ProfileId { get; set; }
        public int? RelativeTypeId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public int? JobLocationId { get; set; }
        public string GurrenterName { get; set; }
        public string GurrenterFatherName { get; set; }
        public int? ProfessionTypeId { get; set; }
        public string Phone { get; set; }
        public string RelativeName { get; set; }

        public virtual Location JobLocation { get; set; }
        public virtual Profession ProfessionType { get; set; }
        public virtual Profile Profile { get; set; }
        public virtual RelativesType RelativeType { get; set; }

    }
}
