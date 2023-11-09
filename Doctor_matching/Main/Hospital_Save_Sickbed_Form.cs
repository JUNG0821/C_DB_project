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
    public partial class Hospital_Save_Sickbed_Form : Form
    {
        public Hospital_Save_Sickbed_Form()
        {
            InitializeComponent();
        }

        private void Hospital_Save_Sickbed_Form_Load(object sender, EventArgs e)
        {

        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("병상 설정이 완료되었습니다.");
            this.Hide();
        }
    }
}
