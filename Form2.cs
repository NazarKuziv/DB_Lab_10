using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DB_Lab_10
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string id = null;
        private void Form2_Load(object sender, EventArgs e)
        {
            id = Form1.id;

            Update_Combo_Box();

            if (id != null)
            {
                using (Context db = new Context())
                {
                    var books = from book in db.Books where book.Id == Convert.ToInt32(id) select book;
                    textBox1.Text = books.First().Name;

                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        string[] author = comboBox1.Items[i].ToString().Split('-');
                        string author_id = author[0];

                        if (author_id == books.First().AuthorId.ToString())
                        {
                            comboBox1.SelectedIndex = i;
                            break;
                        }
                    }

                }
            }

        }

        public void Update_Combo_Box()
        {
            comboBox1.Items.Clear();
            using (Context db = new Context())
            {
                foreach(var author in db.Author)
                {
                    comboBox1.Items.Add(author.Id.ToString() + "-" + author.Name);
                }

            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Form1 books_form = new Form1();
            this.Hide();
            books_form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message, title;
            string author; 

            message = "Author Name";
            title = "Add Author";

            author = Interaction.InputBox(message, title);

            if (author == "")
                return;

            using (Context db = new Context())
            {
                Author NewAuthor = new Author();
                NewAuthor.Name = author;
               
                db.Author.Add(NewAuthor);
                db.SaveChanges();

            }

            Update_Combo_Box();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Title!");
                return;
            }

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Choose Author!");
                return;
            }

            if(id == null)
            {
                using (Context db = new Context())
                {
                    Book book = new Book();
                    book.Name = textBox1.Text;

                    string[] a = comboBox1.Text.Split("-");
                    book.AuthorId = Convert.ToInt32(a[0]);

                    db.Books.Add(book);
                    db.SaveChanges();
                }

                this.Close();
            }
            else
            {
                using (Context db = new Context())
                {
                   

                    var book = db.Books.Where(a => a.Id == Convert.ToInt32(id)).First();
                    
                    book.Name = textBox1.Text;
                    string[] a = comboBox1.Text.Split("-");
                    book.AuthorId = Convert.ToInt32(a[0]);
                    
                    db.SaveChanges();
                }

                this.Close();
            }
            
        }
    }
}
