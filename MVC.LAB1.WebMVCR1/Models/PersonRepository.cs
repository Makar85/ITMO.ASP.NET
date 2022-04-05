using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.LAB1.WebMVCR1.Models
{
    public class PersonRepository
    {
        //Добавьте в класс поле, описывающие коллекцию – список персон:
        private List<Person> persons = new List<Person>();
        //Далее в классе укажите два свойства только для чтения – первое
        //должно возвращать количество персон, второе – саму коллекцию:
        public int NumberOfPerson
        { 
            get 
            { 
                return persons.Count();
            } 
        }
        public IEnumerable<Person> GetAllResponses 
        { 
            get 
            {
                return persons;
            } 
        }
        //Для возможности добавления персон в коллекцию реализуйте в классе советующий метод:
        public void AddResponse(Person pers) 
        {
            persons.Add(pers); 
        }
    }
}
