using System;
using System.ComponentModel.DataAnnotations;

namespace LuckySpin.Models
{
    public class Player
    {
        [Required(ErrorMessage="Please enter your first name")]
        public string FirstName { get; set; }

        //[Required(ErrorMessage = "Please select a number")]
        [Range(1,9, ErrorMessage = "Please select a number between 1-9")]
        public int Luck { get; set; }
    }
}