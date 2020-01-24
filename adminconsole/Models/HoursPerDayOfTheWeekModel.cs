using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace adminconsole.Models
{
    public class HoursPerDayOfTheWeek
    {
        [Required]
        #nullable disable
        public string LocationId { get; set; }

        [DisplayName("Mon Open")]
        public string HoursMonOpen { get; set; }

        [DisplayName("Mon Close")]
        public string HoursMonClose { get; set; }

        [DisplayName("Tues Open")]
        public string HoursTueOpen { get; set; }

        [DisplayName("Tues Close")]
        public string HoursTueClose { get; set; }

        [DisplayName("Wed Open")]
        public string HoursWedOpen { get; set; }

        [DisplayName("Wed Close")]
        public string HoursWedClose { get; set; }

        [DisplayName("Thur Open")]
        public string HoursThuOpen { get; set; }

        [DisplayName("Thur Close")]
        public string HoursThuClose { get; set; }

        [DisplayName("Fri Open")]
        public string HoursFriOpen { get; set; }

        [DisplayName("Fri Close")]
        public string HoursFriClose { get; set; }

        [DisplayName("Sat Open")]
        public string HoursSatOpen { get; set; }

        [DisplayName("Sat Close")]
        public string HoursSatClose { get; set; }

        [DisplayName("Sun Open")]
        public string HoursSunOpen { get; set; }

        [DisplayName("Sun Close")]
        public string HoursSunClose { get; set; }

        [DisplayName("Drive-Thru Mon Open")]
        public string HoursDtmonOpen { get; set; }

        [DisplayName("Drive-Thru Mon Close")]
        public string HoursDtmonClose { get; set; }

        [DisplayName("Drive-Thru Tues Open")]
        public string HoursDttueOpen { get; set; }

        [DisplayName("Drive-Thru Tues Close")]
        public string HoursDttueClose { get; set; }

        [DisplayName("Drive-Thru Wed Open")]
        public string HoursDtwedOpen { get; set; }

        [DisplayName("Drive-Thru Wed Close")]
        public string HoursDtwedClose { get; set; }

        [DisplayName("Drive-Thru Thur Open")]
        public string HoursDtthuOpen { get; set; }

        [DisplayName("Drive-Thru Thur Close")]
        public string HoursDtthuClose { get; set; }

        [DisplayName("Drive-Thru Fri Open")]
        public string HoursDtfriOpen { get; set; }

        [DisplayName("Drive-Thru Fri Close")]
        public string HoursDtfriClose { get; set; }

        [DisplayName("Drive-Thru Sat Open")]
        public string HoursDtsatOpen { get; set; }

        [DisplayName("Drive-Thru Sat Close")]
        public string HoursDtsatClose { get; set; }

        [DisplayName("Drive-Thru Sun Open")]
        public string HoursDtsunOpen { get; set; }

        [DisplayName("Drive-Thru Sun Close")]
        public string HoursDtsunClose { get; set; }

        // Location Object. Used for joins
        public virtual Locations Location { get; set; }
    }
}
