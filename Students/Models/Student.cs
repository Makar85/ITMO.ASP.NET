using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Students.Models
{
    public class Student
    {
        // ID студента
        public virtual int StudentId { get; set; }
        // Имя студента
        [DisplayName("Имя")]
        public virtual string Name { get; set; }
        // Фамилия студента
        [DisplayName("Фамилия")]
        public virtual string Surname { get; set; }
        // Наименование дисциплины
        [DisplayName("Предмет")]
        public virtual string Subject { get; set; }
        // Колличесвто баллов
        [DisplayName("Колличесвто баллов")]
        public virtual int Score { get; set; }
    }
}