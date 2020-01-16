using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace adminconsole.Models
{
    public enum BooleanEnum
    {
        [Display(Name = "None")]
        NULL,
        [Display(Name = "No")]
        N = 0,
        [Display(Name = "Yes")]
        Y = 1
    }
}
