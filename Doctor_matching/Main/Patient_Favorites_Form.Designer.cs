
namespace Main
{
    partial class Patient_Favorites_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.back_btn = new System.Windows.Forms.Button();
            this.facorites_doctor_detail_btn = new System.Windows.Forms.Button();
            this.patient_favorites_doctor_view = new System.Windows.Forms.DataGridView();
            this.profile = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospital = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.career_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coment_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.like_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_favorites_doctor_view)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.back_btn);
            this.groupBox1.Controls.Add(this.facorites_doctor_detail_btn);
            this.groupBox1.Controls.Add(this.patient_favorites_doctor_view);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1012, 616);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "즐겨찾기";
            // 
            // back_btn
            // 
            this.back_btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.back_btn.Location = new System.Drawing.Point(858, 22);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(115, 36);
            this.back_btn.TabIndex = 3;
            this.back_btn.Text = "뒤로가기";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // facorites_doctor_detail_btn
            // 
            this.facorites_doctor_detail_btn.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.facorites_doctor_detail_btn.Location = new System.Drawing.Point(721, 22);
            this.facorites_doctor_detail_btn.Name = "facorites_doctor_detail_btn";
            this.facorites_doctor_detail_btn.Size = new System.Drawing.Size(115, 36);
            this.facorites_doctor_detail_btn.TabIndex = 2;
            this.facorites_doctor_detail_btn.Text = "상세보기";
            this.facorites_doctor_detail_btn.UseVisualStyleBackColor = true;
            this.facorites_doctor_detail_btn.Click += new System.EventHandler(this.facorites_doctor_detail_btn_Click);
            // 
            // patient_favorites_doctor_view
            // 
            this.patient_favorites_doctor_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patient_favorites_doctor_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patient_favorites_doctor_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.patient_favorites_doctor_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patient_favorites_doctor_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.profile,
            this.name,
            this.hospital,
            this.career_year,
            this.coment_num,
            this.like_num});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patient_favorites_doctor_view.DefaultCellStyle = dataGridViewCellStyle2;
            this.patient_favorites_doctor_view.Location = new System.Drawing.Point(23, 73);
            this.patient_favorites_doctor_view.Name = "patient_favorites_doctor_view";
            this.patient_favorites_doctor_view.RowTemplate.Height = 37;
            this.patient_favorites_doctor_view.Size = new System.Drawing.Size(972, 537);
            this.patient_favorites_doctor_view.TabIndex = 1;
            // 
            // profile
            // 
            this.profile.HeaderText = "프로필";
            this.profile.Image = global::Main.Properties.Resources.datagridview_doctor;
            this.profile.Name = "profile";
            this.profile.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "이름";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // hospital
            // 
            this.hospital.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hospital.HeaderText = "소속병원";
            this.hospital.Name = "hospital";
            this.hospital.ReadOnly = true;
            this.hospital.Width = 110;
            // 
            // career_year
            // 
            this.career_year.HeaderText = "경력";
            this.career_year.Name = "career_year";
            this.career_year.ReadOnly = true;
            // 
            // coment_num
            // 
            this.coment_num.HeaderText = "댓글 수";
            this.coment_num.Name = "coment_num";
            this.coment_num.ReadOnly = true;
            // 
            // like_num
            // 
            this.like_num.HeaderText = "추천 수";
            this.like_num.Name = "like_num";
            this.like_num.ReadOnly = true;
            // 
            // Patient_Favorites_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1047, 645);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patient_Favorites_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_favorites_Form";
            this.Load += new System.EventHandler(this.Patient_Favorites_Form_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patient_favorites_doctor_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button facorites_doctor_detail_btn;
        private System.Windows.Forms.DataGridView patient_favorites_doctor_view;
        private System.Windows.Forms.DataGridViewImageColumn profile;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospital;
        private System.Windows.Forms.DataGridViewTextBoxColumn career_year;
        private System.Windows.Forms.DataGridViewTextBoxColumn coment_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn like_num;
    }
}