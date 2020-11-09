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
    public partial class Form2 : Form
    {
        string VT = "provider = microsoft.ace.oledb.12.0;" +
            "data source = soz.accdb";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cek();            
        }
        void cek()
        {
            string sql = "select * from sozler";
            OleDbDataAdapter a = new OleDbDataAdapter(sql, VT);
            DataTable t = new DataTable();
            a.Fill(t);
            for (int i = 0; i < t.Rows.Count; i++)
            {
                liste.Items.Add(t.Rows[i][1].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete from sozler where tr = '" + liste.SelectedItem.ToString() + "'";
                OleDbConnection baglan = new OleDbConnection(VT);
                baglan.Open();
                OleDbCommand kom = new OleDbCommand(sql, baglan);
                kom.ExecuteNonQuery();
                temizle();
                cek();
            }
            catch 
            {
                temizle();
                cek();
            }
        }
        void temizle()
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(600);
            liste.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
