using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data; //DataSet 개체 참조
using System.Windows.Forms;

namespace Main
{
    public class hospital_Info
    {
        public string hospitalName { get; set; }
        public decimal hospitalPhone { get; set; }
        public decimal hospitalCount { get; set; }
        public string hospitalNote { get; set; }
        public string hospitalDivision { get; set; }

        
    }

    public class location_Info
    {
        public string first { get; set; }
        public string second { get; set; }
        public string detailed { get; set; }
    }
    class DBconn2
    {
        private const string Name = "PATIENT_SERIAL_NUMBER";

        // 생성자에서 사용할 연결 문자열
        private string conn_info;

        // 생성자 정의
        public DBconn2()
        {
            conn_info = "User Id=SCOTT; Password=scott; Data Source=(DESCRIPTION = " +
                             "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) " +
                             "(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
        }

        //생성자 오버로딩
        public DBconn2(string con_info)
        {
            conn_info = con_info;
        }

        //오라클 conection 객체 생성 
        public void OpenConnection()
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("연결 성공!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                }
            }
        }

        public String get_conn_info()
        {
            return this.conn_info;
        }

        //병원 회원가입 DB
        public Boolean hospital_join_membership(String id, String pass)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "INSERT INTO HOSPITAL_LOGIN (HOSPITAL_SERIAL_NUMBER, HOSPITAL_ID, HOSPITAL_PASSWORD) " +
                                 "VALUES (hospitla_seq.NEXTVAL, :hospitalId, :hospitalPassword)";
                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":hospitalId", OracleDbType.Varchar2).Value = id;
                        command.Parameters.Add(":hospitalPassword", OracleDbType.Varchar2).Value = pass;
                        command.ExecuteNonQuery();
                        Console.WriteLine("행이 삽입되었습니다.");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                    return false;
                }
            }
        }

        //병원 로그인 DB
        public bool hospital_login(string id, string pass)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT HOSPITAL_ID, HOSPITAL_PASSWORD FROM HOSPITAL_LOGIN";
                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string patientId = reader.GetString(reader.GetOrdinal("HOSPITAL_ID"));
                                string patientPassword = reader.GetString(reader.GetOrdinal("HOSPITAL_PASSWORD"));

                                if (id == patientId && pass == patientPassword)
                                {
                                    return true;
                                    Console.WriteLine("로그인 성공!");
                                }
                            }
                        }
                    }
                    return false;
                }
                catch (Exception ex)    
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                    Console.WriteLine("로그인 실패");
                    return false;
                }
            }
        }
        //병원의 PK값 반환
        public decimal get_hospital_pk(String id, String pass)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT HOSPITAL_SERIAL_NUMBER FROM HOSPITAL_LOGIN WHERE HOSPITAL_ID = :id AND HOSPITAL_PASSWORD = :pass";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        // 매개변수 추가
                        command.Parameters.Add(":id", OracleDbType.Varchar2).Value = id;
                        command.Parameters.Add(":pass", OracleDbType.Varchar2).Value = pass;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 결과에서 값 가져오기
                                decimal PK = reader.GetDecimal(reader.GetOrdinal("HOSPITAL_SERIAL_NUMBER"));
                                return PK;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                }
                // 매칭되는 항목이 없으면 -1 또는 다른 적절한 값 반환
                return -1;
            }

        }
        public decimal get_doctor_pk(String name, String email)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT DOCTOR_SERIAL_NUMBER FROM DOCTOR_INFO WHERE DOCTOR_NAME= :name AND DOCTOR_EMAIL = :email";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        // 매개변수 추가
                        command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                        command.Parameters.Add(":pass", OracleDbType.Varchar2).Value = email;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 결과에서 값 가져오기
                                decimal PK = reader.GetDecimal(reader.GetOrdinal("DOCTOR_SERIAL_NUMBER"));
                                return PK;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                }
                // 매칭되는 항목이 없으면 -1 또는 다른 적절한 값 반환
                return -1;
            }

        }
        public decimal get_department_pk(String name)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT DEPARTMENT_SERIAL_NUMBER FROM DEPARTMENT WHERE DEPARTMENT_NAME= :name";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        // 매개변수 추가
                        command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 결과에서 값 가져오기
                                decimal PK = reader.GetDecimal(reader.GetOrdinal("DEPARTMENT_SERIAL_NUMBER"));
                                return PK;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                }
                // 매칭되는 항목이 없으면 -1 또는 다른 적절한 값 반환
                return -1;
            }

        }

        public decimal get_bed_pk(String name)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT BED_SERIAL_NUMBER FROM BED WHERE BED_NAME= :name";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        // 매개변수 추가
                        command.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // 결과에서 값 가져오기
                                decimal PK = reader.GetDecimal(reader.GetOrdinal("BED_SERIAL_NUMBER"));
                                return PK;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                }
                // 매칭되는 항목이 없으면 -1 또는 다른 적절한 값 반환
                return -1;
            }

        }
        public bool confirm_hospital_pk(decimal PK)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT 1 FROM HOSPITAL_INFO WHERE HOSPITAL_SERIAL_NUMBER = :pk";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":pk", OracleDbType.Decimal).Value = PK;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {   
                            return reader.Read();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("연결 실패: " + ex.Message);
                }

                return false;
            }
        }

       public void set_location_info(decimal PK, String first, String second, String detailed)
        {
            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                conn.Open();

                string sql = "INSERT INTO SCOTT.HOSPITAL_LOCATION(HOSPITAL_SERIAL_NUMBER, FIRST_LOCATION, SECOND_LOCATION, DETAILED_LOCATION)" +
                                "SELECT: hospitalPK, :first, :second, :detailed FROM DUAL";


                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {

                    cmd.Parameters.Add(":hospitalPK", OracleDbType.Decimal).Value = PK;
                    cmd.Parameters.Add(":first", OracleDbType.Varchar2).Value = first;
                    cmd.Parameters.Add(":second", OracleDbType.Varchar2).Value = second;
                    cmd.Parameters.Add(":detailed", OracleDbType.Varchar2).Value = detailed;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //병원의 정보를 저장
        public void set_hospital_info(decimal PK, string name, int phone, int doctorNum ,string special_note, string division)
        {

            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                conn.Open();

                string sql ="INSERT INTO SCOTT.HOSPITAL_INFO " +
              "(HOSPITAL_SERIAL_NUMBER, HOSPITAL_NAME, HOSPITAL_PHONE_NUMBER, HOSPITAL_DOCTOR_COUNT, HOSPITAL_SPECIAL_NOTES, HOSPITAL_DIVISION) " +
              "VALUES (:hospitalSerialNumber, :name, :phoneNumber, :doctorNum, :specialNotes, :division)";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {

                    cmd.Parameters.Add(":hospitalSerialNumber", OracleDbType.Decimal).Value = PK;
                    cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                    cmd.Parameters.Add(":phoneNumber", OracleDbType.Int32).Value = phone;
                    cmd.Parameters.Add(":doctorNum", OracleDbType.Int32).Value = doctorNum;
                    cmd.Parameters.Add(":specialNotes", OracleDbType.Varchar2).Value = special_note;
                    cmd.Parameters.Add(":division", OracleDbType.Varchar2).Value = division;

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void set_Bad_info(decimal hospital_PK, decimal bed_PK, decimal quantity)
        {

            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                conn.Open();

                string sql = "INSERT INTO SCOTT.BED " +
              "(HOSPITAL_SERIAL_NUMBER, BED_SERIAL_NUMBER, BED_QUANTITY) " +
              "VALUES (:hospitalSerialNumber, (SELECT BED_SERIAL_NUMBER FROM SCOTT.BED WHERE BED_SERIAL_NUMBER = :bedSerialNumber), :quantity)";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {

                    cmd.Parameters.Add(":hospitalSerialNumber", OracleDbType.Decimal).Value = hospital_PK;
                    cmd.Parameters.Add(":bedSerialNumber", OracleDbType.Decimal).Value = bed_PK;
                    cmd.Parameters.Add(":quantity", OracleDbType.Decimal).Value = quantity;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //의사 저장 
        public void doctor_save_info(decimal doctor_PK, string name, string experience, int phone, string email, string department, string introduction, int recommendation, decimal hospital_PK)
        {
            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                conn.Open();

                string sql = "INSERT INTO SCOTT.DOCTOR_INFO " +
                             "(DOCTOR_SERIAL_NUMBER, DOCTOR_NAME, DOCTOR_EXPERIENCE, DOCTOR_PHONE_NUMBER, DOCTOR_EMAIL, DOCTOR_PRIMARY_DEPARTMENT, DOCTOR_INTRODUCTION, DOCTOR_RECOMMENDATION_COUNT, HOSPITAL_SERIAL_NUMBER) " +
                             "VALUES (doctor_seq.NEXTVAL, :name, :experience, :phoneNumber, :email, :department, :introduction, :recommendation, (SELECT HOSPITAL_SERIAL_NUMBER FROM SCOTT.HOSPITAL_INFO WHERE HOSPITAL_SERIAL_NUMBER = :hospitalPK))";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                    cmd.Parameters.Add(":experience", OracleDbType.Varchar2).Value = experience;
                    cmd.Parameters.Add(":phoneNumber", OracleDbType.Int32).Value = phone;
                    cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = email;
                    cmd.Parameters.Add(":department", OracleDbType.Varchar2).Value = department;
                    cmd.Parameters.Add(":introduction", OracleDbType.Varchar2).Value = introduction;
                    cmd.Parameters.Add(":recommendation", OracleDbType.Int32).Value = recommendation;
                    cmd.Parameters.Add(":hospitalPK", OracleDbType.Decimal).Value = hospital_PK;

                    cmd.ExecuteNonQuery();
                }
            }
        }



        // 병원 업데이트
        public void update_hospital_info(decimal PK, string name, int phone, int doctorNum, string special_note, string division)
        {
            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                conn.Open();

                string sql = "UPDATE SCOTT.HOSPITAL_INFO " +
                             "SET HOSPITAL_NAME = :name, " +
                             "    HOSPITAL_PHONE_NUMBER = :phoneNumber, " +
                             "    HOSPITAL_DOCTOR_COUNT = :doctorNum, " +
                             "    HOSPITAL_SPECIAL_NOTES = :specialNotes, " +
                             "    HOSPITAL_DIVISION = :division " +
                             "WHERE HOSPITAL_SERIAL_NUMBER = :hospitalSerialNumber";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                    cmd.Parameters.Add(":phoneNumber", OracleDbType.Int32).Value = phone;
                    cmd.Parameters.Add(":doctorNum", OracleDbType.Int32).Value = doctorNum;
                    cmd.Parameters.Add(":specialNotes", OracleDbType.Varchar2).Value = special_note;
                    cmd.Parameters.Add(":division", OracleDbType.Varchar2).Value = division;
                    cmd.Parameters.Add(":hospitalSerialNumber", OracleDbType.Decimal).Value = PK;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void update_location_info(decimal PK, string first, string second, string detailed)
        {
            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                conn.Open();

                string sql = "UPDATE SCOTT.HOSPITAL_LOCATION " +
                             "SET FIRST_LOCATION = :first, " +
                             "    SECOND_LOCATION = :second, " +
                             "    DETAILED_LOCATION = :detailed " +
                             "WHERE HOSPITAL_SERIAL_NUMBER = :hospitalSerialNumber";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    cmd.Parameters.Add(":first", OracleDbType.Varchar2).Value = first;
                    cmd.Parameters.Add(":second", OracleDbType.Varchar2).Value = second;
                    cmd.Parameters.Add(":detailed", OracleDbType.Varchar2).Value = detailed;
                    cmd.Parameters.Add(":hospitalSerialNumber", OracleDbType.Decimal).Value = PK;

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public hospital_Info Hospital_info(decimal hospital_pk)
        {
            hospital_Info hi = new hospital_Info();
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT HOSPITAL_NAME, HOSPITAL_PHONE_NUMBER, HOSPITAL_DOCTOR_COUNT, HOSPITAL_SPECIAL_NOTES, HOSPITAL_DIVISION FROM HOSPITAL_INFO WHERE HOSPITAL_SERIAL_NUMBER = :pk";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        
                        command.Parameters.Add(":pk", OracleDbType.Decimal).Value = hospital_pk;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {

                                hi.hospitalName = reader.GetString(reader.GetOrdinal("HOSPITAL_NAME"));
                                hi.hospitalNote = reader.GetString(reader.GetOrdinal("HOSPITAL_SPECIAL_NOTES"));
                                hi.hospitalDivision = reader.GetString(reader.GetOrdinal("HOSPITAL_DIVISION"));
                                hi.hospitalPhone = reader.GetDecimal(reader.GetOrdinal("HOSPITAL_PHONE_NUMBER"));
                                hi.hospitalCount = reader.GetDecimal(reader.GetOrdinal("HOSPITAL_DOCTOR_COUNT"));

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception (e.g., log or display an error message)
                    Console.WriteLine(ex.Message);
                }

   
            }
            return hi;
        }

        public location_Info Location_info(decimal hospital_pk)
        {
            location_Info location = new location_Info();
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT FIRST_LOCATION, SECOND_LOCATION, DETAILED_LOCATION FROM HOSPITAL_LOCATION WHERE HOSPITAL_SERIAL_NUMBER = :pk";

                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {

                        command.Parameters.Add(":pk", OracleDbType.Decimal).Value = hospital_pk;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {

                                location.first = reader.GetString(reader.GetOrdinal("FIRST_LOCATION"));
                                location.second = reader.GetString(reader.GetOrdinal("SECOND_LOCATION"));
                                location.detailed = reader.GetString(reader.GetOrdinal("DETAILED_LOCATION"));
                              

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception (e.g., log or display an error message)
                    Console.WriteLine(ex.Message);
                }


            }
            return location;
        }

        public void department_save(decimal department_pk, decimal hospital_pk)
        {
            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                conn.Open();

                string sql = "INSERT INTO SCOTT.HOSPITAL_DEPARTMENTS (DEPARTMENT_SERIAL_NUMBER, HOSPITAL_SERIAL_NUMBER) " +
                            "VALUES ((SELECT DEPARTMENT_SERIAL_NUMBER FROM SCOTT.DEPARTMENT WHERE DEPARTMENT_SERIAL_NUMBER = :departmentpk), " +
                            "(SELECT HOSPITAL_SERIAL_NUMBER FROM SCOTT.HOSPITAL_LOGIN WHERE HOSPITAL_SERIAL_NUMBER = :hospitalpk))";



                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {
                    try
                    {
                        cmd.Parameters.Add(":departmentpk", OracleDbType.Decimal).Value = department_pk;
                        cmd.Parameters.Add(":hospitalPK", OracleDbType.Decimal).Value = hospital_pk;

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        
                        Console.WriteLine($"에러: {ex.Message}");
                    }
                }
            }
        }

    }

}