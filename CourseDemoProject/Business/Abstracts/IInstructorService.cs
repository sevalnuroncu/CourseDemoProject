using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseDemoProject.Entities;

namespace CourseDemoProject.Business.Abstracts
{
    public interface IInstructorService
    {
        List<Instructor> GetAll();
        void Add(Instructor ınstructor);
        void Update(int id);
        void Delete(Instructor ınstructor);
    }
}
