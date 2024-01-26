namespace CRUDstudent4.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Group { get; set; }
        public string RollNumber { get; set; }
        public string Fullname { get; set; }
        public bool Absent { get; set; }
        public bool Present { get; set; }
        public string Comment { get; set; }
        public string Image { get; set; }

        // Phương thức để cập nhật trạng thái điểm danh
        public void UpdateAttendance(bool isPresent)
        {
            // Reset cả hai trạng thái về false trước khi cập nhật
            Absent = false;
            Present = false;

            // Cập nhật trạng thái mới
            if (isPresent)
            {
                Present = true;
            }
            else
            {
                Absent = true;
            }
        }
    }
}
