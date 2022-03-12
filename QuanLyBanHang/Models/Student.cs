using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class Student
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Born { get; set; }
        public string Class { get; set; }
        public string Specialized { get; set; } 

        public static IEnumerable<Student> MockData()
        {
            return new List<Student>()
            {
                new Student() {StudentID = "STD001", FirstName = "Vo", LastName = "Thanh Luan", Born = new DateTime(2000,3,13), Class = "PM1803", Specialized = "CNPM"},
                new Student() {StudentID = "STD002", FirstName = "Le", LastName = "Thai Anh Thu", Born = new DateTime(1999,4,18), Class = "PM1904", Specialized = "CNPM"},
            }
        }
    }
}