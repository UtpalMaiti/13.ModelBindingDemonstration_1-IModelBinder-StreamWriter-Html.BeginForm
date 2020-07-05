using ModelBindingDemonstration_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelBindingDemonstration_1.UtilityClasses
{
    public class AppointmentModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var req = controllerContext.HttpContext.Request;

            UserAppointment apt = new UserAppointment
            {
                Name=req.Form["Name"],
                EmailId=req.Form["EmailId"],
                ContactNo=req.Form["ContactNo"],
                AppointmentDate=req.Form["Day"]+"/"+req.Form["Month"]+"/"+req.Form["Year"]
            };

            return apt;
        }
    }
}