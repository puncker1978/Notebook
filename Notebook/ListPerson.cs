using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook
{
    /// <summary>
    /// Класс содержащий сведения о записях в записной книжке
    /// </summary>
    internal class ListPerson
    {
        #region Поля
        /// <summary>
        /// Список записей в записной книжке
        /// </summary>
        private List<Person> persons;
        #endregion

        #region Свойства
        /// <summary>
        /// Список записей в записной книжке
        /// </summary>
        internal List<Person> Persons { get => persons; set => persons = value; }
        #endregion

        #region Конструкторы
        //public ListPerson(Person person)
        //{
        //    Persons.Add(person);
        //}

        #endregion

        #region Методы
        internal void AddToListPerson(Person person)
        {
            Persons.Add(person);
        }
        #endregion
    }
}
