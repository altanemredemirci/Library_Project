using LibraryProject.Model.ORM.Context;
using LibraryProject.Model.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.View.AdminArea.CategoryView
{
    public partial class CategoryPage : Form
    {
        public CategoryPage()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();

        public void TextBoxEraser()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox3.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in groupBox4.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        public void CategoryTakeList()
        {
            dataGridView1.DataSource = db.Categories.Where(x => x.Status == Model.ORM.Enum.Status.Active).ToList();
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName = txtCategoryAdd.Text;
            category.CategoryDescription = txtCategoryDescription.Text;
            db.Categories.Add(category);
            db.SaveChanges();

            CategoryTakeList();
            TextBoxEraser();
        }

        private void CategoryPage_Load(object sender, EventArgs e)
        {
            CategoryTakeList();
        }

        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryUpdateName.Text = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
            txtCategoryUpdateDescription.Text = dataGridView1.CurrentRow.Cells["CategoryDescription"].Value.ToString();
            id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            txtCategoryDelete.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            Category category = db.Categories.FirstOrDefault(x => x.ID == id);
            category.CategoryName = txtCategoryUpdateName.Text;
            category.CategoryDescription = txtCategoryUpdateDescription.Text;
            db.SaveChanges();
            CategoryTakeList();
            TextBoxEraser();
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            Category category = db.Categories.FirstOrDefault(x => x.ID == id);
            category.Status = Model.ORM.Enum.Status.Delete;
            db.SaveChanges();
            CategoryTakeList();
            TextBoxEraser();
        }
    }
}
