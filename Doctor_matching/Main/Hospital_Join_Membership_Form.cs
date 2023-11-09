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
            MessageBox.Show("회원가입이 완료되었습니다!");
            this.Hide();
        }
    }
}
