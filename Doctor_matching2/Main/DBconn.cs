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
    class DBconn
    {
        private const string Name = "PATIENT_SERIAL_NUMBER";

        // 생성자에서 사용할 연결 문자열
        private string conn_info;

        // 생성자 정의
        public DBconn()
        {
            conn_info = "User Id=jung02; Password=1234; Data Source=(DESCRIPTION = " +
                             "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) " +
                             "(CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
        }

        //생성자 오버로딩
        public DBconn(string con_info)
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

        //환자 회원가입 DB
        public Boolean patient_join_membership(String id, String pass)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "INSERT INTO PATIENT_LOGIN (PATIENT_SERIAL_NUMBER, PATIENT_ID, PATIENT_PASSWORD) " +
                                 "VALUES (patient_login_seq.NEXTVAL, :patientId, :patientPassword)";
                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        command.Parameters.Add(":patientId", OracleDbType.Varchar2).Value = id;
                        command.Parameters.Add(":patientPassword", OracleDbType.Varchar2).Value = pass;
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

        //환자 로그인 DB
        public bool patient_login(string id, string pass)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT PATIENT_ID, PATIENT_PASSWORD FROM PATIENT_LOGIN";
                    using (OracleCommand command = new OracleCommand(sql, connection))
                    {
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string patientId = reader.GetString(reader.GetOrdinal("PATIENT_ID"));
                                string patientPassword = reader.GetString(reader.GetOrdinal("PATIENT_PASSWORD"));

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
        //환자의 PK값 반환
        public decimal get_patient_pk(String id, String pass)
        {
            using (OracleConnection connection = new OracleConnection(conn_info))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT PATIENT_SERIAL_NUMBER FROM PATIENT_LOGIN WHERE PATIENT_ID = :id AND PATIENT_PASSWORD = :pass";

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
                                decimal PK = reader.GetDecimal(reader.GetOrdinal("PATIENT_SERIAL_NUMBER"));
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

        //환자의 정보를 저장
        public void set_patient_info(decimal PK, string name, string gender, int age, string department, int phone, string special_note, string e_mail)
        {

            using (OracleConnection conn = new OracleConnection(conn_info))
            {
                conn.Open();

                string sql = "INSERT INTO JUNG02.PATIENT_INFO " +
                     "(PATIENT_SERIAL_NUMBER, PATIENT_NAME, PATIENT_AGE, PATIENT_GENDER, " +
                     "PATIENT_DEPARTMENT, PATIENT_PHONE_NUMBER, PATIENT_EMAIL, PATIENT_SPECIAL_NOTES) " +
                     "VALUES (:patientSerialNumber, :name, :age, :gender, :department, :phoneNumber, :email, :specialNotes)";

                using (OracleCommand cmd = new OracleCommand(sql, conn))
                {

                    cmd.Parameters.Add(":patientSerialNumber", OracleDbType.Decimal).Value = PK;
                    cmd.Parameters.Add(":name", OracleDbType.Varchar2).Value = name;
                    cmd.Parameters.Add(":age", OracleDbType.Int32).Value = age;
                    cmd.Parameters.Add(":gender", OracleDbType.Varchar2).Value = gender;
                    cmd.Parameters.Add(":department", OracleDbType.Varchar2).Value = department;
                    cmd.Parameters.Add(":phoneNumber", OracleDbType.Int32).Value = phone;
                    cmd.Parameters.Add(":email", OracleDbType.Varchar2).Value = e_mail;
                    cmd.Parameters.Add(":specialNotes", OracleDbType.Varchar2).Value = special_note;

                    cmd.ExecuteNonQuery();
                }
            }
        }

    }

}