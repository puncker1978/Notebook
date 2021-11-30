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
        /// <summary>
        /// Статический метод, который проверяет, что введённая строка является последовательностью цифр
        /// </summary>
        /// <param name="num">Телефон</param>
        /// <returns></returns>
        internal static bool IsNumber(string num)
        {
            bool isNum = true;
            foreach (char ch in num)
            {
                if (ch < '0' || ch > '9')
                {
                    isNum = false;
                    break;
                }
            }
            return isNum;
        }



        static void Main(string[] args)
        {
            Person person;

            // Инициализация списка записей
            //List<Person> listPerson = new List<Person>();
            
            for (; ; )
            {
                #region Инициализируем кажое поле для записи
                
                    Random rnd = new Random();
                    int id = rnd.Next(int.MaxValue);

                    Console.WriteLine($"Введите данные");


                    Console.Write("Фамилия: ");
                    string secondName = Console.ReadLine();

                    Console.Write("Имя: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Отчество: ");
                    string patronymic = Console.ReadLine();

                    Console.Write("Город/Село/Посёлок/Деревня: ");
                    string town = Console.ReadLine();

                    Console.Write("Улица: ");
                    string street = Console.ReadLine();

                    Console.Write("Дом: ");
                    string houseNumber = Console.ReadLine();

                    Console.Write("Квартира: ");
                    string flatNumber = Console.ReadLine();


                    string phoneNumber, mobilePhone, homePhone, workPhone;

                    Console.Write("Мобильный: ");
                    phoneNumber = Console.ReadLine();
                    if (IsNumber(phoneNumber))
                    {
                        mobilePhone = phoneNumber;
                    }
                    else
                    {
                        mobilePhone = "нет";
                    }

                    Console.Write("Домашний: ");
                    phoneNumber = Console.ReadLine();
                    if (IsNumber(phoneNumber))
                    {
                        homePhone = phoneNumber;
                    }
                    else
                    {
                        homePhone = "Нет";
                    }

                    Console.Write("Рабочий: ");
                    phoneNumber = Console.ReadLine();
                    if (IsNumber(phoneNumber))
                    {
                        workPhone = phoneNumber;
                    }
                    else
                    {
                        workPhone = "Нет";
                    }
                #endregion

                #region Инициализация экземпляра класса Person с помощью конструктора с параметрами
                //Передаём в экземпляр класса с помощью конструктора сведения об одной записи
                person = new Person(firstName, secondName, patronymic, town, street, houseNumber, flatNumber,
                        mobilePhone, homePhone, workPhone);
                #endregion
                
                //Добавляем одну запись в список записей
                Records.AddRecord(person);

                //Очищаем окно консоли
                Console.Clear();

                //Спрашиваем, следует ли добавить ещё одну запись
                Console.Write("Добавить ещё одину запись (д/н): ");
                string yesNo = Console.ReadLine();
                if (yesNo == "д") continue;
                else break;
            }

            //Добавляем список сведений о персонах в файл notebook.xml с помощью метода AddRecord класса Xml
            Xml xml = new Xml();
            xml.AddRecord(Records.people);
            Console.ReadKey();
        }
    }
}
