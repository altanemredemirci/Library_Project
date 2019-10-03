using LibraryProject.Model.ORM.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.View.Shared.LoginView
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (db.AppUsers.Any(x=> x.UserName==txtUserName.Text && x.Password==txtPassword.Text && x.Status==Model.ORM.Enum.Status.Active && x.Role == Model.ORM.Enum.Role.Admin))
            {

            }
            else if (db.AppUsers.Any(x => x.UserName == txtUserName.Text && x.Password == txtPassword.Text && x.Status == Model.ORM.Enum.Status.Active && x.Role == Model.ORM.Enum.Role.Member))
            {

            }
        }
    }
}
