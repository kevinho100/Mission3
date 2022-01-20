using System;
using System.ComponentModel.DataAnnotations;

namespace Mission2.Models
{
    public class CalculatorModel
{

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100")]
        public byte assignments { get; set; }
 
        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100")]
        public byte group { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100")]
        public byte quizzes { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Please enter a number between 0 and 100")]
        public byte exams { get; set; }

        [Required]
        [Range(0,100,ErrorMessage ="Please enter a number between 0 and 100")]
        public byte intex { get; set; }
    }
}
