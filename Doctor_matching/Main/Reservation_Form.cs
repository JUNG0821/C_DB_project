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
    public partial class Reservation_Form : Form
    {
        public Reservation_Form()
        {
            InitializeComponent();
        }

        private void reservation_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("예약하셨습니다");
            this.Hide();

        }
    }
}
