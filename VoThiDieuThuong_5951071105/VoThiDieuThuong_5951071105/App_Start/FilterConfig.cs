using System.Web;
using System.Web.Mvc;

namespace VoThiDieuThuong_5951071105
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
