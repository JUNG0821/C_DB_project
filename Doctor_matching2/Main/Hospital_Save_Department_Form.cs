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
    public partial class Hospital_Save_Department_Form : Form
    {
        decimal PK;
        String department;
        
        public Hospital_Save_Department_Form(decimal PK)
        {
            InitializeComponent();
            this.PK = PK;
            Console.WriteLine(PK);
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            DBconn2 DB = new DBconn2();

            for (int i = 1; i < 19; i++)
            {
                CheckBox checkbox = this.Controls.Find("department_" + i, true).FirstOrDefault() as CheckBox;

                if (checkbox != null && checkbox.Checked)
                {
                    // Checkbox가 체크되어 있을 때의 처리
                    department = checkbox.Text;
                    Decimal departmentpk = DB.get_department_pk(department);
                    DB.department_save(departmentpk, PK);

                }
            }
            MessageBox.Show("진료과 설정을 완료했습니다.");
            this.Hide();
        }

        private void Hospital_Save_Department_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
