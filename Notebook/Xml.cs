using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Notebook
{
    class Xml
    {
        public void AddRecord(List<Person> personList)
        {
            XDocument xDoc = XDocument.Load("notebook.xml");
            XElement root = xDoc.Element("Persons");
            foreach (Person person in personList)
            {
                root.Add(new XElement("Person",
                            new XAttribute("Id", person.Id),
                            new XElement("Фамилия", person.SecondName),
                            new XElement("Имя", person.FirstName),
                            new XElement("Отчество", person.Patronymic),
                            new XElement("Адрес",
                            new XElement("Город", person.Town),
                            new XElement("Улица", person.Street),
                            new XElement("Дом", person.HouseNumber),
                            new XElement("Квартира", person.FlatNumber)),
                            new XElement("Контакты",
                            new XAttribute("Домашний", person.HomePhone),
                            new XAttribute("Мобильный", person.MobilePhone),
                            new XElement("Рабочий", person.WorkPhone))));
            }
            xDoc.Save("notebook.xml");
            Console.WriteLine("Содержимое файла notebook.xml");
            Console.WriteLine(xDoc);
        }
    }
}
