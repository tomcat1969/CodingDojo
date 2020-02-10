using System;
using System.ComponentModel.DataAnnotations;

namespace ValidatingFormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [NoZNames]
        public string Firstname { get; set; }

        [Required]
        [MinLength(4)]
        public string Lastname { get; set; }
        
        [Required]
        [Range(0,150)]
        public int Age {get;set;}

        [Required]
        [FutureDate]
        public DateTime Birthday{get;set;}
 
        [Required]
        [EmailAddress]
        public string Email { get; set; }
 
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }





    public class NoZNamesAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (((string)value).ToLower()[0] == 'z')
                return new ValidationResult("No names that start with Z allowed!");
            return ValidationResult.Success;
        }
    }


    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // You first may want to unbox "value" here and cast to to a DateTime variable!
            DateTime convertedValue = Convert.ToDateTime(value);
            DateTime now = DateTime.Now;

            Console.WriteLine("****************"+ convertedValue);
             Console.WriteLine("****************"+ now);

            if(convertedValue >= now)
                return new ValidationResult("birth day should be in the past!");
                 
            return ValidationResult.Success;


        }
    }
}