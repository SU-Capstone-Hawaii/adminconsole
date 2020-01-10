using System;
using System.Collections.Generic;

namespace adminconsole.Models
{
    public partial class SpecialQualities
    {
        public string LocationId { get; set; }
        public bool? RestrictedAccess { get; set; }
        public bool? DepositTaking { get; set; }
        public bool? LimitedTransactions { get; set; }
        public bool? HandicapAccess { get; set; }
        public bool? AcceptsCash { get; set; }
        public bool? Cashless { get; set; }
        public bool? SelfServiceOnly { get; set; }
        public bool? Surcharge { get; set; }
        public bool? OnMilitaryBase { get; set; }
        public bool? MilitaryIdrequired { get; set; }
        public string AdditionalDetail { get; set; }

        public virtual Locations Location { get; set; }
    }
}
