using LibraryProject.Model.ORM.Context;
using LibraryProject.Model.ORM.Entity;
using LibraryProject.Model.ORM.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.View.AdminArea.AppUserView
{
    public partial class AppUserPage : Form
    {
        public AppUserPage()
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

        public void AppUserTakeList()
        {
            dataGridView1.DataSource = db.AppUsers.Where(x => x.Status == Model.ORM.Enum.Status.Active).ToList();
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            AppUser user = new AppUser();
            user.FirstName = txtFirstNameAdd.Text;
            user.LastName = txtLastNameAdd.Text;
            user.Email = txtEmailAdd.Text;
            user.Password = txtPasswordAdd.Text;
            user.UserName = txtUserNameAdd.Text;
            user.Gender = (Gender)Enum.Parse(typeof(Gender), cmbUserAddGender.Text);
            user.Role = (Role)Enum.Parse(typeof(Role), cmbUserAddRole.Text);
            db.AppUsers.Add(user);
            db.SaveChanges();
            AppUserTakeList();
            TextBoxEraser();
        }
        public void EnumList()
        {
            cmbUserAddGender.Items.AddRange(Enum.GetNames(typeof(Gender)));
            cmbUserAddGender.SelectedIndex = 0;
            cmbUserAddRole.Items.AddRange(Enum.GetNames(typeof(Role)));
            cmbUserAddRole.SelectedIndex = 0;

            cmbGenderUpdate.Items.AddRange(Enum.GetNames(typeof(Gender)));
            cmbGenderUpdate.SelectedIndex = 0;
            cmbUpdateRole.Items.AddRange(Enum.GetNames(typeof(Role)));
            cmbUpdateRole.SelectedIndex = 0;
        }

        private void AppUserPage_Load(object sender, EventArgs e)
        {
            AppUserTakeList();
            EnumList();
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFirstNameUpdate.Text = dataGridView1.CurrentRow.Cells["FirstName"].Value.ToString();
            txtLastNameUpdate.Text = dataGridView1.CurrentRow.Cells["LastName"].Value.ToString();
            txtUserNameUpdate.Text = dataGridView1.CurrentRow.Cells["UserName"].Value.ToString();
            txtPasswordUpdate.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
            txtEmailUpdate.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            cmbGenderUpdate.Text = dataGridView1.CurrentRow.Cells["Gender"].Value.ToString();
            cmbUpdateRole.Text = dataGridView1.CurrentRow.Cells["Role"].Value.ToString();
            txtUserDelete.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
            id = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AppUser appuser = db.AppUsers.FirstOrDefault(x => x.ID == id);
            appuser.FirstName = txtFirstNameUpdate.Text;
            appuser.LastName = txtLastNameUpdate.Text;
            appuser.UserName = txtUserNameUpdate.Text;
            appuser.Email = txtEmailUpdate.Text;
            appuser.Password = txtPasswordUpdate.Text;
            appuser.Role = (Role)Enum.Parse(typeof(Role), cmbUpdateRole.Text);
            appuser.Gender = (Gender)Enum.Parse(typeof(Gender), cmbGenderUpdate.Text);
            db.SaveChanges();
            AppUserTakeList();
            TextBoxEraser();
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            AppUser appuser = db.AppUsers.FirstOrDefault(x => x.ID == id);
            appuser.Status = Model.ORM.Enum.Status.Delete;
            db.SaveChanges();
            AppUserTakeList();
            txtUserDelete.Clear();
            TextBoxEraser();
        }
    }
}
