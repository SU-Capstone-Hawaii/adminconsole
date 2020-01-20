using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace adminconsole.Models
{
    public partial class Locations
    {
        [Required]
        public string LocationId { get; set; }

        [DisplayName("Institution Name")]
        public string InstitutionName { get; set; }

        [Required]
        [DisplayName("Type")]
        public string TypeName { get; set; }

        [Required]
        [DisplayName("Street")]
        public string Street { get; set; }

        [Required]
        [DisplayName("City")]
        public string City { get; set; }

        [Required]
        [DisplayName("State")]
        public string State { get; set; }

        [Required]
        [DisplayName("Zipcode")]
        public string Zipcode { get; set; }

        [Required]
        [DisplayName("Latitude")]
        public decimal Lat { get; set; } = 0.0M;

        [Required]
        [DisplayName("Longitude")]
        public decimal Long { get; set; } = 0.0M;

        [DisplayName("Retail Outlet")]
        public string RetailOutlet { get; set; }

        [DisplayName("Hours")]
        public string Hours { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual SpecialQualities SpecialQualities { get; set; }

        /*public enum StateEnum
        {
            [Description("None")]
            None,
            [Description("Alabama")]
            AL,
            [Description("Arkansas")]
            AK
            //Arizona AZ Arkansas AR California CA Colorado CO Connecticut CT Delaware DE District Of Columbia DC Florida FL Georgia GA Hawaii HI Idaho ID Illinois IL Indiana IN Iowa IA Kansas KS Kentucky KY Louisiana LA Maine ME Maryland MD Massachusetts MA Michigan MI Minnesota MN Mississippi MS Missouri MO Montana MT Nebraska NE Nevada NV New Hampshire NH New Jersey NJ New Mexico NM New York NY North Carolina NC North Dakota ND Ohio OH Oklahoma OK Oregon OR Pennsylvania PA Rhode Island R
        }*/
    }
}
