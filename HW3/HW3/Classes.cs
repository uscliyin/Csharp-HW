using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    using System;
    using System.Collections.Generic;

    // Abstraction
    interface IPersonService
    {
        int CalculateAge(DateTime birthDate);
        decimal CalculateSalary(decimal baseSalary);
        List<Address> GetAddresses();
    }

    interface IStudentService : IPersonService
    {
        List<Course> GetCourses();
        double CalculateGPA();
    }

    interface IInstructorService : IPersonService
    {
        Department Department { get; set; }
        bool IsDepartmentHead { get; set; }
        decimal CalculateBonusSalary();
    }

    interface IDepartmentService
    {
        Instructor Head { get; set; }
        decimal Budget { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        List<Course> GetCourses();
        void AddCourse(Course course);
        void RemoveCourse(Course course);
    }


    class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }

    class Person : IPersonService
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal BaseSalary { get; set; }
        private List<Address> addresses = new List<Address>();

        public int CalculateAge(DateTime birthDate)
        {
            return DateTime.Today.Year - birthDate.Year;
        }

        public decimal CalculateSalary(decimal baseSalary)
        {
            if (baseSalary < 0)
            {
                throw new ArgumentException("Salary cannot be negative");
            }
            return baseSalary;
        }

        public List<Address> GetAddresses()
        {
            return addresses;
        }

        public void AddAddress(Address address)
        {
            addresses.Add(address);
        }
    }

    class Student : Person, IStudentService
    {
        private List<Course> courses = new List<Course>();

        public List<Course> GetCourses()
        {
            return courses;
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public double CalculateGPA()
        {
            double totalGradePoints = 0;
            double totalCredits = 0;
            foreach (Course course in courses)
            {
                switch (course.Grade)
                {
                    case "A":
                        totalGradePoints += 4 * course.Credits;
                        break;
                    case "B":
                        totalGradePoints += 3 * course.Credits;
                        break;
                    case "C":
                        totalGradePoints += 2 * course.Credits;
                        break;
                    case "D":
                        totalGradePoints += 1 * course.Credits;
                        break;
                    default:
                        break;
                }
                totalCredits += course.Credits;
            }
            return totalGradePoints / totalCredits;
        }
    }

    class Instructor : Person, IInstructorService
    {
        public Department Department { get; set; }
        public bool IsDepartmentHead { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal ExperienceBonusRate { get; set; }

        public decimal CalculateBonusSalary()
        {
            TimeSpan experience = DateTime.Now - JoinDate;
            decimal bonus = (decimal)(experience.TotalDays / 365) * ExperienceBonusRate;
            return bonus;
        }
    }

    class Course
    {
        public string Name { get; set; }
        public double Credits { get; set; }
        public string Grade { get; set; }
        private List<Student> enrolledStudents = new List<Student>();

        public List<Student> EnrolledStudents
        {
            get { return enrolledStudents; }
            set { enrolledStudents = value; }
        }

        public void AddStudent(Student student)
        {
            enrolledStudents.Add(student);
        }
    }

    class Department : IDepartmentService
    {
        public Instructor Head { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        private List<Course> courses;

        public Department()
        {
            courses = new List<Course>();
        }

        public List<Course> GetCourses()
        {
            return courses;
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            courses.Remove(course);
        }
    }
}
