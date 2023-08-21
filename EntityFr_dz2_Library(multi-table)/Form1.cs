using EntityFr_dz2_Library_multi_table_.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFr_dz2_Library_multi_table_
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        // обработчик кнопки Добавить автора
        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            using(LibraryContext db = new LibraryContext())
            {
                db.AddAuthor(textBoxAddAuthorFName.Text, textBoxAddAuthLName.Text);
                MessageBox.Show($"Автор добавлен");
            }
        }

        // обработчик кнопки Добавить категорию
        private void buttonAddCat_Click(object sender, EventArgs e)
        {
            using(LibraryContext db = new LibraryContext())
            {
                db.AddCategory(textBoxAddCat.Text);
                MessageBox.Show($"Категория добавлена");
            }
        }

        // обработчик кнопки Добавить издательство
        private void buttonAddPubl_Click(object sender, EventArgs e)
        {
            using(LibraryContext db = new LibraryContext())
            {
                db.AddPublish(textBoxAddPubl.Text);
                MessageBox.Show($"Издательство добавлено");
            }
        }

        // обработчик кнопки Добавить книгу
        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            using(LibraryContext db = new LibraryContext())
            {
                db.AddBook(textBoxBookName.Text, Convert.ToInt32(textBoxBookAuthor.Text),
                    Convert.ToInt32(textBoxBookCat.Text), Convert.ToInt32(textBoxBookPublish.Text));
                listBox1.DataSource = db.books.ToList();
            }
        }

        // обработчик кнопки Показать все книги
        private void buttonShowBooks_Click(object sender, EventArgs e)
        {
            using(LibraryContext db = new LibraryContext())
            {
                //db.author.Load();
                //db.publishing.Load();
                //db.category.Load();
                //db.books.Load();
                listBox1.DataSource = db.books.ToList();
            }
        }

        // обработчик кнопки Удалить книгу (выбранную в листбоксе)
        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            using( LibraryContext db = new LibraryContext())
            {
                Book obj = listBox1.SelectedItem as Book;
                db.DeleteBook(obj);
                listBox1.DataSource = db.books.ToList();
            }
        }

        // обработчик кнопки Редактировать книгу (выбранную в листбоксе)
        private void buttonEditBook_Click(object sender, EventArgs e)
        {
            using(LibraryContext db = new LibraryContext())
            {
                Book obj = listBox1.SelectedItem as Book;
                db.EditBook(obj, textBoxBookName.Text, Convert.ToInt32(textBoxBookAuthor.Text),
                    Convert.ToInt32(textBoxBookCat.Text), Convert.ToInt32(textBoxBookPublish.Text));
                listBox1.DataSource = db.books.ToList();
            }
        }

        // обработчик события Выбо в листбоксе - копирование полей текущей книги
        // в соответствующие текстбоксы
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book obj = listBox1.SelectedItem as Book;
            textBoxBookName.Text = obj.Name;
            textBoxBookAuthor.Text = obj.Author.Id.ToString();
            textBoxBookCat.Text = obj.Category.Id.ToString();
            textBoxBookPublish.Text = obj.Publishing.Id.ToString();
        }

        // обработчик кнопки Поиск книги
        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            using(LibraryContext db = new LibraryContext())
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:  // поиск по фамилии автора
                        listBox2.DataSource = null;
                        listBox2.DataSource = db.SearchByAuthor(textBoxSearch.Text);
                        break;
                    case 1:  // поиск по названии книги
                        listBox2.DataSource = null;
                        listBox2.DataSource = db.SearchBytitle(textBoxSearch.Text);
                        break;
                    case 2:  // поиск по категории
                        listBox2.DataSource = null;
                        listBox2.DataSource = db.SearchByCategory(textBoxSearch.Text);
                        break;
                    case 3:  // поиск по издательству
                        listBox2.DataSource = null;
                        listBox2.DataSource = db.SearchByPublish(textBoxSearch.Text);
                        break;
                }
            }
            
        }
    }
}
