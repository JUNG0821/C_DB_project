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
        public String id;
        public String pass;

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
            id = id_txt.Text;
            pass = pass_txt.Text;

            DBconn2 DB = new DBconn2();

            if (DB.hospital_login(id, pass))
                { 
                decimal PK = DB.get_hospital_pk(id, pass); 
                if(DB.confirm_hospital_pk(PK) == false)
                {
                    Hospital_Info_Save_Form hospital_info_save_form = new Hospital_Info_Save_Form(PK);
                    hospital_info_save_form.Show();
                    this.Close();
                }
                else
                {
                    Hospital_Main_Form hospital_Main_Form = new Hospital_Main_Form(PK);
                    hospital_Main_Form.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호를 확인해주세요.");
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Slect_Login_Form slect_login_form = new Slect_Login_Form();
            slect_login_form.Show();
            this.Hide();
        }
    }
}
