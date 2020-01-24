using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace adminconsole.Models
{
    public partial class SpecialQualities
    {
        [Required]
        #nullable disable
        public string LocationId { get; set; }

        [DisplayName("Restricted Access")]
        public string RestrictedAccess { get; set; }

        [DisplayName("Accepts Deposit")]
        public string AcceptDeposit { get; set; }

        [DisplayName("Accepts Cash")]
        public string AcceptCash { get; set; }
        
        [DisplayName("Envelope Required")]
        public string EnvelopeRequired { get; set; }
        
        [DisplayName("On Military Base")]
        public string OnMilitaryBase { get; set; }
        
        [DisplayName("On Premise")]
        public string OnPremise { get; set; }
        
        [DisplayName("Surcharge")]
        public string Surcharge { get; set; }
        
        [DisplayName("Access")]        
        public string Access { get; set; }
        
        [DisplayName("Access Notes")]
        public string AccessNotes { get; set; }
        
        [DisplayName("Installation Type")]
        public string InstallationType { get; set; }
        
        [DisplayName("Handicap Access")]
        public string HandicapAccess { get; set; }
        
        [DisplayName("Cashless")]
        public string Cashless { get; set; }
        
        [DisplayName("Drive Thru Only")]
        public string DriveThruOnly { get; set; }
        
        [DisplayName("Limited Transactions")]
        public string LimitedTransactions { get; set; }
        
        [DisplayName("Military ID Required")]
        public string MilitaryIdRequired { get; set; }
        
        [DisplayName("Self Service Device")]
        public string SelfServiceDevice { get; set; }
        
        [DisplayName("Self Service Only")]
        public string SelfServiceOnly { get; set; }
        
        // Location Object. Used for joins.
        public virtual Locations Location { get; set; }
    }
}
