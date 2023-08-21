using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFr_dz2_Library_multi_table_.Model
{
    internal class Category  // класс Категория
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }  // название категории

        // реализация связи 1:N, одна категория - множество книг
        // внутри категории формируем коллекцию книг
        public virtual ICollection<Book> books { get; set; }
        public Category()
        {
            // выделяем место для коллекии книг
            books = new List<Book>();
        }
        public override string ToString()
        {
            return $"Category: {Name}";
        }
    }
}
