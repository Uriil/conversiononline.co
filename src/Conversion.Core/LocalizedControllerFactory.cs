using System;
using System.Globalization;
using System.Threading;
using System.Web.Mvc;
using System.Web.Routing;

namespace Conversion.Core
{
    public class LocalizedControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            string uiLanguage;

            if (requestContext.RouteData.Values["language"] == null)
                uiLanguage = "en";            
            else
                uiLanguage = requestContext.RouteData.Values["language"].ToString();

            CultureInfo culture = CultureInfo.CreateSpecificCulture(uiLanguage);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            return base.GetControllerInstance(requestContext, controllerType);
        }

    }
}
