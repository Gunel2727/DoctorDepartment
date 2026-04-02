using DoctorDepartment.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorDepartment.Controllers
{
    public class HomeController : Controller
    {
        private List<Department> departments = new List<Department>()
        {
            new Department
            {
                Id=1,
                Name="Cardiology",
            },
            new Department
            {
                Id=2,
                Name="Neurology",
            },
            new Department
            {
                Id=3,
                Name="Pediatrics",
            }

        };
    

    public IActionResult Index()
        {
            return View(departments);
        }
    }
}
