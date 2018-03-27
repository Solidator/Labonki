using System;
using SQLite;

namespace ALabs.Algorithms.Database
{
    /// <summary>
    /// Класс, представляющий таблицу "iterations"
    /// </summary>
    [Table("iterations")]
    class MergeSortIteration
    {
        /// <summary>
        /// Номер сортировки
        /// </summary>
        [Column("sortNum")]
        public int SortNum { get; set; }

        /// <summary>
        /// Имя файла
        /// </summary>
        [Column("filename")]
        public string FileName { get; set; }

        /// <summary>
        /// Длина серии
        /// </summary>
        [Column("serlength")]
        public int SerialLength { get; set; }

        /// <summary>
        /// Содержимое файла 
        /// </summary>
        [Column("file")]
        public string File { get; set; }
        
    }
}