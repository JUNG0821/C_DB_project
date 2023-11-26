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
    public partial class Hospital_Save_Sickbed_Form : Form
    {
        decimal PK;
        public Hospital_Save_Sickbed_Form(decimal PK)
        {
            InitializeComponent();
            this.PK = PK;
        }

        private void complete_btn_Click(object sender, EventArgs e)
        {
            DBconn2 DB = new DBconn2();

            for (int i = 1; i <= 9; i++)
            {

                Label label = this.Controls.Find("Label" + i , true).FirstOrDefault() as Label;
                TextBox textBox = this.Controls.Find("sickbed_" + i + "_txt", true).FirstOrDefault() as TextBox;

                if (label != null && textBox != null)
                {
                    string name = label.Text;
                    decimal count = decimal.Parse(textBox.Text);
                    decimal bed_PK = DB.get_bed_pk(name);

                    DB.set_Bad_info(PK, bed_PK, count);
                }
            }

            MessageBox.Show("병상 설정이 완료되었습니다.");
            this.Hide();
        }
        private void Hospital_Save_Sickbed_Form_Load(object sender, EventArgs e)
        {
            
        }
    }
}
