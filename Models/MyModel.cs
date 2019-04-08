using System;
using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class MyModel
    {
       
    }
    public class Survey
    {
        [Required(ErrorMessage = "Name is required")]
        [MinLength(2)]
        [Display(Name = "Your Name:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Location is required")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Language is required")]
        public string Language { get; set; }
        [MaxLength(20,ErrorMessage = "Commets can not long then 20 characters")]
        public string Comments { get; set; }
    }
}