using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWinApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin f = new frmLogin();
            f.Show();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "frmInformation")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                frmInformation inf = new frmInformation();
                inf.MdiParent = this;
                inf.Show();
            }
        }

        private void memberListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "frmMemberManagement")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                frmMemberManagement m = new frmMemberManagement();
                m.MdiParent = this;
                m.Show();
            }
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "frmClassManagement")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                frmClassManagement c = new frmClassManagement();
                c.MdiParent = this;
                c.Show();
            }
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "frmSubjectManagement")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                frmSubjectManagement s = new frmSubjectManagement();
                s.MdiParent = this;
                s.Show();
            }
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "frmSubjectInTeacher")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                frmSubjectInTeacher c = new frmSubjectInTeacher();
                c.MdiParent = this;
                c.Show();
            }
        }

        private void subjectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "frmSubjectInTeacher")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                frmSubjectInClass c = new frmSubjectInClass();
                c.MdiParent = this;
                c.Show();
            }
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "frmSubjectInTeacher")
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                frmMemberInClass c = new frmMemberInClass();
                c.MdiParent = this;
                c.Show();
            }
        }
    }
}
