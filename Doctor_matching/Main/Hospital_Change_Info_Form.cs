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
    public partial class Hospital_Change_Info_Form : Form
    {
        public Hospital_Change_Info_Form()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("변경이 완료되었습니다.");
            Hospital_Main_Form hospital_main_form = new Hospital_Main_Form();
            hospital_main_form.Show();
            this.Hide();

        }

        private void have_department_btn_Click(object sender, EventArgs e)
        {
            Hospital_Change_Department_Form hospital_change_department_form = new Hospital_Change_Department_Form();
            hospital_change_department_form.ShowDialog();
           
        }

        private void have_sickbed_btn_Click(object sender, EventArgs e)
        {
            Hospital_Change_Sickbed_Form hospital_change_sickbed_form = new Hospital_Change_Sickbed_Form();
            hospital_change_sickbed_form.ShowDialog();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Hospital_Main_Form hospital_main_form = new Hospital_Main_Form();
            hospital_main_form.Show();
            this.Hide();
        }

        private void Hospital_Change_Info_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
