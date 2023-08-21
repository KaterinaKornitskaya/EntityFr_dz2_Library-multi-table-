using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFr_dz2_Library_multi_table_.Model
{
    // класс-посредник с БД
    internal class LibraryContext : DbContext
    {
        // создаем коллекции в оперативной памяти - 
        // аналогично им будут созданы таблицы в БД
        public DbSet<Author> author { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<Publishing> publishing { get; set; }
        public DbSet<Book> books { get; set; }

        // в конструкторе наследуем конструктор базового класса
        // DbContext, в нем прописываем строку подключения
        public LibraryContext() : base("MyLibrary")
        {
            // методы для явной загрузки
            author.Load();
            category.Load();
            publishing.Load();
            books.Load();
        }

        // метод для добавления автора
        public void AddAuthor(string name, string surname)
        {
            Author obj = new Author { FirstName = name, LastName = surname };
            author.Add(obj);
            SaveChanges();
            //author.Load();
        }

        // метод для добавления категории
        public void AddCategory(string name)
        {
            Category obj = new Category { Name = name };
            category.Add(obj);
            SaveChanges();
            //category.Load();
        }

        // метод для добавления издательства
        public void AddPublish(string name)
        {
            Publishing obj = new Publishing { Name = name };
            publishing.Add(obj);
            SaveChanges();
            //publishing.Load();
        }

        // метод для добавления книги
        public void AddBook(string name, int idAuth, int idCat, int idPub)
        {
            try
            {
                Author auth = author.Find(idAuth);
                Category cat = category.Find(idCat);
                Publishing pub = publishing.Find(idPub);
                if(auth == null || cat == null || pub == null)
                {
                    throw new Exception("Книга не добавлена!");
                }
                Book obj = new Book
                { Name = name, Author = auth, Category = cat, Publishing = pub };
                books.Add(obj);
                MessageBox.Show($"Книга {obj.Name} добавлена");
                SaveChanges();
                //books.Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // метод для удаления книги (выбранной в листбоксе)
        public void DeleteBook(Book obj)
        {
            books.Remove(books.Find(obj.Id));
            MessageBox.Show($"Книга {obj.Name} удалена.");
            SaveChanges();
        }

        // метод для редактирования книги (выбранной в листбоксе)
        public void EditBook(Book obj, string name, int idAuth, int idCat, int idPub)
        {
            Author auth = author.Find(idAuth);
            Category cat = category.Find(idCat);
            Publishing pub = publishing.Find(idPub);
            obj = books.Find(obj.Id);
            obj.Name = name;
            obj.Author = auth;
            obj.Category = cat;
            obj.Publishing = pub;
            MessageBox.Show($"Книга изменена.");
            SaveChanges();
        }

        // метод для поиска книги по названию
        public List<Book> SearchBytitle(string title)
        {
            List<Book> list = new List<Book>();
            foreach (Book item in books)
            {
                // ищем не только полное совпадение, но и части слова,
                // в не зависимости от регистра
                if(item.Name.ToLower().Contains(title.ToLower()))
                    list.Add(item);
            }
            if (list.Count == 0)
                MessageBox.Show("Нет книг с таким названием!");
            return list;
        }

        // метод для поиска книги по автору
        public List<Book> SearchByAuthor(string surname)
        {
            List<Book> list = new List<Book>();
            foreach (Book item in books)
            {
                // ищем полное совпадение, но вне зависимости от регистра
                if(item.Author.LastName.ToLower() == surname.ToLower())
                {
                    list.Add(item); 
                }
            }
            if (list.Count == 0)
                MessageBox.Show("Нет книг с таким автором!");
            return list;
        }

        // метод для поиска книги по категории
        public List<Book> SearchByCategory(string cat)
        {
            List<Book> list = new List<Book>();
            foreach (Book item in books)
            {
                // ищем полное совпадение, но вне зависимости от регистра
                if (item.Category.Name.ToLower() == cat.ToLower())
                {
                    list.Add(item);
                }
            }
            if (list.Count == 0)
                MessageBox.Show("Нет книг такой категории!");
            return list;
        }

        // метод для поиска книги по издательству
        public List<Book> SearchByPublish(string publ)
        {
            List<Book> list = new List<Book>();
            foreach (Book item in books)
            {
                // ищем полное совпадение, но вне зависимости от регистра
                if (item.Publishing.Name.ToLower() == publ.ToLower())
                {
                    list.Add(item);
                }
            }
            if (list.Count == 0)
                MessageBox.Show("Нет книг такого издательства!");
            return list;
        }
    }
}
