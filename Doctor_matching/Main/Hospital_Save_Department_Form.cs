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
    public partial class Hospital_Save_Department_Form : Form
    {
        public Hospital_Save_Department_Form()
        {
            InitializeComponent();
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("진료과 설정을 완료했습니다.");
            this.Hide();
        }

        private void Hospital_Save_Department_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
