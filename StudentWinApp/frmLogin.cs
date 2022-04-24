using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.DAO;
using DataAccess.Repository;

namespace StudentWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            MemberObject login = memberRepository.LoginMember(Email, Password);
            if(login != null)
            {
                
                
                frmMain main = new frmMain {
                    Text = "Add Member",
                    MemberRepository = memberRepository,
                    Admin = Email,
                    Role = login.isTeacher
            };                 
                    main.Show();
                    this.Hide();
            }
            else
            {
                MessageBox.Show("sai tk or mk");
            }
    
           
        }

        private void EnterKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
