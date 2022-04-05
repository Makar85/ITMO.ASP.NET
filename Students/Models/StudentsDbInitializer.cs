using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class StudentsDbInitializer:DropCreateDatabaseIfModelChanges<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            context.Students.Add(new Student {Name = "Анна", Surname = "Литвина", Subject ="Философия", Score = 97});
            context.Students.Add(new Student { Name = "Михаил", Surname = "Иванов", Subject = "Философия", Score = 84 });
            context.Students.Add(new Student { Name = "Иван", Surname = "Петров", Subject = "Философия", Score = 93 });
                
                base.Seed(context);
        }
    }
}