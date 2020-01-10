using System;
using System.Collections.Generic;

namespace adminconsole.Models
{
    public partial class ContactsModel
    {
        public string LocationId { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Terminal { get; set; }

        public virtual LocationsModel Location { get; set; }
    }
}
