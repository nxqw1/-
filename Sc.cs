using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp2
{
    public class Sc
    {
        public string Cno { get; set; }
        public string Cname { get; set; }
        public string Tno { get; set; }
        public string Tname { get; set; }
        public string Ccredit { get; set; }

        public static List<Sc> SelectSc(string cname)
        {
            List<Sc> list = new List<Sc>();
            string sql = "select cno,cname,course.tno,tname,ccredit from course,teacher " +
                "where course.tno=teacher.tno and cname like :cname";
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
                    Sc s = new Sc();
                    s.Cno = odr.GetString(0);
                    s.Cname = odr.GetString(1);
                    s.Tno = odr.GetString(2);
                    s.Tname = odr.GetString(3);
                    s.Ccredit = odr.GetString(4);
                    list.Add(s);
                }
            }
            finally
            {
                con.Close();
            }
            return list;
        }
        public static int DeleteSc(string cno)
        {
            int result = 0;
            string sql = "delete from sc where sno=:sno and cno=:cno";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":sno",OracleDbType.Varchar2,9),
                new OracleParameter(":cno",OracleDbType.Varchar2,4)
            };
            para[0].Value = Frmlogin.loginName;
            para[1].Value = cno;
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
        public static int InsertSc(Sc c)
        {
            string sql = "insert into Sc(sno,cno,grade) values(:sno,:cno,:grade)";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":sno",OracleDbType.Varchar2,9),
                new OracleParameter(":cno",OracleDbType.Varchar2,4),
                new OracleParameter(":grade",OracleDbType.Int16),
            };
            para[0].Value = Frmlogin.loginName;
            para[1].Value = c.Cno;
            para[2].Value = null;
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
