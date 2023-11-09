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
    public partial class Coment_Write_Form : Form
    {
        public Coment_Write_Form()
        {
            InitializeComponent();
        }

        private void Coment_Write_Form_Load(object sender, EventArgs e)
        {

        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("댓글이 작성되었습니다!");
            this.Hide();
        }
    }
}
