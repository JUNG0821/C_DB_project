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
            listView1.View = View.Details; // 세부 정보 보기
            listView1.FullRowSelect = true; // 전체 행 선택
            listView1.GridLines = true; // 그리드 라인 표시

            listView1.Columns.Add("이름", 100);
            listView1.Columns.Add("소속병원", 100);
            listView1.Columns.Add("경력", 100);
            listView1.Columns.Add("댓글 수", 100);
            listView1.Columns.Add("추천 수", 100);
            listView1.Columns.Add("주진료과", 180); // 소개 부분의 너비를 조절
            listView1.Columns.Add("E_mail", 360); // 소개 부분의 너비를 조절

            ListViewItem item1 = new ListViewItem("항목 1");
            item1.SubItems.Add("병원 1");
            item1.SubItems.Add("경력 1");
            item1.SubItems.Add("5");
            item1.SubItems.Add("10");
            item1.SubItems.Add("010-2204-7847");
            item1.SubItems.Add("bak3353@naver.com");

            ListViewItem item2 = new ListViewItem("항목 2");
            item2.SubItems.Add("병원 2");
            item2.SubItems.Add("경력 2");
            item2.SubItems.Add("8");
            item2.SubItems.Add("15");
            item2.SubItems.Add("진단검사의학과");
            item2.SubItems.Add("bak3353@naver.com");

            listView1.Items.Add(item1);
            listView1.Items.Add(item2);




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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
         
        }
    }
}
