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
    public partial class Patient_Hospital_Info_Form : Form
    {
        public Patient_Hospital_Info_Form()
        {
            InitializeComponent();

            hospital_department_view.Rows.Add();
            hospital_department_view.Rows[0].Cells[0].Value = "가정의학과";
            hospital_department_view.Rows[0].Cells[1].Value = "보기";

            hospital_department_view.Rows.Add();
            hospital_department_view.Rows[1].Cells[0].Value = "내과";
            hospital_department_view.Rows[1].Cells[1].Value = "보기";

            hospital_department_view.Rows.Add();
            hospital_department_view.Rows[2].Cells[0].Value = "마취통증학과";
            hospital_department_view.Rows[2].Cells[1].Value = "보기";

            hospital_department_view.Rows.Add();
            hospital_department_view.Rows[3].Cells[0].Value = "산부인과";
            hospital_department_view.Rows[3].Cells[1].Value = "보기";

            hospital_department_view.Rows.Add();
            hospital_department_view.Rows[4].Cells[0].Value = "소아청소년과";
            hospital_department_view.Rows[4].Cells[1].Value = "보기";

            hospital_department_view.Rows.Add();
            hospital_department_view.Rows[5].Cells[0].Value = "신경과";
            hospital_department_view.Rows[5].Cells[1].Value = "보기";

            hospital_department_view.Rows.Add();
            hospital_department_view.Rows[6].Cells[0].Value = "신경외과";
            hospital_department_view.Rows[6].Cells[1].Value = "보기";


            hospital_sickbed_view.Rows.Add();
            hospital_sickbed_view.Rows[0].Cells[0].Value = "일반병실";
            hospital_sickbed_view.Rows[0].Cells[1].Value = "1";
            hospital_sickbed_view.Rows[0].Cells[2].Value = "보기";

            hospital_sickbed_view.Rows.Add();
            hospital_sickbed_view.Rows[1].Cells[0].Value = "일반병실";
            hospital_sickbed_view.Rows[1].Cells[1].Value = "1";
            hospital_sickbed_view.Rows[1].Cells[2].Value = "보기";

            hospital_sickbed_view.Rows.Add();
            hospital_sickbed_view.Rows[2].Cells[0].Value = "일반병실";
            hospital_sickbed_view.Rows[2].Cells[1].Value = "1";
            hospital_sickbed_view.Rows[2].Cells[2].Value = "보기";

            hospital_sickbed_view.Rows.Add();
            hospital_sickbed_view.Rows[3].Cells[0].Value = "일반병실";
            hospital_sickbed_view.Rows[3].Cells[1].Value = "1";
            hospital_sickbed_view.Rows[3].Cells[2].Value = "보기";

            hospital_sickbed_view.Rows.Add();
            hospital_sickbed_view.Rows[4].Cells[0].Value = "일반병실";
            hospital_sickbed_view.Rows[4].Cells[1].Value = "1";
            hospital_sickbed_view.Rows[4].Cells[2].Value = "보기";

            hospital_sickbed_view.Rows.Add();
            hospital_sickbed_view.Rows[5].Cells[0].Value = "일반병실";
            hospital_sickbed_view.Rows[5].Cells[1].Value = "1";
            hospital_sickbed_view.Rows[5].Cells[2].Value = "보기";

            hospital_sickbed_view.Rows.Add();
            hospital_sickbed_view.Rows[5].Cells[0].Value = "일반병실";
            hospital_sickbed_view.Rows[5].Cells[1].Value = "1";
            hospital_sickbed_view.Rows[5].Cells[2].Value = "보기";

            hospital_sickbed_view.Rows.Add();
            hospital_sickbed_view.Rows[6].Cells[0].Value = "일반병실";
            hospital_sickbed_view.Rows[6].Cells[1].Value = "1";
            hospital_sickbed_view.Rows[6].Cells[2].Value = "보기";
        }

        private void Patient_Hospital_Info_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
