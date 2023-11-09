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
    public partial class Patient_Favorites_Doctor_Detail_Form : Form
    {
        public Patient_Favorites_Doctor_Detail_Form()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();

            doctor_coment_view.Rows.Add();
            doctor_coment_view.Rows[0].Cells[0].Value = "홍길동";
            doctor_coment_view.Rows[0].Cells[1].Value = "진료하는게 불친절해요 ㅠ";
            doctor_coment_view.Rows[0].Cells[2].Value = "6";
            doctor_coment_view.Rows[0].Cells[3].Value = "추천";

            doctor_coment_view.Rows.Add();
            doctor_coment_view.Rows[1].Cells[0].Value = "동길동";
            doctor_coment_view.Rows[1].Cells[1].Value = "좋아요! 앞으로도 자주 이 의사한테 맡길 것 같아요!";
            doctor_coment_view.Rows[1].Cells[2].Value = "7";
            doctor_coment_view.Rows[1].Cells[3].Value = "추천";

            doctor_coment_view.Rows.Add();
            doctor_coment_view.Rows[2].Cells[0].Value = "홍길홍";
            doctor_coment_view.Rows[2].Cells[1].Value = "신이 내린 의사가 아닐까요??";
            doctor_coment_view.Rows[2].Cells[2].Value = "7";
            doctor_coment_view.Rows[2].Cells[3].Value = "추천";

            doctor_coment_view.Rows.Add();
            doctor_coment_view.Rows[3].Cells[0].Value = "홍동길";
            doctor_coment_view.Rows[3].Cells[1].Value = "이사람 의료사고 났다고 하던데 진짜인가요?";
            doctor_coment_view.Rows[3].Cells[2].Value = "7";
            doctor_coment_view.Rows[3].Cells[3].Value = "추천";

            doctor_coment_view.Rows.Add();
            doctor_coment_view.Rows[4].Cells[0].Value = "길동홍";
            doctor_coment_view.Rows[4].Cells[1].Value = "이사람 너무 무섭게 생겼어요ㅠㅠㅠㅠㅠㅠㅠ";
            doctor_coment_view.Rows[4].Cells[2].Value = "10";
            doctor_coment_view.Rows[4].Cells[3].Value = "추천";

            doctor_coment_view.Rows.Add();
            doctor_coment_view.Rows[5].Cells[0].Value = "홍홍홍";
            doctor_coment_view.Rows[5].Cells[1].Value = "홍박사님을 아세연~";
            doctor_coment_view.Rows[5].Cells[2].Value = "10";
            doctor_coment_view.Rows[5].Cells[3].Value = "추천";

            doctor_coment_view.Rows.Add();
            doctor_coment_view.Rows[6].Cells[0].Value = "길길길";
            doctor_coment_view.Rows[6].Cells[1].Value = "이 시대의 최고의 의사! 정말 추천드립니다.";
            doctor_coment_view.Rows[6].Cells[2].Value = "2";
            doctor_coment_view.Rows[6].Cells[3].Value = "추천";
        }

        private void recommend_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("추천하셨습니다!");
        }

        private void favorites_cancel_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("즐겨찾기 해지되셨습니다!");
        }

        private void reservation_btn_Click(object sender, EventArgs e)
        {
            Reservation_Form reservation_form = new Reservation_Form();
            reservation_form.ShowDialog();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Patient_Main_Form patient_main_form = new Patient_Main_Form();
            patient_main_form.Show();
            this.Hide();
        }

        private void Patient_Favorites_Doctor_Detail_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
