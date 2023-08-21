using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFr_dz2_Library_multi_table_.Model
{
    internal class Publishing  // класс Издательство
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }  // название издательства

        // реализация связи 1:N, одно издательство - множество книг
        // внутри издательства формируем коллекцию книг
        public virtual ICollection<Book> books { get; set; }
        public Publishing()
        {
            // выделяем место для коллекии книг
            books = new List<Book>();
        }
        public override string ToString()
        {
            return $"Publishing: {Name}";
        }
    }
}
