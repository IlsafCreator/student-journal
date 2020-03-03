using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentJournal
{
    public partial class FormStudent : Form
    {
        public string fname;
        public string lname;
        public string pname;

        public string bday;
        public string link;
        public string phone;
        public string group;

        bool modeDelete = false;

        public FormStudent()
        {
            InitializeComponent();

            if (modeDelete)
            {
                this.Text += " - Удалить студента";
            } 
            else
            {
                this.Text += " - Новый студент";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fname = txtFisrstName.Text;
            lname = txtLastName.Text;
            pname = txtParentName.Text;

            bday = txtBDay.Text;
            link = txtLink.Text;
            phone = txtPhone.Text;
            group = cmbGroup.Text;
        }
    }
}
