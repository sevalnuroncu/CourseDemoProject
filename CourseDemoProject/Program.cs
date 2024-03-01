
using CourseDemoProject.Business.Concretes;
using CourseDemoProject.DataAccess.Concretes;
using CourseDemoProject.Entities;

CourseManager courseManager=new CourseManager(new CourseDal());

//Tüm kursların adı
Console.WriteLine("-------------Tüm kursların listelenmesi-----------");
List<Course> courses=courseManager.GetAll();
foreach (var course in courses)
{
    Console.WriteLine(course.Name);
}

//Kurs ekleme
Console.WriteLine("-------Kurs ekleme----------");
courseManager.Add(new Course() { Id = 5, CategoryId = 1, Name = "Kotlin", Description = "Kotlin Kursu", IntructorId = 1 });
foreach (var course in courses)
{
    Console.WriteLine(course.Name);
}

//Kurs Güncelleme
Console.WriteLine("--------Kurs güncelleme-----------");
Course updatedCourse=courseManager.GetById(5);
updatedCourse.Description = "Kotlin kursu güncellendi";
courseManager.Update(updatedCourse);
foreach (var course in courses)
{
    Console.WriteLine(course.Name+":::::"+course.Description);
}

//Kurs Silme
Console.WriteLine("--------Kurs silme-----------");
courseManager.Delete(courseManager.GetById(5));
foreach (var course in courses)
{
    Console.WriteLine(course.Name);
}

//////////////////////////////////////////////////////////////////////////////


CategoryManager categoryManager =new CategoryManager(new CategoryDal());
Console.WriteLine("--------------Kategorilerin Listelenmesi---------------");
//Tüm kategorilerin listelenmesi
categoryManager.GetAll().ForEach(c => Console.WriteLine(c.CategoryId+" "+c.Name));
//Kategori ekleme
Console.WriteLine("---------Kategori ekleme------------");
categoryManager.Add(new Category() {CategoryId=2,Name="Backend " });
categoryManager.GetAll().ForEach(c => Console.WriteLine(c.CategoryId + " " + c.Name));
//Kategori güncelleme
Console.WriteLine("---------Kategori güncelleme------------");
categoryManager.GetById(2).Name = "Frontend";
categoryManager.Update(categoryManager.GetById(2));
categoryManager.GetAll().ForEach(c => Console.WriteLine(c.CategoryId + " " + c.Name));
//Kategori silme
Console.WriteLine("---------Kategori silme------------");
categoryManager.Delete(categoryManager.GetById(2));
categoryManager.GetAll().ForEach(c => Console.WriteLine(c.CategoryId + " " + c.Name));

//////////////////////////////////////////////////////////////////////////////

InstructorManager instructorManager=new InstructorManager(new InstructorDal());
Console.WriteLine("--------------Instructorların Listelenmesi---------------");
//Tüm Instructorların listelenmesi
instructorManager.GetAll().ForEach((c) => Console.WriteLine(c.IntructorId+" "+c.FistName+" "+c.LastName));
//Instructor ekleme
Console.WriteLine("---------Instructor ekleme------------");
instructorManager.Add(new Instructor() { IntructorId = 3, FistName = "Aaaa", LastName = "BBbb" });
instructorManager.GetAll().ForEach((c) => Console.WriteLine(c.IntructorId + " " + c.FistName + " " + c.LastName));
//Instructor güncelleme
Console.WriteLine("---------Instructor güncelleme------------");
instructorManager.Update(instructorManager.GetById(3));
instructorManager.GetById(3).FistName = "Dddd";
instructorManager.GetAll().ForEach((c) => Console.WriteLine(c.IntructorId + " " + c.FistName + " " + c.LastName));
//Instructor silme
Console.WriteLine("---------Instructor silme------------");
instructorManager.Delete(instructorManager.GetById(3));
instructorManager.GetAll().ForEach(c => Console.WriteLine(c.IntructorId + " " + c.FistName + " " + c.LastName));











Console.ReadLine();

