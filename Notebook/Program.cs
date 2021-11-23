using System;
using System.Collections.Generic;

namespace Notebook
{
    /* Задание 4. Записная книжка


        Что нужно сделать
        Программа спрашивает у пользователя данные о контакте:

        ФИО
        Улица
        Номер дома
        Номер квартиры
        Мобильный телефон
        Домашний телефон
            Советы и рекомендации
        Заполняйте XElement в ходе заполнения данных. Изучите возможности XElement в документации Microsoft.



        Что оценивается
        Программа создаёт Xml файл, содержащий все данные о контакте.*/
    class Program
    {
        

       
            
           
        static void Main(string[] args)
        {
            for (; ; )
            {
                Person person = new Person();

                Random rnd = new Random();
                person.Id = rnd.Next(int.MaxValue);
                
                Console.WriteLine($"Введите данные");


                Console.Write("Фамилия: ");
                person.SecondName = Console.ReadLine();

                Console.Write("Имя: ");
                person.FirstName = Console.ReadLine();

                Console.Write("Отчество: ");
                person.Patronymic = Console.ReadLine();

                Console.Write("Город/Село/Посёлок/Деревня: ");
                person.Town = Console.ReadLine();

                Console.Write("Улица: ");
                person.Street = Console.ReadLine();

                Console.Write("Дом: ");
                person.HouseNumber = Console.ReadLine();

                Console.Write("Квартира: ");
                person.FlatNumber = Console.ReadLine();

                
                string phoneNumber;

                Console.Write("Мобильный: ");
                phoneNumber = Console.ReadLine();
                if (person.IsNumber(phoneNumber))
                {
                    person.MobilePhone = phoneNumber;
                }
                else
                {
                    person.MobilePhone = "нет";
                }

                Console.Write("Домашний: ");
                phoneNumber= Console.ReadLine();
                if (person.IsNumber(phoneNumber))
                {
                    person.HomePhone = phoneNumber;
                }
                else
                {
                    person.HomePhone = "Нет";
                }

                Console.Write("Рабочий: ");
                phoneNumber = Console.ReadLine();
                if (person.IsNumber(phoneNumber))
                {
                    person.WorkPhone = phoneNumber;
                }
                else
                {
                    person.WorkPhone = "Нет";
                }

                //Добавляем данные об одном человеке в список сведений о персонах
                personList.Add(person);

                //Очищаем окно консоли
                Console.Clear();

                //Спрашиваем, следует ли добавить ещё одну запись
                Console.Write("Добавить ещё одину запись (д/н): ");
                string yesNo = Console.ReadLine();
                if (yesNo == "д") continue;
                else break;
            }

            //Добавляем сведения об одной персоне в файл notebook.xml с помощью метода AddRecord класса Xml
            Xml xml = new Xml();
            xml.AddRecord(personList);
            Console.ReadKey();
        }
    }
}
