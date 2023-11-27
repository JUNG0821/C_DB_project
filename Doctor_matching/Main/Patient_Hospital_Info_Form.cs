﻿using System;
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
        DBconn db = new DBconn();
        decimal hospital_pk;
        public Patient_Hospital_Info_Form(decimal Hospital_PK)
        {
            InitializeComponent();
            this.hospital_pk = Hospital_PK;

            HospitalData hospitalData = db.GetHospitalData(hospital_pk);
            List<DepartmentData> departmentList = db.GetDepartments(hospital_pk);
            List<BedData> bedList = db.GetHospitalBedInfo(hospital_pk);

            name_txt.Text = hospitalData.HospitalName;
            location_txt.Text = hospitalData.FirstLocation + " " + hospitalData.SecondLocation + " " + hospitalData.DetailedLocation;
            hospital_division_txt.Text = hospitalData.HospitalDivision;
            phone_num_txt.Text = "0" + hospitalData.HospitalPhoneNumber;
            e_mail_txt.Text = hospitalData.HospitalEmail;
            introduce_txt.Text = hospitalData.HospitalSpecialNotes;

            foreach (var department in departmentList)
            {
                int rowIndex = hospital_department_view.Rows.Add();
                hospital_department_view.Rows[rowIndex].Cells[0].Value = department.DepartmentName;
                hospital_department_view.Rows[rowIndex].Cells[1].Value = "보기";
                hospital_department_view.Rows[rowIndex].Tag = department.DepartmentSerialNumber;
            }

            foreach (var sickBedData in bedList)
            {
                int rowIndex = hospital_sickbed_view.Rows.Add();
                hospital_sickbed_view.Rows[rowIndex].Cells[0].Value = sickBedData.BedName;
                hospital_sickbed_view.Rows[rowIndex].Cells[1].Value = sickBedData.BedQuantity;
                hospital_sickbed_view.Rows[rowIndex].Cells[2].Value = "보기";
                hospital_sickbed_view.Rows[rowIndex].Tag = sickBedData.SickBedSerialNumber;
            }
        }

        private void Patient_Hospital_Info_Form_Load(object sender, EventArgs e)
        {

        }

        private void hospital_department_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0) // "보기" 버튼이 클릭된 경우
            {
                decimal departmentSerialNumber = (decimal)hospital_department_view.Rows[e.RowIndex].Tag;
                DepartmentData departmentData = db.GetDepartmentInfo(departmentSerialNumber);
                Console.WriteLine(departmentData.DepartmentName);
                Console.WriteLine(departmentData.DepartmentDescription);
                Hospital_Department_ex hospital_department_ex = new Hospital_Department_ex(departmentData);
                hospital_department_ex.ShowDialog();
            }
        }

        private void hospital_sickbed_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0) // "보기" button is clicked
            {
                decimal sickBedSerialNumber = (decimal)hospital_sickbed_view.Rows[e.RowIndex].Tag;
                BedData sickBedData = db.GetSickBedInfo(sickBedSerialNumber);

                Hospital_sicbed_ex sickBedInfoForm = new Hospital_sicbed_ex(sickBedData);
                // Show the form
                sickBedInfoForm.ShowDialog();
            }
        }
    }
}
