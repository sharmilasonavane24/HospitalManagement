using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalManagment.Models
{
    public class ClinicalExamination
    {
        [Required]
        [Display(Name = "Blood Pressure: ")]
        public string BP { get; set; }
         
        [Required]
        [Display(Name = "Pulse: ")]
        public int Pulse { get; set; }

        [Display(Name = "Weight: (Kgs)")]
        public decimal CurrentWeight { get; set; }

        [Display(Name = "Provisional Diagnosis: ")]
        public string positiveFidings { get; set; }

        [Display(Name = "Rs/CVS: ")]
        public string RsNCVS { get; set; }

        [Display(Name = "P/A: ")]
        public string PA { get; set; }

        [Display(Name = "P/S: ")]
        public string PS { get; set; }

        [Display(Name = "P/V: ")]
        public string PV { get; set; }

        [Display(Name = "CNS: ")]
        public string CNS { get; set; }

    }
}