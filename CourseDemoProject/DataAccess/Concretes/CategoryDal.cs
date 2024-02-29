using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseDemoProject.DataAccess.Abstracts;
using CourseDemoProject.Entities;

namespace CourseDemoProject.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;
        public CategoryDal() 
        { 
            Category category = new Category() {CategoryId=1,Name="Programlama" };
        }
        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
