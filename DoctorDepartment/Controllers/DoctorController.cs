using DoctorDepartment.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorDepartment.Controllers
{
    public class DoctorController : Controller
    {
        private List<Doctor> doctors = new List<Doctor>()
        {
            new Doctor
            {
                Id=1,
                FullName="Dr. Smith",
                Specialty="Cardiologist",
                DepartmentId=1
            },
            new Doctor
            {
                Id=2,
                FullName="Dr. Johnson",
                Specialty="Neurologist",
                DepartmentId=2
            },
            new Doctor
            {
                Id=3,
                FullName="Dr. Williams",
                Specialty="Pediatrician",
                DepartmentId=3
            }
        };
        public IActionResult Index(int departmentId)
        {
            if(doctors.Any(d => d.DepartmentId == departmentId))
            {
                var doctorsInDepartment = doctors.FindAll(d => d.DepartmentId == departmentId).ToList();
                return View(doctorsInDepartment);
            }
            return View(new List<Doctor>());
        }
    }
}
