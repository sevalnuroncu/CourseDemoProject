using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseDemoProject.DataAccess.Abstracts;
using CourseDemoProject.Entities;

namespace CourseDemoProject.DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        private List<Course> _courses=new List<Course>();
        public CourseDal()
        {
            Course course1 = new Course() { Id=1,Description="C# ",Name= "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",CategoryId=1,IntructorId=1 };
            Course course2 = new Course() { Id = 2, Description = "Senior", Name = "Senior Yazılım Geliştirici Yetiştirme Kampı", CategoryId = 1, IntructorId = 1 };
            Course course3 = new Course() { Id = 3, Description = "Selenium ", Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium", CategoryId = 1, IntructorId = 2 };
            Course course4 = new Course() { Id = 4, Description = " Java", Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA", CategoryId = 1, IntructorId = 1 };
            _courses.Add(course1);
            _courses.Add(course2);
            _courses.Add(course3);
            _courses.Add(course4);


        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            _courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public Course GetById(int id)
        {
            foreach (var course in _courses)
            {
                if (course.Id==id)
                {
                    return course;
                }
            }
            return new Course();
        }

        public void Update(Course course)
        {
            Course updatedCourse = new Course();
            updatedCourse.Id = course.Id;
            updatedCourse.Description = course.Description;
            updatedCourse.Name = course.Name;
            updatedCourse.CategoryId = course.CategoryId;
            updatedCourse.IntructorId = course.IntructorId;
           
            
        }

    }
}
