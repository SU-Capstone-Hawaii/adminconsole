using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace adminconsole.MockData
{
    public class SpecialQualitiesTableMock
    {
        [Required]
        public string LocationId { get; set; }

        [Required]
        [DisplayName("Restricted Access")]
        public bool? RestrictedAccess { get; set; }

        [DisplayName("Deposit Taking")]
        public bool? DepositTaking { get; set; }

        [DisplayName("Limited Transactions")]
        public bool? LimitedTransactions { get; set; }

        [DisplayName("Handicap Access")]
        public bool? HandicapAccess { get; set; }

        [DisplayName("Accepts Cash")]
        public bool? AcceptsCash { get; set; }

        [DisplayName("Cashless")]
        public bool? Cashless { get; set; }

        [DisplayName("Self Service Only")]
        public bool? SelfServiceOnly { get; set; }

        [DisplayName("Surcharge")]
        public bool? Surcharge { get; set; }

        [DisplayName("On Military Base")]
        public bool? OnMilitaryBase { get; set; }

        [DisplayName("Military ID Required")]
        public bool? MilitaryIdRequired { get; set; }

        [DisplayName("Additional Detail")]
        [StringLength(100)]
        public string AdditionalDetail { get; set; }

        public virtual LocationsTableMock Location { get; set; }
    }
}
