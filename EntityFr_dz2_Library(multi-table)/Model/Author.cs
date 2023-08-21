using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityFr_dz2_Library_multi_table_.Model
{
    internal class Author  // класс Автор
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }  // имя автора

        [Required]
        public string LastName { get; set; }  // фамилия автора

        // реализация связи 1:N, один автор - множество книг
        // внутри автора формируем коллекцию книг
        public virtual ICollection<Book> books { get; set; }
        public Author()
        {
            // выделение места для коллекции книг
            books = new List<Book>();
        }
        public override string ToString()
        {
            return $"Author name: {FirstName}, author surname: {LastName}";
        }
    }
}
