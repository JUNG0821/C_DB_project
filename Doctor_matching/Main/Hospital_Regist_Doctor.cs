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
        public Hospital_Regist_Doctor()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Hospital_Main_Form hospital_main_form = new Hospital_Main_Form();
            hospital_main_form.Show();
            this.Hide();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("의사가 등록되었습니다!");
            this.Hide();

        }
    }
}
