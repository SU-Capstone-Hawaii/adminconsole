using System;
using System.Collections.Generic;

namespace adminconsole.Models
{
    public partial class Contact
    {
        public string LocationId { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Terminal { get; set; }

        public virtual Locations Location { get; set; }
    }
}
