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
        private List<Category> _categories=new List<Category>();
        public CategoryDal() 
        { 
            Category category = new Category() {CategoryId=1, Name="Programlama" };
            _categories.Add(category);
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

        public Category GetById(int id)
        {
            foreach (var category in _categories)
            {
                if (category.CategoryId==id)
                {
                    return category;
                }


            }
            return new Category();
        }


        public void Update(Category category)
        {
            Category updatedCategory= new Category();
            updatedCategory.CategoryId = category.CategoryId;
            updatedCategory.Name = category.Name;
        }
    }
}
