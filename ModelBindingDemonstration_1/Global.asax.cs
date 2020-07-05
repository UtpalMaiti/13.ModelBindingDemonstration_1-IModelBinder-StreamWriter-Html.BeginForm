﻿using ModelBindingDemonstration_1.Models;
using ModelBindingDemonstration_1.UtilityClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ModelBindingDemonstration_1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ModelBinders.Binders.Add(typeof(UserAppointment), new AppointmentModelBinder());
        }
    }
}
