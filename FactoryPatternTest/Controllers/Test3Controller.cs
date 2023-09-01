using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.Repositories.Interfaces;
using ClassLibrary1.Repositories.Implements;

namespace FactoryPatternTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test3Controller : Controller
    {
        [Route("Test3Main")]
        [HttpGet]
        public ActionResult Test3Main()
        {
            var s = "This is a string text";
            Employee objemp = new Employee();
            Student objstud = new Student();

            Iempstud obj = FactoryEmpStud.GetIempstud(1);
            obj.GetFirstName();
            obj.GetLastName();

            return Json(s + " '" + obj.GetFirstName() + "  , " + obj.GetLastName());
        }

        public static class FactoryEmpStud
        {
            private static Iempstud objem;
            public static Iempstud GetIempstud(int ID)
            {
                if (ID == 1)
                {
                    objem = new Student();
                }
                else if (ID == 2)
                {
                    objem = new Employee();
                }
                else if (ID == 3)
                {
                    objem = new Employee();
                }
                return objem;
            }
        }
    }
}
