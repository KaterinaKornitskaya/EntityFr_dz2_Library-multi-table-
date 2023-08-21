using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFr_dz2_Library_multi_table_.Model
{
    // класс книга
    internal class Book
    {
        public int Id { get; set; }

        [Required]  // not null, поле обязательно к инициализации
        public string Name { get; set; }  // название книги 

        // навигационные свойства:
        // книга относится к одному автору
        public virtual Author Author { get; set; }
        // книга относится к одной категории
        public virtual Category Category { get; set; }
        // книга относится к одному издательству
        public virtual Publishing Publishing { get; set; }
        public Book() { }

        public override string ToString()
        {
            //return $"{Id} {Name} {Author.Id} {Category.Id} {Publishing.Id}";
            return $"(Book Id:) {Id} {Name} (Author:) {Author.FirstName} {Author.LastName}" +
                $"(Category:) {Category.Name} (Publishing:) {Publishing.Name}";
        }
    }
}
