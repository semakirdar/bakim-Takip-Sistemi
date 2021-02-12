using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakimTakipProgrami
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection();
        public static string Database = @"server=DESKTOP-C3JB3BU\SQLEXPRESS;Database=BakimTakip;user=sa;pwd=12345;";
        public static int gonderilecekyetki;
        public static string gonderilecekveri;
        public static int gonderilecekveri2;
        public static string kullanici_bilgi;
        private void frmGiris_Load(object sender, EventArgs e)
        {
            try
            {
                if (DBConnectionStatus())
                {
                    cnn.ConnectionString = Database;
                    txtSifre.Focus();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private static bool DBConnectionStatus()
        {
            try
            {
                using (SqlConnection sqlconn = new SqlConnection(Database))
                {
                    sqlconn.Open();
                    return (sqlconn.State == ConnectionState.Open);
                }
            }
            catch (SqlException)
            {

                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                    cnn.Open();
                }
                else
                {
                    cnn.Open();
                }
                SqlParameter prm1 = new SqlParameter("@P1", txtKullanici.Text);
                SqlParameter prm2 = new SqlParameter("@P2", txtSifre.Text);
                string sql = "";
                sql = "SELECT * FROM kullanicilar WHERE KullaniciAdi=@P1 and KullaniciSifre=@P2";
                SqlCommand cmd = new SqlCommand(sql, cnn);

                cmd.Parameters.Add(prm1);
                cmd.Parameters.Add(prm2);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gonderilecekyetki = Convert.ToInt32(dt.Rows[0]["KullaniciGrup"]);
                gonderilecekveri2 = Convert.ToInt32(dt.Rows[0]["KullaniciID"]);



                cnn.Close();

                if (dt.Rows.Count > 0)
                {
                    
                    gonderilecekveri = "Bakım Takip Programı - Kullanıcı:" + txtKullanici.Text;

                    kullanici_bilgi = txtKullanici.Text;

                    frmMenu frm = new frmMenu();
                    frm.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("kullanıcı adı ve şifre yanlış");
                }
            }
            catch
            {
                MessageBox.Show("hata oluştu");
            
        }

    }

        private void frmGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
