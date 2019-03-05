using System;
using System.Collections.Generic;

namespace P01_StudentSystem.Data.Models
{
    public class Course
    {
        //o CourseId
        //o Name(up to 80 characters, unicode)
        //o Description(unicode, not required)
        //o StartDate
        //o EndDate
        //o Price

        public Course()
        {
            this.StudentsEnrolled = new HashSet<StudentCourse>();
            this.Resources = new HashSet<Resource>();
            this.HomeworkSubmissions = new HashSet<Homework>();
        }

        public int CourseId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Price { get; set; }


        public ICollection<StudentCourse> StudentsEnrolled { get; set; }

        public ICollection<Resource> Resources { get; set; }

        public ICollection<Homework> HomeworkSubmissions { get; set; }

    }
}