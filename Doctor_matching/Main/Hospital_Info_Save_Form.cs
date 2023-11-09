using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Hospital_Info_Save_Form : Form
    {
        public Hospital_Info_Save_Form()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
        }

        private void Hospital_Info_Save_Form_Load(object sender, EventArgs e)
        {

        }

        private void have_department_btn_Click(object sender, EventArgs e)
        {
            Hospital_Save_Department_Form hospital_save_department_form = new Hospital_Save_Department_Form();
            hospital_save_department_form.ShowDialog();
            
        }

        private void have_sickbed_btn_Click(object sender, EventArgs e)
        {
            Hospital_Save_Sickbed_Form hospital_save_sickbed_form = new Hospital_Save_Sickbed_Form();
            hospital_save_sickbed_form.ShowDialog();
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            Hospital_Main_Form hospital_main_form = new Hospital_Main_Form();
            hospital_main_form.Show();
            this.Hide();
        }
    }
}
