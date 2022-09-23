using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Insertgrade
    {
        public string Sno { get; set; }
        public string Sname { get; set; }
        public string Cno { get; set; }
        public string Cname { get; set; }
        public string Ccredit { get; set; }
        public string Grade { get; set; }
        public static List<Insertgrade> SelectInsertgrade(string sno)
        {
            List<Insertgrade> list = new List<Insertgrade>();
            string sql = "select student.sno,student.sname,course.cno,course.cname,course.ccredit,sc.grade from student,course,sc where sc.cno=course.cno and student.sno=sc.sno and student.sno like :sno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":sno",OracleDbType.Varchar2,20)
            };
            para[0].Value = sno +'%';
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                OracleDataReader odr = cmd.ExecuteReader();
                while (odr.Read())
                {
                    Insertgrade c = new Insertgrade();
                    c.Sno = odr.GetString(0);
                    c.Sname = odr.GetString(1);
                    c.Cno = odr.GetString(2);
                    c.Cname = odr.GetString(3);
                    c.Ccredit = odr.GetString(4);
                    if (odr.IsDBNull(5)) c.Grade = null;
                    else c.Grade = odr.GetString(5);
                    list.Add(c);
                }
            }
            finally
            {
                con.Close();
            }
            return list;
        }
        public static int InsertInsertgrade(Insertgrade c)
        {
            string sql = "update sc set grade=:grade where sno=:sno and cno=:cno ";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":grade",OracleDbType.Varchar2,20),
                new OracleParameter(":sno",OracleDbType.Varchar2,20),
                new OracleParameter(":cno",OracleDbType.Varchar2,20),

            };
            para[0].Value = c.Grade;
            para[1].Value = c.Sno;
            para[2].Value = c.Cno;
            
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
