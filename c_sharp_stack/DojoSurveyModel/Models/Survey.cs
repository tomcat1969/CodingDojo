using System;
using System.ComponentModel.DataAnnotations;
namespace DojoSurveyModel
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        public string Name{get;set;}

        [Required]
        public string Location{get;set;}

        [Required]
        public string Language{get;set;}

        [MinLength(20)]
        public string Comment{get;set;}
    }
}    