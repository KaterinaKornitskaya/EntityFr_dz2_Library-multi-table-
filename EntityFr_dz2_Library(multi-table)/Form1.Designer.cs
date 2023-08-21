namespace EntityFr_dz2_Library_multi_table_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonEditBook = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxBookAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBookPublish = new System.Windows.Forms.TextBox();
            this.textBoxBookCat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddAuthorFName = new System.Windows.Forms.TextBox();
            this.textBoxAddAuthLName = new System.Windows.Forms.TextBox();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAddCat = new System.Windows.Forms.Button();
            this.textBoxAddCat = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAddPubl = new System.Windows.Forms.Button();
            this.textBoxAddPubl = new System.Windows.Forms.TextBox();
            this.buttonShowBooks = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(10, 182);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(121, 23);
            this.buttonAddBook.TabIndex = 33;
            this.buttonAddBook.Text = "Добавить книгу";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(399, 3);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(125, 23);
            this.buttonDeleteBook.TabIndex = 32;
            this.buttonDeleteBook.Text = "Удалить";
            this.buttonDeleteBook.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonEditBook
            // 
            this.buttonEditBook.Location = new System.Drawing.Point(268, 3);
            this.buttonEditBook.Name = "buttonEditBook";
            this.buttonEditBook.Size = new System.Drawing.Size(125, 23);
            this.buttonEditBook.TabIndex = 30;
            this.buttonEditBook.Text = "Редактировать";
            this.buttonEditBook.UseVisualStyleBackColor = true;
            this.buttonEditBook.Click += new System.EventHandler(this.buttonEditBook_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(137, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(385, 173);
            this.listBox1.TabIndex = 29;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBoxBookAuthor
            // 
            this.textBoxBookAuthor.Location = new System.Drawing.Point(11, 75);
            this.textBoxBookAuthor.Name = "textBoxBookAuthor";
            this.textBoxBookAuthor.Size = new System.Drawing.Size(120, 20);
            this.textBoxBookAuthor.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Автор";
            // 
            // textBoxBookPublish
            // 
            this.textBoxBookPublish.Location = new System.Drawing.Point(11, 153);
            this.textBoxBookPublish.Name = "textBoxBookPublish";
            this.textBoxBookPublish.Size = new System.Drawing.Size(120, 20);
            this.textBoxBookPublish.TabIndex = 24;
            // 
            // textBoxBookCat
            // 
            this.textBoxBookCat.Location = new System.Drawing.Point(11, 114);
            this.textBoxBookCat.Name = "textBoxBookCat";
            this.textBoxBookCat.Size = new System.Drawing.Size(120, 20);
            this.textBoxBookCat.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Издательство";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Категория";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Location = new System.Drawing.Point(12, 32);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(119, 20);
            this.textBoxBookName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Название книги";
            // 
            // textBoxAddAuthorFName
            // 
            this.textBoxAddAuthorFName.Location = new System.Drawing.Point(587, 26);
            this.textBoxAddAuthorFName.Name = "textBoxAddAuthorFName";
            this.textBoxAddAuthorFName.Size = new System.Drawing.Size(149, 20);
            this.textBoxAddAuthorFName.TabIndex = 38;
            // 
            // textBoxAddAuthLName
            // 
            this.textBoxAddAuthLName.Location = new System.Drawing.Point(587, 52);
            this.textBoxAddAuthLName.Name = "textBoxAddAuthLName";
            this.textBoxAddAuthLName.Size = new System.Drawing.Size(149, 20);
            this.textBoxAddAuthLName.TabIndex = 39;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(12, 69);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(149, 23);
            this.buttonAddAuthor.TabIndex = 40;
            this.buttonAddAuthor.Text = "Добавить автора";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddAuthor);
            this.groupBox1.Location = new System.Drawing.Point(575, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 106);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление автора";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddCat);
            this.groupBox2.Controls.Add(this.textBoxAddCat);
            this.groupBox2.Location = new System.Drawing.Point(575, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 75);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление категории";
            // 
            // buttonAddCat
            // 
            this.buttonAddCat.Location = new System.Drawing.Point(12, 45);
            this.buttonAddCat.Name = "buttonAddCat";
            this.buttonAddCat.Size = new System.Drawing.Size(149, 23);
            this.buttonAddCat.TabIndex = 44;
            this.buttonAddCat.Text = "Добавить категорию";
            this.buttonAddCat.UseVisualStyleBackColor = true;
            this.buttonAddCat.Click += new System.EventHandler(this.buttonAddCat_Click);
            // 
            // textBoxAddCat
            // 
            this.textBoxAddCat.Location = new System.Drawing.Point(12, 19);
            this.textBoxAddCat.Name = "textBoxAddCat";
            this.textBoxAddCat.Size = new System.Drawing.Size(149, 20);
            this.textBoxAddCat.TabIndex = 39;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAddPubl);
            this.groupBox3.Controls.Add(this.textBoxAddPubl);
            this.groupBox3.Location = new System.Drawing.Point(575, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 81);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавление издательства";
            // 
            // buttonAddPubl
            // 
            this.buttonAddPubl.Location = new System.Drawing.Point(12, 45);
            this.buttonAddPubl.Name = "buttonAddPubl";
            this.buttonAddPubl.Size = new System.Drawing.Size(149, 23);
            this.buttonAddPubl.TabIndex = 45;
            this.buttonAddPubl.Text = "Добавить издательство";
            this.buttonAddPubl.UseVisualStyleBackColor = true;
            this.buttonAddPubl.Click += new System.EventHandler(this.buttonAddPubl_Click);
            // 
            // textBoxAddPubl
            // 
            this.textBoxAddPubl.Location = new System.Drawing.Point(12, 19);
            this.textBoxAddPubl.Name = "textBoxAddPubl";
            this.textBoxAddPubl.Size = new System.Drawing.Size(149, 20);
            this.textBoxAddPubl.TabIndex = 45;
            // 
            // buttonShowBooks
            // 
            this.buttonShowBooks.Location = new System.Drawing.Point(137, 3);
            this.buttonShowBooks.Name = "buttonShowBooks";
            this.buttonShowBooks.Size = new System.Drawing.Size(125, 23);
            this.buttonShowBooks.TabIndex = 44;
            this.buttonShowBooks.Text = "Показать все книги";
            this.buttonShowBooks.UseVisualStyleBackColor = true;
            this.buttonShowBooks.Click += new System.EventHandler(this.buttonShowBooks_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "По фамилии автора",
            "По названию",
            "По категории",
            "По издательству"});
            this.comboBox1.Location = new System.Drawing.Point(10, 270);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 45;
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.Location = new System.Drawing.Point(10, 368);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(121, 23);
            this.buttonSearchBook.TabIndex = 46;
            this.buttonSearchBook.Text = "Найти";
            this.buttonSearchBook.UseVisualStyleBackColor = true;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.Location = new System.Drawing.Point(137, 244);
            this.listBox2.Name = "listBox2";
            this.listBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox2.Size = new System.Drawing.Size(385, 147);
            this.listBox2.TabIndex = 47;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(10, 334);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(121, 20);
            this.textBoxSearch.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Данные для поиска";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Поиск книг";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 431);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonSearchBook);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonShowBooks);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxAddAuthLName);
            this.Controls.Add(this.textBoxAddAuthorFName);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonEditBook);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxBookAuthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBookPublish);
            this.Controls.Add(this.textBoxBookCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonEditBook;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxBookAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBookPublish;
        private System.Windows.Forms.TextBox textBoxBookCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddAuthorFName;
        private System.Windows.Forms.TextBox textBoxAddAuthLName;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAddCat;
        private System.Windows.Forms.TextBox textBoxAddCat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAddPubl;
        private System.Windows.Forms.TextBox textBoxAddPubl;
        private System.Windows.Forms.Button buttonShowBooks;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

