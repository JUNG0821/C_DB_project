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
    public partial class Patient_Reservation_Inquiry_Form : Form
    {
        public Patient_Reservation_Inquiry_Form()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();

            patient_reservation_view.Rows.Add();
            Image doctor_image = Properties.Resources.datagridview_doctor;
            patient_reservation_view.Rows[0].Cells[0].Value = doctor_image; // 첫 번째 칼럼 (인덱스 0)에 이미지를 설정
            patient_reservation_view.Rows[0].Cells[1].Value = "정유환";
            patient_reservation_view.Rows[0].Cells[2].Value = "신경과";
            patient_reservation_view.Rows[0].Cells[3].Value = "2023년 8월 30일";
            patient_reservation_view.Rows[0].Cells[4].Value = "심사중";
            patient_reservation_view.Rows[0].Cells[5].Value = "예약취소하기";
            

            patient_reservation_view.Rows.Add();
            patient_reservation_view.Rows[1].Cells[0].Value = doctor_image; // 첫 번째 칼럼 (인덱스 0)에 이미지를 설정
            patient_reservation_view.Rows[1].Cells[1].Value = "정유환";
            patient_reservation_view.Rows[1].Cells[2].Value = "신경과";
            patient_reservation_view.Rows[1].Cells[3].Value = "2023년 8월 30일";
            patient_reservation_view.Rows[1].Cells[4].Value = "심사중";
            patient_reservation_view.Rows[1].Cells[5].Value = "예약취소하기";

            patient_reservation_view.Rows.Add();
            patient_reservation_view.Rows[2].Cells[0].Value = doctor_image; // 첫 번째 칼럼 (인덱스 0)에 이미지를 설정
            patient_reservation_view.Rows[2].Cells[1].Value = "정유환";
            patient_reservation_view.Rows[2].Cells[2].Value = "신경과";
            patient_reservation_view.Rows[2].Cells[3].Value = "2023년 8월 30일";
            patient_reservation_view.Rows[2].Cells[4].Value = "심사중";
            patient_reservation_view.Rows[2].Cells[5].Value = "예약취소하기";

            patient_reservation_view.Rows.Add();
            patient_reservation_view.Rows[3].Cells[0].Value = doctor_image; // 첫 번째 칼럼 (인덱스 0)에 이미지를 설정
            patient_reservation_view.Rows[3].Cells[1].Value = "정유환";
            patient_reservation_view.Rows[3].Cells[2].Value = "신경과";
            patient_reservation_view.Rows[3].Cells[3].Value = "2023년 8월 30일";
            patient_reservation_view.Rows[3].Cells[4].Value = "심사중";
            patient_reservation_view.Rows[3].Cells[5].Value = "예약취소하기";
        }

        private void Patient_Reservation_Inquiry_Form_Load(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Patient_Main_Form patient_main_form = new Patient_Main_Form();
            patient_main_form.Show();
            this.Hide();
        }
    }
}
