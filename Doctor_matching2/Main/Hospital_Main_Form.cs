using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;//ADO.Net 개체 참조
using System.Data; //DataSet 개체 참조
using System.Windows.Forms; //MessageBox 개체 참조

namespace Main
{
    public partial class Hospital_Main_Form : Form
    {
        private decimal PK;
        public Hospital_Main_Form(decimal PK)
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
            this.PK = PK;



            register_doctor_view.Rows.Add();
            Image doctor_image = Properties.Resources.datagridview_doctor;
            register_doctor_view.Rows[0].Cells[0].Value = doctor_image; // 첫 번째 칼럼 (인덱스 0)에 이미지를 설정
            register_doctor_view.Rows[0].Cells[1].Value = "정유환";
            register_doctor_view.Rows[0].Cells[2].Value = "3년";
            register_doctor_view.Rows[0].Cells[3].Value = "10개";
            register_doctor_view.Rows[0].Cells[4].Value = "10개";
            register_doctor_view.Rows[0].Cells[5].Value = "등록해제";



            
            message_view.Rows.Add();
            message_view.Rows[0].Cells[0].Value = "홍길동";
            message_view.Rows[0].Cells[1].Value = "40";
            message_view.Rows[0].Cells[2].Value = "정유환";
            message_view.Rows[0].Cells[3].Value = "2023/12/25";
            message_view.Rows[0].Cells[4].Value = "오전/2시/30분";
            message_view.Rows[0].Cells[5].Value = "수락하기";
            message_view.Rows[0].Cells[6].Value = "취소하기";
            
        }

        private void Hospital_Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void chagne_info_btn_Click(object sender, EventArgs e)
        {
            Hospital_Change_Info_Form hospital_change_info_form = new Hospital_Change_Info_Form(PK);
            hospital_change_info_form.Show();
            this.Hide();

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Hospital_Regist_Doctor hospital_regist_doctor = new Hospital_Regist_Doctor(PK);
            hospital_regist_doctor.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
