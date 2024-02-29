
using CourseDemoProject.Business.Concretes;
using CourseDemoProject.DataAccess.Concretes;
using CourseDemoProject.Entities;

CourseManager courseManager=new CourseManager(new CourseDal());

//Tüm kursların adı
Console.WriteLine("Tüm kursların listelenmesi");
List<Course> courses=courseManager.GetAll();
foreach (var course in courses)
{
    Console.WriteLine(course.Name);
}

//Kurs eklenmesi
Console.WriteLine("Kurs ekleme");
courseManager.Add(new Course() { Id = 4, CategoryId = 1, Name = "Kotlin", Description = "Kotlin Kursu", IntructorId = 1 });
List<Course> courses2 = courseManager.GetAll();
foreach (var course2 in courses)
{
    Console.WriteLine(course2.Name);
}

//Kurs Güncelleme
Console.WriteLine("Kurs güncelleme");
courseManager.Update(1);


Console.ReadLine();

