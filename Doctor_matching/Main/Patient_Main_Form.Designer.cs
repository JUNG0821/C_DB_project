
namespace Main
{
    partial class Patient_Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Main_Form));
            this.patient_main_box = new System.Windows.Forms.GroupBox();
            this.matching_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.department_explain_btn = new System.Windows.Forms.Button();
            this.sickbed_explain_btn = new System.Windows.Forms.Button();
            this.explain_btn = new System.Windows.Forms.Button();
            this.search_hospital_btn = new System.Windows.Forms.Button();
            this.reservation_inquiry_btn = new System.Windows.Forms.Button();
            this.favorites_btn = new System.Windows.Forms.Button();
            this.change_info_btn = new System.Windows.Forms.Button();
            this.user_name_label = new System.Windows.Forms.Label();
            this.third_location_label = new System.Windows.Forms.Label();
            this.second_location_label = new System.Windows.Forms.Label();
            this.first_location_label = new System.Windows.Forms.Label();
            this.department_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user_image = new System.Windows.Forms.PictureBox();
            this.patient_main_box.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_image)).BeginInit();
            this.SuspendLayout();
            // 
            // patient_main_box
            // 
            this.patient_main_box.Controls.Add(this.matching_btn);
            this.patient_main_box.Controls.Add(this.groupBox2);
            this.patient_main_box.Controls.Add(this.search_hospital_btn);
            this.patient_main_box.Controls.Add(this.reservation_inquiry_btn);
            this.patient_main_box.Controls.Add(this.favorites_btn);
            this.patient_main_box.Controls.Add(this.change_info_btn);
            this.patient_main_box.Controls.Add(this.user_name_label);
            this.patient_main_box.Controls.Add(this.third_location_label);
            this.patient_main_box.Controls.Add(this.second_location_label);
            this.patient_main_box.Controls.Add(this.first_location_label);
            this.patient_main_box.Controls.Add(this.department_label);
            this.patient_main_box.Controls.Add(this.label2);
            this.patient_main_box.Controls.Add(this.label1);
            this.patient_main_box.Controls.Add(this.user_image);
            this.patient_main_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_main_box.Location = new System.Drawing.Point(24, 21);
            this.patient_main_box.Name = "patient_main_box";
            this.patient_main_box.Size = new System.Drawing.Size(950, 584);
            this.patient_main_box.TabIndex = 4;
            this.patient_main_box.TabStop = false;
            this.patient_main_box.Text = "정유환님 환영합니다!";
            // 
            // matching_btn
            // 
            this.matching_btn.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.matching_btn.Location = new System.Drawing.Point(23, 328);
            this.matching_btn.Name = "matching_btn";
            this.matching_btn.Size = new System.Drawing.Size(286, 223);
            this.matching_btn.TabIndex = 13;
            this.matching_btn.Text = "매칭하기";
            this.matching_btn.UseVisualStyleBackColor = true;
            this.matching_btn.Click += new System.EventHandler(this.matching_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.department_explain_btn);
            this.groupBox2.Controls.Add(this.sickbed_explain_btn);
            this.groupBox2.Controls.Add(this.explain_btn);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(330, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 235);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "도움말";
            // 
            // department_explain_btn
            // 
            this.department_explain_btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.department_explain_btn.Location = new System.Drawing.Point(160, 46);
            this.department_explain_btn.Name = "department_explain_btn";
            this.department_explain_btn.Size = new System.Drawing.Size(284, 38);
            this.department_explain_btn.TabIndex = 15;
            this.department_explain_btn.Text = "자세한 진료과 설명";
            this.department_explain_btn.UseVisualStyleBackColor = true;
            this.department_explain_btn.Click += new System.EventHandler(this.department_explain_btn_Click);
            // 
            // sickbed_explain_btn
            // 
            this.sickbed_explain_btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sickbed_explain_btn.Location = new System.Drawing.Point(160, 106);
            this.sickbed_explain_btn.Name = "sickbed_explain_btn";
            this.sickbed_explain_btn.Size = new System.Drawing.Size(284, 38);
            this.sickbed_explain_btn.TabIndex = 14;
            this.sickbed_explain_btn.Text = "병상 종류와 기능 설명";
            this.sickbed_explain_btn.UseVisualStyleBackColor = true;
            this.sickbed_explain_btn.Click += new System.EventHandler(this.sickbed_explain_btn_Click);
            // 
            // explain_btn
            // 
            this.explain_btn.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.explain_btn.Location = new System.Drawing.Point(160, 163);
            this.explain_btn.Name = "explain_btn";
            this.explain_btn.Size = new System.Drawing.Size(284, 38);
            this.explain_btn.TabIndex = 13;
            this.explain_btn.Text = "사용방법";
            this.explain_btn.UseVisualStyleBackColor = true;
            this.explain_btn.Click += new System.EventHandler(this.explain_btn_Click);
            // 
            // search_hospital_btn
            // 
            this.search_hospital_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_hospital_btn.Location = new System.Drawing.Point(744, 238);
            this.search_hospital_btn.Name = "search_hospital_btn";
            this.search_hospital_btn.Size = new System.Drawing.Size(160, 38);
            this.search_hospital_btn.TabIndex = 11;
            this.search_hospital_btn.Text = "병원찾기";
            this.search_hospital_btn.UseVisualStyleBackColor = true;
            this.search_hospital_btn.Click += new System.EventHandler(this.search_hospital_btn_Click);
            // 
            // reservation_inquiry_btn
            // 
            this.reservation_inquiry_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_inquiry_btn.Location = new System.Drawing.Point(522, 238);
            this.reservation_inquiry_btn.Name = "reservation_inquiry_btn";
            this.reservation_inquiry_btn.Size = new System.Drawing.Size(160, 38);
            this.reservation_inquiry_btn.TabIndex = 10;
            this.reservation_inquiry_btn.Text = "예약조회";
            this.reservation_inquiry_btn.UseVisualStyleBackColor = true;
            this.reservation_inquiry_btn.Click += new System.EventHandler(this.reservation_inquiry_btn_Click);
            // 
            // favorites_btn
            // 
            this.favorites_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.favorites_btn.Location = new System.Drawing.Point(306, 238);
            this.favorites_btn.Name = "favorites_btn";
            this.favorites_btn.Size = new System.Drawing.Size(160, 38);
            this.favorites_btn.TabIndex = 9;
            this.favorites_btn.Text = "즐겨찾기";
            this.favorites_btn.UseVisualStyleBackColor = true;
            this.favorites_btn.Click += new System.EventHandler(this.favorites_btn_Click);
            // 
            // change_info_btn
            // 
            this.change_info_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_info_btn.Location = new System.Drawing.Point(61, 273);
            this.change_info_btn.Name = "change_info_btn";
            this.change_info_btn.Size = new System.Drawing.Size(200, 38);
            this.change_info_btn.TabIndex = 8;
            this.change_info_btn.Text = "개인정보 변경";
            this.change_info_btn.UseVisualStyleBackColor = true;
            this.change_info_btn.Click += new System.EventHandler(this.change_info_btn_Click);
            // 
            // user_name_label
            // 
            this.user_name_label.AutoSize = true;
            this.user_name_label.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.user_name_label.Location = new System.Drawing.Point(123, 254);
            this.user_name_label.Name = "user_name_label";
            this.user_name_label.Size = new System.Drawing.Size(72, 16);
            this.user_name_label.TabIndex = 7;
            this.user_name_label.Text = "정유환님";
            // 
            // third_location_label
            // 
            this.third_location_label.AutoSize = true;
            this.third_location_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.third_location_label.Location = new System.Drawing.Point(561, 167);
            this.third_location_label.Name = "third_location_label";
            this.third_location_label.Size = new System.Drawing.Size(343, 19);
            this.third_location_label.TabIndex = 6;
            this.third_location_label.Text = "장곡동 숲속마을 아파트 205동 304호";
            // 
            // second_location_label
            // 
            this.second_location_label.AutoSize = true;
            this.second_location_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.second_location_label.Location = new System.Drawing.Point(486, 167);
            this.second_location_label.Name = "second_location_label";
            this.second_location_label.Size = new System.Drawing.Size(69, 19);
            this.second_location_label.TabIndex = 5;
            this.second_location_label.Text = "시흥시";
            // 
            // first_location_label
            // 
            this.first_location_label.AutoSize = true;
            this.first_location_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.first_location_label.Location = new System.Drawing.Point(411, 167);
            this.first_location_label.Name = "first_location_label";
            this.first_location_label.Size = new System.Drawing.Size(69, 19);
            this.first_location_label.TabIndex = 4;
            this.first_location_label.Text = "경기도";
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.department_label.Location = new System.Drawing.Point(493, 88);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(89, 19);
            this.department_label.TabIndex = 3;
            this.department_label.Text = "신경외과";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(302, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "현재 위치 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(302, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "현재 설정한 진료과 :";
            // 
            // user_image
            // 
            this.user_image.Image = global::Main.Properties.Resources.user_default_image;
            this.user_image.InitialImage = ((System.Drawing.Image)(resources.GetObject("user_image.InitialImage")));
            this.user_image.Location = new System.Drawing.Point(61, 42);
            this.user_image.Name = "user_image";
            this.user_image.Size = new System.Drawing.Size(200, 200);
            this.user_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user_image.TabIndex = 0;
            this.user_image.TabStop = false;
            // 
            // Patient_Main_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1002, 631);
            this.Controls.Add(this.patient_main_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Patient_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Main_Form";
            this.Load += new System.EventHandler(this.Patient_Main_Form_Load);
            this.patient_main_box.ResumeLayout(false);
            this.patient_main_box.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox patient_main_box;
        private System.Windows.Forms.PictureBox user_image;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label third_location_label;
        private System.Windows.Forms.Label second_location_label;
        private System.Windows.Forms.Label first_location_label;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Button favorites_btn;
        private System.Windows.Forms.Button change_info_btn;
        private System.Windows.Forms.Label user_name_label;
        private System.Windows.Forms.Button search_hospital_btn;
        private System.Windows.Forms.Button reservation_inquiry_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button explain_btn;
        private System.Windows.Forms.Button sickbed_explain_btn;
        private System.Windows.Forms.Button matching_btn;
        private System.Windows.Forms.Button department_explain_btn;
    }
}