using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParseThe_Parcel_App.Models
{
    public class ParcelModel
    {
        [Display(Name = "Package Type")]
        [Required(ErrorMessage = "Please Select Package Type")]
        public string SelectedPackageType { get; set; }
        public IEnumerable<SelectListItem> PackageType { get; set; }
       
        [Required(ErrorMessage = "Please Enter Package Length")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please Enter Only Numbers")]
        public int Length { get; set; }

        [Required(ErrorMessage = "Please Enter Package Breadth")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please Enter Only Numbers")]
        public int Breadth { get; set; }

        [Required(ErrorMessage = "Please Enter Package Height")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please Enter Only Numbers")]
        public int Height { get; set; }

        public int CostCalculated { get; set; }
    }
}