﻿using System;
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
        private List<Instructor> _instructors;

        public InstructorDal()
        {

            Instructor instructor1= new Instructor() { IntructorId=1,FistName="Engin",LastName="Demiroğ"};
            Instructor instructor2 = new Instructor() { IntructorId = 2, FistName = "Halit Enes", LastName = "Kalaycı" };
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

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
