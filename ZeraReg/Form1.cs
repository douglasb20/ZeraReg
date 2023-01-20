using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ZeraReg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn  = new SqlConnection(@"Data Source=" + txthost.Text + ";Initial Catalog=ETrade; User ID=" + txtuser.Text + ";Password=" + txtpass.Text);
                SqlCommand cmd      = new SqlCommand("", conn);
                cmd.CommandText     = @"update Configuracao set valor='' where config='lib' or config='reg' ";

                conn.Open();
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Dispose();
                MessageBox.Show("Registro zerado com sucesso.","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
