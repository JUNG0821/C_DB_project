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
    public partial class Hospital_Join_Membership_Form : Form
    {
        public Hospital_Join_Membership_Form()
        {
            InitializeComponent();
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            String id = id_txt.Text;
            String pass = pass_txt.Text;
            String passconfirm = check_pass_txt.Text;
            DBconn2 hospital = new DBconn2();

            // 중복 확인과 회원가입을 동시에 처리
            if (pass == passconfirm && hospital.hospital_join_membership(id, pass))
            {
                MessageBox.Show("회원가입이 완료되었습니다!");
                Hospital_Login_Form hospital_login = new Hospital_Login_Form();
                hospital_login.Show();
                this.Close();
            }
            else if (pass != passconfirm)
            {
                MessageBox.Show("비밀번호를 확인해주세요.");
            }
            else
            {
                MessageBox.Show("아이디가 중복됩니다. 다시 입력해주세요.");
            }
        }

    }
}
