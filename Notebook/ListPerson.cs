using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook
{
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
        public ListPerson(List<Person> persons)
        {
            Persons = persons;
        }

        #endregion
    }
}
