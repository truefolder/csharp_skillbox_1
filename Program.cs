using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            phoneBook.Sort(new FirstNameContactComparer());
            phoneBook.Sort(new LastNameContactComparer());
        }
    }
    public class Contact // модель класса
    {
        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public String LastName { get; }
        public long PhoneNumber { get; }
        public String Email { get; }
    }

    class FirstNameContactComparer : IComparer<Contact>
    {
        public int Compare(Contact a, Contact b)
        {
            var name = a.Name.CompareTo(b.Name);
            if (name == 0)
                return a.Name.CompareTo(b.Name);
            return name;
        }
    }

    class LastNameContactComparer : IComparer<Contact>
    {
        public int Compare(Contact a, Contact b)
        {
            var lastName = a.LastName.CompareTo(b.LastName);
            if (lastName == 0)
                return a.LastName.CompareTo(b.LastName);
            return lastName;
        }
    }
}
