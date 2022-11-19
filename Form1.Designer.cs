namespace DB_Lab_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Search_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.FindAll_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = new System.Windows.Forms.ColumnHeader();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Author = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Search_button);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.Delete_button);
            this.splitContainer1.Panel1.Controls.Add(this.Edit_button);
            this.splitContainer1.Panel1.Controls.Add(this.Add_button);
            this.splitContainer1.Panel1.Controls.Add(this.FindAll_button);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(790, 441);
            this.splitContainer1.SplitterDistance = 54;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // Search_button
            // 
            this.Search_button.Location = new System.Drawing.Point(486, 12);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(75, 32);
            this.Search_button.TabIndex = 5;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(567, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 27);
            this.textBox1.TabIndex = 4;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(255, 12);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 32);
            this.Delete_button.TabIndex = 3;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(174, 12);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(75, 32);
            this.Edit_button.TabIndex = 2;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(93, 12);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 32);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // FindAll_button
            // 
            this.FindAll_button.Location = new System.Drawing.Point(12, 12);
            this.FindAll_button.Name = "FindAll_button";
            this.FindAll_button.Size = new System.Drawing.Size(75, 32);
            this.FindAll_button.TabIndex = 0;
            this.FindAll_button.Text = "FindAll";
            this.FindAll_button.UseVisualStyleBackColor = true;
            this.FindAll_button.Click += new System.EventHandler(this.FindAll_button_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Title,
            this.Author});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(790, 382);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Title
            // 
            this.Title.Text = "Name";
            // 
            // Author
            // 
            this.Author.Text = "Author";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 441);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button Search_button;
        private TextBox textBox1;
        private Button Delete_button;
        private Button Edit_button;
        private Button Add_button;
        private Button FindAll_button;
        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader Title;
        private ColumnHeader Author;
    }
}