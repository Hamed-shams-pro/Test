

using CreateGenericClass;

Student student = new Student();
student.Id = 2147099990;
student.Name = "Hamed";
student.Family = "Shams";
student.PrintInfoAsync();
student.GetAgeAsync(19);

//Teacher teacher = new Teacher();
//teacher.Id = 255;
Console.ReadLine();