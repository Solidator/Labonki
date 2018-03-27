using System;
using SQLite;
using System.Collections.Generic;

namespace ALabs.Algorithms.Database
{
    /// <summary>
    /// Работа с базой данных: установка подключения, создание таблиц, выполнение запросов
    /// </summary>
    static class DBWork
    {
        /// <summary>
        /// Экземпляр класса соединения с базой данных
        /// </summary>
        private static SQLiteConnection db;

        /// <summary>
        /// Конструктор класса: подключение к базе данных и создание таблиц
        /// </summary>
        static DBWork()
        {
            db = new SQLiteConnection("algorithms.db");
            db.CreateTable<MergeSortQuery>();
            db.CreateTable<MergeSortIteration>();
        }

        /// <summary>
        /// Запись объекта класса в базу данных
        /// </summary>
        /// <typeparam name="T">Класс объекта</typeparam>
        /// <param name="item">Объект для записи</param>
        public static void Add<T>(T item)
        {
            db.Insert(item);
        }
        
        /// <summary>
        /// Получение списка запросов на сортировку
        /// </summary>
        /// <returns>Список запросов</returns>
        public static int GetSortCount()
        {
            return db.Table<MergeSortQuery>().Count();
        }
        
    }
}
