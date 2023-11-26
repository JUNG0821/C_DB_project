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
    public partial class Patient_Main_Form : Form
    {
        public Patient_Main_Form()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
        }

        private void Patient_Main_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void matching_btn_Click(object sender, EventArgs e)
        {
            Maching_Result_Form maching_result_form = new Maching_Result_Form();
            maching_result_form.Show();
            this.Hide();

        }

        private void favorites_btn_Click(object sender, EventArgs e)
        {
            Patient_Favorites_Form patient_favorites_Form = new Patient_Favorites_Form();
            patient_favorites_Form.Show();
            this.Hide();
        }

        private void reservation_inquiry_btn_Click(object sender, EventArgs e)
        {
            Patient_Reservation_Inquiry_Form patient_reservation_inquiry_form = new Patient_Reservation_Inquiry_Form();
            patient_reservation_inquiry_form.Show();
            this.Hide();
;        }

        private void change_info_btn_Click(object sender, EventArgs e)
        {
            Patient_Change_Info_Form patient_change_info_form = new Patient_Change_Info_Form();
            patient_change_info_form.Show();
            this.Hide();
        }

        private void search_hospital_btn_Click(object sender, EventArgs e)
        {
            Search_Hospital_Form search_hospital_form = new Search_Hospital_Form();
            search_hospital_form.Show();

        }

        private void department_explain_btn_Click(object sender, EventArgs e)
        {
            Department_Explain department_explain = new Department_Explain();
            department_explain.Show();
        }

        private void sickbed_explain_btn_Click(object sender, EventArgs e)
        {
            Sickbed_Explain sickbed_explain = new Sickbed_Explain();
            sickbed_explain.Show();
        }

        private void explain_btn_Click(object sender, EventArgs e)
        {
            Manual manual = new Manual();
            manual.Show();
        }
    }
}
