namespace LibraryProject.View.AdminArea.BookView
{
    partial class BookPage
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBookDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txBookDelete = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbBookAuthorUpdate = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBookCategoriesUpdate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBookUpdate = new System.Windows.Forms.Button();
            this.txtBookDescriptionUpdate = new System.Windows.Forms.TextBox();
            this.txtBookNameUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBookAddAuthor = new System.Windows.Forms.ComboBox();
            this.cmbBookCategoriesAdd = new System.Windows.Forms.ComboBox();
            this.btnBookAdd = new System.Windows.Forms.Button();
            this.txtBookDescriptionAdd = new System.Windows.Forms.TextBox();
            this.txtBookNameAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBookDelete);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txBookDelete);
            this.groupBox4.Location = new System.Drawing.Point(527, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 56);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Book Delete";
            // 
            // btnBookDelete
            // 
            this.btnBookDelete.Location = new System.Drawing.Point(155, 19);
            this.btnBookDelete.Name = "btnBookDelete";
            this.btnBookDelete.Size = new System.Drawing.Size(48, 23);
            this.btnBookDelete.TabIndex = 5;
            this.btnBookDelete.Text = "Submit";
            this.btnBookDelete.UseVisualStyleBackColor = true;
            this.btnBookDelete.Click += new System.EventHandler(this.btnBookDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Book ID:";
            // 
            // txBookDelete
            // 
            this.txBookDelete.Location = new System.Drawing.Point(61, 21);
            this.txBookDelete.Name = "txBookDelete";
            this.txBookDelete.Size = new System.Drawing.Size(88, 20);
            this.txBookDelete.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbBookAuthorUpdate);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmbBookCategoriesUpdate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnBookUpdate);
            this.groupBox3.Controls.Add(this.txtBookDescriptionUpdate);
            this.groupBox3.Controls.Add(this.txtBookNameUpdate);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(267, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 240);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Book Update";
            // 
            // cmbBookAuthorUpdate
            // 
            this.cmbBookAuthorUpdate.FormattingEnabled = true;
            this.cmbBookAuthorUpdate.Location = new System.Drawing.Point(86, 160);
            this.cmbBookAuthorUpdate.Name = "cmbBookAuthorUpdate";
            this.cmbBookAuthorUpdate.Size = new System.Drawing.Size(149, 21);
            this.cmbBookAuthorUpdate.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Author:";
            // 
            // cmbBookCategoriesUpdate
            // 
            this.cmbBookCategoriesUpdate.FormattingEnabled = true;
            this.cmbBookCategoriesUpdate.Location = new System.Drawing.Point(86, 127);
            this.cmbBookCategoriesUpdate.Name = "cmbBookCategoriesUpdate";
            this.cmbBookCategoriesUpdate.Size = new System.Drawing.Size(149, 21);
            this.cmbBookCategoriesUpdate.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Categories";
            // 
            // btnBookUpdate
            // 
            this.btnBookUpdate.Location = new System.Drawing.Point(160, 198);
            this.btnBookUpdate.Name = "btnBookUpdate";
            this.btnBookUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnBookUpdate.TabIndex = 8;
            this.btnBookUpdate.Text = "Submit";
            this.btnBookUpdate.UseVisualStyleBackColor = true;
            // 
            // txtBookDescriptionUpdate
            // 
            this.txtBookDescriptionUpdate.Location = new System.Drawing.Point(86, 48);
            this.txtBookDescriptionUpdate.Multiline = true;
            this.txtBookDescriptionUpdate.Name = "txtBookDescriptionUpdate";
            this.txtBookDescriptionUpdate.Size = new System.Drawing.Size(149, 66);
            this.txtBookDescriptionUpdate.TabIndex = 6;
            // 
            // txtBookNameUpdate
            // 
            this.txtBookNameUpdate.Location = new System.Drawing.Point(86, 18);
            this.txtBookNameUpdate.Name = "txtBookNameUpdate";
            this.txtBookNameUpdate.Size = new System.Drawing.Size(149, 20);
            this.txtBookNameUpdate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 274);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbBookAddAuthor);
            this.groupBox1.Controls.Add(this.cmbBookCategoriesAdd);
            this.groupBox1.Controls.Add(this.btnBookAdd);
            this.groupBox1.Controls.Add(this.txtBookDescriptionAdd);
            this.groupBox1.Controls.Add(this.txtBookNameAdd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 240);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Add";
            // 
            // cmbBookAddAuthor
            // 
            this.cmbBookAddAuthor.FormattingEnabled = true;
            this.cmbBookAddAuthor.Location = new System.Drawing.Point(84, 160);
            this.cmbBookAddAuthor.Name = "cmbBookAddAuthor";
            this.cmbBookAddAuthor.Size = new System.Drawing.Size(149, 21);
            this.cmbBookAddAuthor.TabIndex = 12;
            // 
            // cmbBookCategoriesAdd
            // 
            this.cmbBookCategoriesAdd.FormattingEnabled = true;
            this.cmbBookCategoriesAdd.Location = new System.Drawing.Point(84, 127);
            this.cmbBookCategoriesAdd.Name = "cmbBookCategoriesAdd";
            this.cmbBookCategoriesAdd.Size = new System.Drawing.Size(149, 21);
            this.cmbBookCategoriesAdd.TabIndex = 12;
            // 
            // btnBookAdd
            // 
            this.btnBookAdd.Location = new System.Drawing.Point(158, 198);
            this.btnBookAdd.Name = "btnBookAdd";
            this.btnBookAdd.Size = new System.Drawing.Size(75, 23);
            this.btnBookAdd.TabIndex = 3;
            this.btnBookAdd.Text = "Submit";
            this.btnBookAdd.UseVisualStyleBackColor = true;
            this.btnBookAdd.Click += new System.EventHandler(this.btnBookAdd_Click);
            // 
            // txtBookDescriptionAdd
            // 
            this.txtBookDescriptionAdd.Location = new System.Drawing.Point(84, 52);
            this.txtBookDescriptionAdd.Multiline = true;
            this.txtBookDescriptionAdd.Name = "txtBookDescriptionAdd";
            this.txtBookDescriptionAdd.Size = new System.Drawing.Size(149, 66);
            this.txtBookDescriptionAdd.TabIndex = 2;
            // 
            // txtBookNameAdd
            // 
            this.txtBookNameAdd.Location = new System.Drawing.Point(84, 22);
            this.txtBookNameAdd.Name = "txtBookNameAdd";
            this.txtBookNameAdd.Size = new System.Drawing.Size(149, 20);
            this.txtBookNameAdd.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Author:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Categories:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // BookPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookPage";
            this.Text = "BookPage";
            this.Load += new System.EventHandler(this.BookPage_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBookDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txBookDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBookUpdate;
        private System.Windows.Forms.TextBox txtBookDescriptionUpdate;
        private System.Windows.Forms.TextBox txtBookNameUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBookAdd;
        private System.Windows.Forms.TextBox txtBookDescriptionAdd;
        private System.Windows.Forms.TextBox txtBookNameAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBookCategoriesUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBookCategoriesAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBookAddAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBookAuthorUpdate;
        private System.Windows.Forms.Label label9;
    }
}