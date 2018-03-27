using System;
using SQLite;

namespace ALabs.Algorithms.Database
{
    /// <summary>
    /// Класс, представляющий таблицу "queries"
    /// </summary>
    [Table("queries")]
    class MergeSortQuery
    {
        /// <summary>
        /// Номер сортировки
        /// </summary>
        [PrimaryKey, AutoIncrement, Column("sortnum")]
        public int SortNum { get; set; }

        /// <summary>
        /// Элементы последовательности
        /// </summary>
        [Column("mas")]
        public string Mas { get; set; }
        
        /// <summary>
        /// Число элементов в последовательности
        /// </summary>
        [Column("count")]
        public long Count { get; set; }
        
    }
}
