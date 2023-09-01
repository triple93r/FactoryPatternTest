using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary1.Repositories.Interfaces;
using ClassLibrary1.Repositories.Implements;


namespace FactoryPatternTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : Controller
    {
        public TestController()
        {
            //constructor codes
        } //ctor

        [Route("TestMain")]
        [HttpGet]
        public ActionResult TestMain()
        {
            var s = "This is a string text";
            Employee objemp = new Employee();
            Student objstud = new Student();

            Iempstud obj = FactoryEmpStud.GetIempstud(3);
            obj.GetFirstName();
            obj.GetLastName();

            return Json(s + " '" + obj.GetFirstName() + "  , " + obj.GetLastName());

            //IcreateObj obj = new EmployeeFactory();
            //Iempstud objiempstud = obj.Getobj();
            //return Json(s + " '" + objiempstud.GetFirstName() + "  , " + objiempstud.GetLastName());
        }

    }


    //public interface IcreateObj
    //{
    //    Iempstud Getobj();
    //}

    //[Route("api/[controller]")]
    //[ApiController]
    //public class StudentFactory : IcreateObj
    //{
    //    [Route("Getobj")]
    //    [HttpGet]
    //    public Iempstud Getobj()
    //    {
    //        return new Student();
    //    }
    //}

    //[Route("api/[controller]")]
    //[ApiController]
    //public class EmployeeFactory : IcreateObj
    //{
    //    [Route("Getobj")]
    //    [HttpGet]
    //    public Iempstud Getobj()
    //    {
    //        return new Employee();
    //    }
    //}

    //[Route("api/[controller]")]
    //[ApiController]
    //public class TeacherFactory : IcreateObj
    //{
    //    [Route("Getobj")]
    //    [HttpGet]
    //    public Iempstud Getobj()
    //    {
    //        return new Teacher();
    //    }
    //}


    public static class FactoryEmpStud
    {
        private static Iempstud? objem;
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

    #region -- Takeoff
    //public interface Iempstud
    //{
    //    string GetFirstName();
    //    string GetLastName();
    //}

    //[Route("api/[controller]")]
    //[ApiController]
    //public class Student: Controller, Iempstud
    //{
    //    [Route("GetFirstName")]
    //    [HttpGet]
    //    public string GetFirstName()
    //    {
    //        return "Student FirstName";
    //    }

    //    [Route("GetLastName")]
    //    [HttpGet]
    //    public string GetLastName()
    //    {
    //        return "Student LastName";
    //    }

    //}

    //[Route("api/[controller]")]
    //[ApiController]
    //public class Employee : Controller, Iempstud
    //{
    //    [Route("GetFirstName")]
    //    [HttpGet]
    //    public string GetFirstName()
    //    {
    //        return "Empl FirstName";
    //    }
    //    [Route("GetLastName")]
    //    [HttpGet]
    //    public string GetLastName()
    //    {
    //        return "Empl LastName";
    //    }
    //}

    //[Route("api/[controller]")]
    //[ApiController]
    //public class Teacher : Controller, Iempstud
    //{
    //    [Route("GetFirstName")]
    //    [HttpGet]
    //    public string GetFirstName()
    //    {
    //        return "Teacher FirstName";
    //    }
    //    [Route("GetLastName")]
    //    [HttpGet]
    //    public string GetLastName()
    //    {
    //        return "Teacher LastName";
    //    }
    //}

    #endregion
}
