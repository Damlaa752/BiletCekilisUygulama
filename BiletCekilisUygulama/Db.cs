using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BiletCekilisUygulama
{
    internal  class Db
    {
        SqlConnection conn = new SqlConnection("Server =103S-10\\MSSQLSERVER01; Database = Cekilis; Trusted_Connection = true");
        SqlDataAdapter da ;
        DataTable dt ; 
        DataSet ds ;
        SqlCommand cmd ; 
        SqlDataReader dr ; 

        string cmdText;
        Form1 f;
        Form2 f2= (Form2)Application.OpenForms["Form2"];

        public void GridFill()
        {
            f = (Form1)Application.OpenForms["Form1"];
            conn.Open();
            cmdText = $"select Ad,Soyad,BiletNo from Cekilis ";
            da = new SqlDataAdapter(cmdText,conn);
            ds=new DataSet();
            da.Fill(ds);
            f.dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
           
        }
        public void AddPerson(string name, string surname, string biletNo)
        {
            conn.Open();
            cmdText = $"insert Cekilis( Ad, Soyad, BiletNo)\r\n values ('{name}','{surname}','{biletNo}')";

            cmd = new SqlCommand(cmdText,conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void VeriCekme(int biletNo)
        {
            conn.Open();
            cmdText = $"select Ad, Soyad from Cekilis\r\n where biletNo='{biletNo}'";

            cmd = new SqlCommand(cmdText, conn);
            dr = cmd.ExecuteReader();
            while(dr.Read()) 
                {
                f2.txtSahipAdi.Text = dr[0].ToString();
                f2.txtSahipSoyadi.Text = dr[1].ToString();
                }

            conn.Close();
        }
    }
}
