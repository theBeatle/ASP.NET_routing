using System.Web.Mvc;

namespace WebApplication1.Areas.Dima
{
    public class DimaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Dima";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Dima_default",
                "Dima/{controller}/{action}/{id}",
                new { controller ="Home",action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}