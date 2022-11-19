using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Windows.Forms;

namespace DB_Lab_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
            Update_LV();
        }

        public void Update_LV()
        {
            listView1.Items.Clear();

            using (Context db = new Context())
            {
                

                foreach (var book in db.Books)
                {
                    ListViewItem listViewItem = new ListViewItem(book.Id.ToString());
                    listViewItem.SubItems.Add(book.Name);
                    listViewItem.SubItems.Add(book.AuthorId.ToString());
                    listView1.Items.Add(listViewItem);
                }

                foreach(ListViewItem item in listView1.Items)
                {
                    var authors = from author in db.Author where author.Id == Convert.ToInt32(item.SubItems[2].Text) select author;
                    item.SubItems[2].Text = authors.First().Name; 
                
                }
                
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

       
        private void Add_button_Click(object sender, EventArgs e)
        {
            Form2 add_form = new Form2();
            this.Hide();
            add_form.ShowDialog();
            this.Close();
        }

        private void FindAll_button_Click(object sender, EventArgs e)
        {
            Update_LV();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select row to delete!");
                return;
            }

            string id = listView1.SelectedItems[0].Text;

            if (DialogResult.Yes == MessageBox.Show("Delete " + listView1.SelectedItems[0].SubItems[1].Text + " ?", "F", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                try
                {
                    using (Context db = new Context())
                    {
                        var books = from book in db.Books where book.Id == Convert.ToInt32(id) select book;

                        db.Books.Remove(books.First());
                        db.SaveChanges();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Update_LV();
            }


        }
        public static string id = null;
        private void Edit_button_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select row to edit!");
                return;
            }

            id = listView1.SelectedItems[0].Text;
            Form2 add_form = new Form2();
            this.Hide();
            add_form.ShowDialog();
            this.Close();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
           
            using (Context db = new Context())
            {

                var books = db.Books.Where(a => a.Name == textBox1.Text);

                if (!books.IsNullOrEmpty())
                {
                    listView1.Items.Clear();
                    foreach (var book in books)
                    {
                        ListViewItem listViewItem = new ListViewItem(book.Id.ToString());
                        listViewItem.SubItems.Add(book.Name);
                        listViewItem.SubItems.Add(book.AuthorId.ToString());
                        listView1.Items.Add(listViewItem);
                    }

                    foreach (ListViewItem item in listView1.Items)
                    {
                        var authors = from author in db.Author where author.Id == Convert.ToInt32(item.SubItems[2].Text) select author;
                        item.SubItems[2].Text = authors.First().Name;

                    }
                    listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                else
                {
                    MessageBox.Show("Nothing found");
                }
                

            }

          

        }
    }

   

}