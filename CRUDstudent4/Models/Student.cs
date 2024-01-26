namespace CRUDstudent4.Models
{
    public enum AttendanceStatus
    {
        Present,
        Absent
    }

    public class Student
    {
        public int Id { get; set; }
        public string Group { get; set; }
        public string RollNumber { get; set; }
        public string FullName { get; set; }
        public AttendanceStatus Status { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }
    }
}
