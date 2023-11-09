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
    public partial class Patient_Favorites_Form : Form
    {
        public Patient_Favorites_Form()
        {

            this.FormClosed += (s, args) => Application.Exit();
            InitializeComponent();
        }

        private void Patient_Favorites_Form_Load(object sender, EventArgs e)
        {
            patient_favorites_doctor_view.Rows.Add();
            Image doctor_image = Properties.Resources.datagridview_doctor;
            patient_favorites_doctor_view.Rows[0].Cells[0].Value = doctor_image; // 첫 번째 칼럼 (인덱스 0)에 이미지를 설정
            patient_favorites_doctor_view.Rows[0].Cells[1].Value = "정유환";
            patient_favorites_doctor_view.Rows[0].Cells[2].Value = "고려대병원";
            patient_favorites_doctor_view.Rows[0].Cells[3].Value = "3년";
            patient_favorites_doctor_view.Rows[0].Cells[4].Value = "10개";
            patient_favorites_doctor_view.Rows[0].Cells[5].Value = "20개";

            patient_favorites_doctor_view.Rows.Add();
            patient_favorites_doctor_view.Rows[1].Cells[0].Value = doctor_image; // 첫 번째 칼럼 (인덱스 0)에 이미지를 설정
            patient_favorites_doctor_view.Rows[1].Cells[1].Value = "남도현";
            patient_favorites_doctor_view.Rows[1].Cells[2].Value = "서울아산병원";
            patient_favorites_doctor_view.Rows[1].Cells[3].Value = "4년";
            patient_favorites_doctor_view.Rows[1].Cells[4].Value = "11개";
            patient_favorites_doctor_view.Rows[1].Cells[5].Value = "500개";

            patient_favorites_doctor_view.Rows.Add();
            patient_favorites_doctor_view.Rows[2].Cells[0].Value = doctor_image; // 첫 번째 칼럼 (인덱스 0)에 이미지를 설정
            patient_favorites_doctor_view.Rows[2].Cells[1].Value = "최지태";
            patient_favorites_doctor_view.Rows[2].Cells[2].Value = "삼성서울병원";
            patient_favorites_doctor_view.Rows[2].Cells[3].Value = "7년";
            patient_favorites_doctor_view.Rows[2].Cells[4].Value = "12개";
            patient_favorites_doctor_view.Rows[2].Cells[5].Value = "5030개";

            patient_favorites_doctor_view.Rows.Add();
            patient_favorites_doctor_view.Rows[3].Cells[0].Value = doctor_image; // 첫 번째 칼럼 (인덱스 0)에 이미지를 설정
            patient_favorites_doctor_view.Rows[3].Cells[1].Value = "집가고싶다";
            patient_favorites_doctor_view.Rows[3].Cells[2].Value = "가톨릭대서울성모병원";
            patient_favorites_doctor_view.Rows[3].Cells[3].Value = "1년";
            patient_favorites_doctor_view.Rows[3].Cells[4].Value = "13개";
            patient_favorites_doctor_view.Rows[3].Cells[5].Value = "530개";
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Patient_Main_Form patient_main_form = new Patient_Main_Form();
            patient_main_form.Show();
            this.Hide();
        }

        private void facorites_doctor_detail_btn_Click(object sender, EventArgs e)
        {
            Patient_Favorites_Doctor_Detail_Form patient_favorites_doctor_detail_form = new Patient_Favorites_Doctor_Detail_Form();
            patient_favorites_doctor_detail_form.Show();
            this.Hide();
        }
    }
}
