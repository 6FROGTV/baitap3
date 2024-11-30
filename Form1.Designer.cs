namespace Bt3
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Ly", "Thi Bong", "23456" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Nguyen", "Van Chinh", "4555" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Tran", "Chanh Truc", "123456" }, -1);
            ListViewItem listViewItem4 = new ListViewItem("");
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtLastname = new TextBox();
            txtPhone = new TextBox();
            txtFirstname = new TextBox();
            btnAddname = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.GridLines = true;
            listViewItem1.IndentCount = 1;
            listViewItem2.Tag = "";
            listViewItem4.IndentCount = 1;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            listView1.Location = new Point(12, 111);
            listView1.Name = "listView1";
            listView1.Size = new Size(454, 317);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "LastName";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "FirstName";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Phone";
            columnHeader3.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 1;
            label1.Text = "Detail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(529, 206);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(531, 282);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 3;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-3, -2);
            label4.Name = "label4";
            label4.Size = new Size(38, 25);
            label4.TabIndex = 4;
            label4.Text = "File";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, -2);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 5;
            label5.Text = "View";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(174, -2);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 6;
            label6.Text = "Format";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(531, 121);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 7;
            label7.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(265, -2);
            label8.Name = "label8";
            label8.Size = new Size(75, 25);
            label8.TabIndex = 8;
            label8.Text = "ListView";
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(531, 162);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(202, 31);
            txtLastname.TabIndex = 9;
            txtLastname.TextChanged += txtLastname_TextChanged;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(529, 331);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(202, 31);
            txtPhone.TabIndex = 10;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(529, 234);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(202, 31);
            txtFirstname.TabIndex = 11;
            txtFirstname.TextChanged += txtFirstname_TextChanged;
            // 
            // btnAddname
            // 
            btnAddname.Location = new Point(624, 394);
            btnAddname.Name = "btnAddname";
            btnAddname.Size = new Size(112, 34);
            btnAddname.TabIndex = 12;
            btnAddname.Text = "Add Name";
            btnAddname.UseVisualStyleBackColor = true;
            btnAddname.Click += btnAddname_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddname);
            Controls.Add(txtFirstname);
            Controls.Add(txtPhone);
            Controls.Add(txtLastname);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "List View Demo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtLastname;
        private TextBox txtPhone;
        private TextBox txtFirstname;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnAddname;
    }
}
