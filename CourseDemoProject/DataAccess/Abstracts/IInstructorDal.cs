using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseDemoProject.Entities;

namespace CourseDemoProject.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        void Add(Instructor ınstructor);
        void Update(Instructor instructor);
        void Delete(Instructor ınstructor);
        Instructor GetById(int id);

    }
}
