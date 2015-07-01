using System.Web.Mvc;

namespace Ewk.SoundCloud.ApiLibrary.TestApp.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}