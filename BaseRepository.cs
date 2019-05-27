using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParseThe_Parcel_App
{
    public class BaseRepository
    {
        public List<SelectListItem> PopulatePackageType()
        {
            List<SelectListItem> PackageTypes = new List<SelectListItem>();
            //text and value of the package can be pulled from the database as well
            PackageTypes.Add(new SelectListItem
            {
                Text = "Select",
                Value = "Select"
            });
            PackageTypes.Add(new SelectListItem
            {
                Text = "Small",
                Value = "Small"
            });
            PackageTypes.Add(new SelectListItem
            {
                Text = "Medium",
                Value = "Medium"
            });
            PackageTypes.Add(new SelectListItem
            {
                Text = "Large",
                Value = "Large"
            });
            return PackageTypes;
        }
    }
}