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
    public partial class Hospital_Regist_Doctor : Form
    {
        private decimal PK;
        public Hospital_Regist_Doctor(decimal PK)
        {
            InitializeComponent();
            this.PK = PK;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Hospital_Main_Form hospital_main_form = new Hospital_Main_Form(PK);
            hospital_main_form.Show();
            this.Hide();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            DBconn2 DB = new DBconn2();
            String name = name_txt.Text;
            String career = career_txt.Text;
            int phone = int.Parse(phone_num_txt.Text);
            String email = email_txt.Text;
            String department = department_combo.Text.ToString();
            String significant = significant_txt.Text;

            decimal doctor_pk = DB.get_doctor_pk(name, email);

            DB.doctor_save_info(doctor_pk, name, career, phone, email, department, significant, 0, PK);


            MessageBox.Show("의사가 등록되었습니다!");
            this.Hide();

        }
    }
}
