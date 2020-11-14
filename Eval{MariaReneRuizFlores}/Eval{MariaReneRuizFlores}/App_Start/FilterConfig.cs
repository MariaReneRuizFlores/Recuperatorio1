using System.Web;
using System.Web.Mvc;

namespace Eval_MariaReneRuizFlores_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
