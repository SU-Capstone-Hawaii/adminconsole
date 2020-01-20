using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace adminconsole.MockData
{
    public class ContactTableMock
    {
        [Required]
        public string LocationId { get; set; }

        [DisplayName("Phone")]
        public string Phone { get; set; }

        [DisplayName("Fax")]
        public string Fax { get; set; }

        [DisplayName("Terminal")]
        public string Terminal { get; set; }

        public virtual LocationsTableMock Location { get; set; }
    }
}
