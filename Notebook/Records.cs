using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook
{
    internal static class Records
    {
        internal static List<Person> people = new List<Person>();

        internal static void AddRecord(Person person)
        {
            people.Add(person);
        }

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
    }
}
