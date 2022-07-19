using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentMeetingPlanner.Models
{
    public class Plan
    {
        public int ID { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Conducting { get; set; }
        [Display(Name = "Opening Prayer")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        public string OP { get; set; }


        [Required]
        [Display(Name = "Closing Prayer")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string CP { get; set; }

        [Required]
        [Display(Name = "Opening Hymn")]
        public int Opening { get; set; }

        [Required]
        [Display(Name = "Sacrament Hymn")]
        public int Intermediate { get; set; }

        [Required]
        [Display(Name = "Closing Hymn")]
        public int Closing { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Speaker")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string SpeakerOne { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Speaker Subject")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string SpeakerOneSubject { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Speaker")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string SpeakerTwo { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Speaker Subject")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string SpeakerTwoSubject { get; set; }


        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Speaker")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string SpeakerThree { get; set; }

        
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Speaker Subject")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string SpeakerThreeSubject { get; set; }
        
        
 
 
        
        
        
        
        

        
         
        
        
        
        
        
        
    }
}
