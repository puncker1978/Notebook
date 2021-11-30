using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook
{
    /// <summary>
    /// Статический класс для работы со списком записей
    /// </summary>
    internal static class Records
    {
        /// <summary>
        /// Статический список записей
        /// </summary>
        internal static List<Person> people = new List<Person>();

        /// <summary>
        /// Статический метод для добавления сведений об одной записи в список записей
        /// </summary>
        /// <param name="person">Сведения об одной записи</param>
        internal static void AddRecord(Person person)
        {
            people.Add(person);
        }

        /// <summary>
        /// Статический метод отображения всех записей, хранящихся в статическом списке
        /// </summary>
        internal static void ShowRecords()
        {
            foreach (Person person in people)
            {
                Console.WriteLine($"Id: {person.Id}\t" +
                    $"Фамилия: {person.SecondName}\t" +
                    $"Имя: {person.FirstName}\t" +
                    $"Отчество: {person.Patronymic}\t" +
                    $"Город: {person.Town}\t" +
                    $"Улица: {person.Street}\t" +
                    $"Дом: {person.HouseNumber}\t" +
                    $"Квартира: {person.FlatNumber}\t" +
                    $"Мобильный: {person.MobilePhone}\t" +
                    $"Рабочий: {person.WorkPhone}\t" +
                    $"Домашний: {person.HomePhone}");
            }
        }

        /// <summary>
        /// Метод поиска сведений об одной записи по Фамилии.
        /// Находит первую запись с подходящей фамилией
        /// </summary>
        /// <param name="secondName">Фамилия для поиска</param>
        /// <returns>Возвращает объект, сведения об одной записи</returns>
        internal static Person FindRecord(string secondName)
        {
            Person person = null;

            foreach (Person per in people)
            {
                if (per.SecondName == secondName)
                {
                    person = per;
                    break;
                }
                else
                {
                    continue;
                }
            }
                return person;
        }

        /// <summary>
        /// Статический метод удаления сведений об одной записи
        /// при совпадении фамилии
        /// </summary>
        /// <param name="person">Сведения об одной записи</param>
        internal static void DeleteRecord(Person person)
        {
            foreach(Person per in people)
            {
                if(person.SecondName == per.SecondName)
                {
                    people.Remove(per);
                    break;
                }
            }
        }
    }
}
