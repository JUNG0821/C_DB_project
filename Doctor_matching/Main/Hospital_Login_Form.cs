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
    public partial class Hospital_Login_Form : Form
    {
        public Hospital_Login_Form()
        {
            InitializeComponent();
        }

        private void join_membership_btn_Click(object sender, EventArgs e)
        {
            Hospital_Join_Membership_Form hospital_join_membership_form = new Hospital_Join_Membership_Form();
            hospital_join_membership_form.ShowDialog();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {   
            //로그인을 처음 할 시에 띄어줌
            Hospital_Info_Save_Form hospital_info_save_form = new Hospital_Info_Save_Form();
            hospital_info_save_form.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Slect_Login_Form slect_login_form = new Slect_Login_Form();
            slect_login_form.Show();
            this.Hide();
        }
    }
}
