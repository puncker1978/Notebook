using System;
using System.Collections.Generic;
using System.Text;

namespace Notebook
{
    internal class Person
    {
        #region Поля
        /// <summary>
        /// Идентификатор
        /// </summary>
        private int id;

        /// <summary>
        /// Имя
        /// </summary>
        private string firstName;

        /// <summary>
        /// Фамилия
        /// </summary>
        private string secondName;

        /// <summary>
        /// Отчество
        /// </summary>
        private string patronymic;

        /// <summary>
        /// Город
        /// </summary>
        private string town;

        /// <summary>
        /// Улица
        /// </summary>
        private string street;

        /// <summary>
        /// Номер дома
        /// </summary>
        private string houseNumber;

        /// <summary>
        /// Номер квартиры
        /// </summary>
        private string flatNumber;

        /// <summary>
        /// Мобильный
        /// </summary>
        private string mobilePhone;

        /// <summary>
        /// Домашний
        /// </summary>
        private string homePhone;

        /// <summary>
        /// Рабочий
        /// </summary>
        private string workPhone;

        /// <summary>
        /// Список записей
        /// </summary>
        List<Person> personList = new List<Person>();

        #endregion

        #region Свойства
        /// <summary>
        /// Идентификатор
        /// </summary>
        internal int Id { get => id; set => id = value; }

        /// <summary>
        /// Имя
        /// </summary>
        internal string FirstName { get => firstName; set => firstName = value; }

        /// <summary>
        /// Фамилия
        /// </summary>
        internal string SecondName { get => secondName; set => secondName = value; }

        /// <summary>
        /// Отчество
        /// </summary>
        internal string Patronymic { get => patronymic; set => patronymic = value; }

        /// <summary>
        /// Город
        /// </summary>
        internal string Town { get => town; set => town = value; }

        /// <summary>
        /// Улица
        /// </summary>
        internal string Street { get => street; set => street = value; }

        /// <summary>
        /// Номер дома
        /// </summary>
        internal string HouseNumber { get => houseNumber; set => houseNumber = value; }

        /// <summary>
        /// Номер квартиры
        /// </summary>
        internal string FlatNumber { get => flatNumber; set => flatNumber = value; }

        /// <summary>
        /// Мобильный
        /// </summary>
        internal string MobilePhone { get => mobilePhone; set => mobilePhone = value; }

        /// <summary>
        /// Домашний
        /// </summary>
        internal string HomePhone { get => homePhone; set => homePhone = value; }

        /// <summary>
        /// Рабочий
        /// </summary>
        internal string WorkPhone { get => workPhone; set => workPhone = value; }

        /// <summary>
        /// Список записей
        /// </summary>
        internal List<Person> PersonList { get => personList; set => personList = value; }
        #endregion

        #region Конструктор
        /// <summary>
        /// Конструктор инициализирует сведения об одной записи записной книжки
        /// </summary>
        /// <param name="Id">Id</param>
        /// <param name="FirstName">Имя</param>
        /// <param name="SecondName">Фамилия</param>
        /// <param name="Patronymic">Отчество</param>
        /// <param name="Town">Город</param>
        /// <param name="Street">Улица</param>
        /// <param name="HouseNumber">Номер дома</param>
        /// <param name="FlatNumber">Номер квартиры</param>
        /// <param name="MobilePhone">Мобильный</param>
        /// <param name="HomePhone">Домашний</param>
        /// <param name="WorkPhone">Рабочий</param>
        internal Person(int Id, string FirstName, string SecondName, string Patronymic, string Town, string Street,
            string HouseNumber, string FlatNumber, string MobilePhone, string HomePhone, string WorkPhone)
        {
            Random rnd = new Random();
            this.Id = rnd.Next(int.MaxValue);
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.Patronymic = Patronymic;
            this.Town = Town;
            this.Street = Street;
            this.HouseNumber = HouseNumber;
            this.FlatNumber = FlatNumber;
            this.MobilePhone = MobilePhone;
            this.HomePhone = HomePhone;
            this.WorkPhone = WorkPhone;
        }
        //public Person() { }
        #endregion


        #region Методы
        
        #endregion
    }
}
