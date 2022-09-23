using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp2
{
    public class Course
    {
        public string Cno{ get; set; }
        public string Cname { get; set; }
        public string Tno { get; set; }
        public int Ccredit { get; set; }
        public static List<Course> SelectCourse(string cname)
        {
            List<Course> list = new List<Course>();
            string sql = "select cno,cname,tno,ccredit from course where cname like :cname";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":cname",OracleDbType.Varchar2,4)
            };
            para[0].Value = cname + "%";
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                OracleDataReader odr = cmd.ExecuteReader();
                while (odr.Read())
                {
                    Course c = new Course();
                    c.Cno = odr.GetString(0);
                    c.Cname = odr.GetString(1);
                    c.Tno = odr.GetString(2);
                    c.Ccredit = odr.GetInt16(3);
                    list.Add(c);
                }
            }
            finally
            {
                con.Close();
            }
            return list;
        }

        public static int DeleteCourse(string cno)
        {
            int result = 0;
            string sql = "delete from course where cno=:cno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":cno",OracleDbType.Varchar2,4)
            };
            para[0].Value = cno;
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            return result;
        }
        public static int UpdateCourse(Course c)
        {
            string sql = "update course set cname=:cname,tno=:tno,ccredit=:ccredit where cno=:cno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":cname",OracleDbType.Varchar2,40),
                new OracleParameter(":tno",OracleDbType.Varchar2,4),
                new OracleParameter(":ccredit",OracleDbType.Int16),
                new OracleParameter(":cno",OracleDbType.Varchar2,4),
            };
            para[0].Value = c.Cname;
            if (string.IsNullOrEmpty(c.Tno))
                para[1].Value = DBNull.Value;
            else para[1].Value = c.Tno;
            para[2].Value = c.Ccredit;
            para[3].Value = c.Cno;
            int result = 0;
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public static int InsertCourse(Course c)
        {
            string sql = "insert into course(cno,cname,tno,ccredit) values(:cno,:cname,:tno,:ccredit)";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":cno",OracleDbType.Varchar2,4),
                new OracleParameter(":cname",OracleDbType.Varchar2,40),
                new OracleParameter(":tno",OracleDbType.Varchar2,4),
                new OracleParameter(":ccredit",OracleDbType.Int16),
            };
            para[0].Value = c.Cno;
            para[1].Value = c.Cname;
            if (string.IsNullOrEmpty(c.Tno))
                para[2].Value = DBNull.Value;
            else para[2].Value = c.Tno;
            para[3].Value = c.Ccredit;
            int result = 0;
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                result = cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
            return result;
        }
    }
}
