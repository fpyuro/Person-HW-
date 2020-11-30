using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_HW_Юрий
{
    #region условие
    //    Создать класс Person и разработать программу для тестирования работы с данными человека.
    //Поля: 
    //•	Имя,+
    //•	Фамилия,+
    //•	Отчество,+
    //•	Год рождения,+
    //•	ИИН.+
    //Методы: 
    //•	Возвращает строку с полным ФИО,+
    //•	Возвращает строку с фамилией и инициалами,+
    //•	Возвращает текущий возраст.+
    //Свойства:
    //•	Имя,+
    //•	Фамилия,+
    //•	Отчество,+
    //•	Год рождения (для чтения),+
    //•	Возраст (для чтения)+
    //•	ИИН (для чтения). +
    //Конструктор:
    //•	Год рождения,+
    //•	ИИН.+
    #endregion

    class Person
    {
        //поля
        string name { get; set; } //имя
        string surname { get; set; } //фамилия
        string middleName { get; set; } //отчество
        int yearOfBirth { get; } //год рождения int - потому-что  variable.Year возвращает int
        string IIN { get; } //ИИН
        int age { get; } //возраст

        //конструкторы
        public Person() { }
        public Person(string name, string surname, string middleName):this(name, surname, middleName, 0, "") { }
        public Person(string name, string surname, string middleName, int yearOfBirth):this(name, surname, middleName, yearOfBirth, "") { }
        
        public Person(string name, string surname, string middleName, int yearOfBirth, string IIN)
        {
            this.name = name;
            this.surname = surname;
            this.middleName = middleName;
            this.IIN = IIN;
            this.yearOfBirth = yearOfBirth;
            this.age = getAge(yearOfBirth);
        }


        //Методы: 
        //•	Возвращает строку с полным ФИО
        public string getFIO()
        {
            string fio = name + " " + surname + " " + middleName;
            return fio;
        }
        //•	Возвращает строку с фамилией и инициалами
        public string getSurnameAndIO()
        {
            string surIO = surname + " " + name.ToUpper()[0] + "." + middleName.ToUpper()[0] + ".";
            return surIO;
        }
        //•	Возвращает текущий возраст.
        int getAge(int yearOfBirth) //закрытый метод, просчитывае поле age
        {
            DateTime now = DateTime.Today;    
            int age = now.Year - yearOfBirth; //считает не всегда правильно, т.к. нет точной даты рождения
                                              //if (bday > now.AddYears(-age)) age--;
            return age;
        }
        public int Age() => getAge(this.yearOfBirth);
        


    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Зефиров", "Дементий", "Михеевич");
            Person p2 = new Person("Ахматов", "Эрнст", "Матвеевич", 1956);
            Person p3 = new Person("Багрова ", "Ульяна ", "Брониславовна", 1974, "1234-5678-9012-3456");
            Console.WriteLine(p3.Age());
            Console.WriteLine(p1.getFIO());
            Console.WriteLine(p2.getSurnameAndIO());

            Console.ReadLine();
        }
    }
}
