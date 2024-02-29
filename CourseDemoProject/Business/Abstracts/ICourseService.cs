using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseDemoProject.Entities;

namespace CourseDemoProject.Business.Abstracts
{
    public interface ICourseService
    {
        List<Course> GetAll();
        void Add(Course course);
        void Update(int id);
        void Delete(Course course);
    }
}
