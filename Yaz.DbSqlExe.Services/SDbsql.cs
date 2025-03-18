using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Security.Principal;   //kullanıcı adını almak için kütüphane
using System.Net.Mail;
using System.IO;
using Yaz.Util.MailManagement;
using Yaz.Util.Common.Library;
using Yaz.Util.FSManagement;

namespace Yaz.DbSql.Services
{
    public class SDbsql
    {
        //veri tabanına bağlanıyoruz
        private SqlConnection baglanti;
        void sqlbaglanti()
        {
            string connectionString = "Server=***; Database=***; User Id= ***; Password=***;";
            baglanti = new SqlConnection(connectionString);
            try
            {
                baglanti.Open();
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }
        //execute islemleri icin fonksiyon
        public void Execute(string sql, ref DataTable dtSelect, string op_adi, string domain_name)
        {
            DateTime startTime = DateTime.Now;
            string sqlQuery = sql;
            if (string.IsNullOrEmpty(sqlQuery))
            {
                throw new Exception("Lütfen bir SQL sorgusu girin.");
            }
            using (SqlConnection connection = new SqlConnection("Server=***; Database=***; User Id= ***; Password=***;"))
            {

                try
                {

                    SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    connection.Open();




                    if (sqlQuery.ToUpper().Contains("SELECT"))
                    {

                        adapter.Fill(dt);
                        dtSelect = dt;
                    }
                    else
                    {

                        int rowsAffected = cmd.ExecuteNonQuery();

                    }

                    //Trabzonspor61+
                }

                catch
                {
                    throw new Exception("Yazdığınız script hatalı,dolayısıyla bir işlem yapılmayacak.");


                }
                finally
                {
                    DateTime endTime = DateTime.Now;

                    string execute_time = (endTime - startTime).TotalSeconds.ToString(); // log tut işlemleri
                    logTut(connection, op_adi, sqlQuery, DateTime.Now.ToString(), execute_time, domain_name);
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }
        }
        //log tutma işlemleri
        public void logTut(SqlConnection connection, string op_adi, string sql_query, string sys_date, string execute_time, string domain_name)
        {
            string islemler = "INSERT INTO user_sql_log (op_adi,sql_query,sys_date,execute_time,domain_name) VALUES (@op_adi,@sql_query,@sys_date,@execute_time, @domain_name)";
            using (SqlCommand command = new SqlCommand(islemler, connection))
            {
                command.Parameters.AddWithValue("op_adi", op_adi);
                command.Parameters.AddWithValue("sql_query", sql_query);
                command.Parameters.AddWithValue("sys_date", sys_date);
                command.Parameters.AddWithValue("execute_time", execute_time);
                command.Parameters.AddWithValue("domain_name", domain_name);

                command.ExecuteNonQuery();
            }



        }
        public void txtYazdir(string path)
        {
            path = @"C:\Users\zeynep.emiroglu\Desktop\sql_user_log.txt";
            string query = "select * from user_sql_log ";
            //string query = "SELECT * FROM user_sql_log WHERE CAST(sys_date AS DATE) = CAST(GETDATE() AS DATE)"; sadece günlük olanları almak için

            using (SqlConnection connection = new SqlConnection("Server=***; Database=***; User Id=***; Password=***;"))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    using (StreamWriter writer = new StreamWriter(path)) //txt dosyası oluşturdum ve yolunu girdim
                    {
                        while (reader.Read())
                        {
                            writer.WriteLine($"{reader["op_adi"]}, {reader["sql_query"]}, {reader["sys_date"]}");
                        }
                    }
                }


            }
        }


        public bool otoMail()
        {

            string connectionString = "Server=ARGEDEV; Database=***; User Id=***; Password=***;";
            string query = "SELECT op_adi, sql_query, sys_date FROM user_sql_log";

            DataTable dosyaIcerik = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dosyaIcerik);
            }

            StringBuilder sb = new StringBuilder();

            sb.Append("op_adi".PadRight(35));
            sb.Append("sql_query".PadRight(30));
            sb.Append("sys_date".PadRight(40));
            sb.AppendLine();
            sb.Append(new string('-', 35)); 
            sb.Append(new string('-', 30)); 
            sb.Append(new string('-', 40));

            foreach (DataRow row in dosyaIcerik.Rows)
            {
                sb.Append(row["op_adi"].ToString().PadRight(20));
                sb.Append(row["sql_query"].ToString().PadRight(30));
                sb.Append(Convert.ToDateTime(row["sys_date"]).ToString("yyyy-MM-dd HH:mm:ss").PadRight(15));
                sb.AppendLine();
            }
         
            MailInfo mi = new MailInfo();
            mi.to = "zeynep.emiroglu@yaz.com.tr";
            mi.from = "zeynep.emiroglu@yaz.com.tr";
            mi.body = sb.ToString();  // DataTable'ın içeriğini mail gövdesine ekle
            MailManager.Send(mi);

            return true;
        }




    }

}






//bugün tarihli yapılan bütün işlemlerin 16.30'da bana mail olarak çalıştırılan sql scriptleri ve kimi çalıştırdığı ve saat kaçta çalıştığına dair bir rapor gelsin
//mert.celik@yaz.com.tr  txt.dosyası 