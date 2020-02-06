using System.ComponentModel.DataAnnotations;


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
