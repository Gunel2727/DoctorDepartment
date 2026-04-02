namespace DoctorDepartment.Models
{
    public class Doctor
    {

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
