﻿using System.ComponentModel.DataAnnotations;


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


    public static class BooleanEnumExtensions
    {
        public static string GetDisplayName(this BooleanEnum booleanEnum)
        {
            switch (booleanEnum)
            {
                case (BooleanEnum.N):
                    return "No";

                case (BooleanEnum.Y):
                    return "Yes";

                default:
                    return "Not Set";
            }
        }
    }
}