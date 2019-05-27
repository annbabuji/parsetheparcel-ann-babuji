using ParseThe_Parcel_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParseThe_Parcel_App.Controllers
{
    public class ParcelController : Controller
    {
        BaseRepository repo= new BaseRepository();
        // GET: /Parcel/

        public ActionResult ParcelView()
        {
            ParcelModel pmodel = new ParcelModel();
            pmodel.PackageType = repo.PopulatePackageType();
            return View(pmodel);
        }
        [HttpPost]
        public ActionResult ParcelView(ParcelModel model)
        {
            try
            {
                string selectedpackage = model.SelectedPackageType.ToString();
                int LengthEntered = model.Length;
                int BreadthEntered = model.Breadth;
                int HeightEntered = model.Height;

                if (LengthEntered <= 200 && BreadthEntered <= 300 && HeightEntered <= 150 && selectedpackage == "Small")
                {
                    TempData["CostCalculated"] = "Please pay $5.00 to check in the package.";
                    return RedirectToAction("ParcelCheckIn");
                }
                else if (LengthEntered <= 300 && BreadthEntered <= 400 && HeightEntered <= 200 && selectedpackage == "Medium")
                {
                    TempData["CostCalculated"] = "Please pay $7.50 to check in the package.";
                    return RedirectToAction("ParcelCheckIn");
                }
                else if (LengthEntered <= 400 && BreadthEntered <= 600 && HeightEntered <= 250 && selectedpackage == "Large")
                {
                   
                    TempData["CostCalculated"] = "Please pay $8.50 to check in the package.";
                    return RedirectToAction("ParcelCheckIn");
                }
                else
                {
                    return Json("Package Creation failed. Please try again", JsonRequestBehavior.AllowGet);
                    //return Json(new { Added = "N" }, JsonRequestBehavior.AllowGet);
                }

                //return View(model);
            }
            catch (Exception ex)
            {
                //TODO: log
                return Json(new { response = false, message = ex.Message });
            }
        }
        public ActionResult ParcelCheckIn()
        {
            ViewBag.Message = "Your Package CheckIn page.";

            return View();
        }
    }
}
