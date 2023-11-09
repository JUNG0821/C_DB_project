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
    public partial class Patient_Login_Form : Form
    {
        public Patient_Login_Form()
        {
            InitializeComponent();
        }

        private void join_membership_btn_Click(object sender, EventArgs e)
        {
            Patient_Join_Membership_Form patient_join_membership_form = new Patient_Join_Membership_Form();
            patient_join_membership_form.ShowDialog();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            //if문으로 환자에 대한 정보가 없으면 이 Patient_Login_Form을 띄우고 있다면 바로 접속
            Patient_Info_Save_Form Patient_lnfo_Save_Form = new Patient_Info_Save_Form();
            Slect_Login_Form select_login_form = new Slect_Login_Form();
            Patient_lnfo_Save_Form.Show();
            this.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Slect_Login_Form slect_login_form = new Slect_Login_Form();
            slect_login_form.Show();
            this.Close();
        }
    }
}
