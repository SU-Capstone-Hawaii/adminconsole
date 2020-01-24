using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace adminconsole.Models
{
    public partial class Contacts
    {
        [Required]
        #nullable disable
        public string LocationId { get; set; }
        
        [DisplayName("Phone")]
        public string Phone { get; set; }
        
        [DisplayName("Fax")]
        public string Fax { get; set; }
        
        [DisplayName("URL")]
        public string WebAddress { get; set; }


        // Location object used for joins
        public virtual Locations Location { get; set; }
    }
}
