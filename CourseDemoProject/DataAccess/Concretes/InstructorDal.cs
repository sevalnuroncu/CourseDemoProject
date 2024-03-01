using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseDemoProject.DataAccess.Abstracts;
using CourseDemoProject.Entities;

namespace CourseDemoProject.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        private List<Instructor> _instructors=new List<Instructor>();

        public InstructorDal()
        {

            Instructor instructor1= new Instructor() { IntructorId=1,FistName="Engin",LastName="Demiroğ"};
            Instructor instructor2 = new Instructor() { IntructorId = 2, FistName = "Halit Enes", LastName = "Kalaycı" };
            _instructors.Add(instructor1);
            _instructors.Add(instructor2);
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int id)
        {
            foreach (var instructor in _instructors)
            {
                if (instructor.IntructorId==id)
                {
                    return instructor;
                }
                else
                {
                    Console.WriteLine("Eleman bulunamadı");
                    
                }


            }
            return new Instructor();
        }


        public void Update(Instructor instructor)
        {
            Instructor updatedInstructor=new Instructor();
            updatedInstructor.IntructorId = instructor.IntructorId;
            updatedInstructor.FistName = instructor.FistName;
            updatedInstructor.LastName= instructor.LastName;
        }

   
    }
}
