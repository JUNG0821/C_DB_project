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
    public partial class Search_Hospital_Form : Form
    {
        public Search_Hospital_Form()
        {
            InitializeComponent();
        }

        private void Search_Hospital_Form_Load(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            Patient_Hospital_Info_Form patient_hospital_info_form = new Patient_Hospital_Info_Form();
            patient_hospital_info_form.Show();
            this.Hide();
        }
    }
}
