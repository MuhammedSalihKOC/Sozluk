using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sozluk
{
    public partial class Form1 : Form
    {
        string VT = "provider = microsoft.ace.oledb.12.0;" +
            "data source = soz.accdb";
        public Form1()
        {
            InitializeComponent();
        }

        private void TRtoENG_CheckedChanged(object sender, EventArgs e)
        {
            if (TRtoENG.Checked == true)
            {
                ENGtoTR.Checked = false;
            }
        }

        private void ENGtoTR_CheckedChanged(object sender, EventArgs e)
        {
            if (ENGtoTR.Checked == true)
            {
                TRtoENG.Checked = false;
            }
        }

        private void Cevir_Click(object sender, EventArgs e)
        {
            if (TRtoENG.Checked == true)            
                Cevrilmis.Text = trden_ceviri(Cevrilen.Text);
            else
                Cevrilmis.Text = engden_ceviri(Cevrilen.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sozekle(ekleTR.Text, ekleENG.Text);
        }
        public string trden_ceviri(string kelime)
        {
            string sql = "select eng from sozler where tr = '" + kelime + "'";
            OleDbDataAdapter a = new OleDbDataAdapter(sql, VT);
            DataTable t = new DataTable();
            a.Fill(t);
            if (t.Rows.Count > 0)
                return t.Rows[0][0].ToString();
            else
                return "Kelime Bulunamadı";
        }
        public string engden_ceviri(string kelime)
        {
            string sql = "select tr from sozler where eng = '" + kelime + "'";
            OleDbDataAdapter a = new OleDbDataAdapter(sql, VT);
            DataTable t = new DataTable();
            a.Fill(t);
            if (t.Rows.Count > 0)
                return t.Rows[0][0].ToString();
            else
                return "Kelime Bulunamadı";
        }
        public void sozekle(string tr, string eng)
        {
            string sql = "insert into sozler (tr,eng) values ('"+tr+"','"+eng+"')";
            OleDbConnection baglan = new OleDbConnection(VT);
            OleDbCommand komut = new OleDbCommand(sql, baglan);
            baglan.Open();
            komut.ExecuteNonQuery();
            MessageBox.Show("Eklendi!");
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
