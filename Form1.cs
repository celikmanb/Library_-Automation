using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Kutuphane
{
    public partial class vrbkutuphane : Form
    {
        public vrbkutuphane()
        {
            InitializeComponent();
            fill_table();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void toolStripLabelSave_Click(object sender, EventArgs e)
        {
            panelSave.Visible = true;
            panelShow.Visible = false;
            StartDate.Value = DateTime.Now;
            FinishDate.Value = DateTime.Now;

        }

        private void toolStripLabelShow_Click(object sender, EventArgs e)
        {
            panelSave.Visible = false;
            panelShow.Visible = true;
            fill_table();
            //dataGridView1.ReadOnly = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            StartDate.Value = DateTime.Now;
            FinishDate.Value = DateTime.Now;
            SqlConnection connect = new SqlConnection(@"Data Source=.;Initial Catalog=kutuphane;Integrated Security=True");
            SqlCommand com = new SqlCommand("INSERT INTO Book(Name,Writer,StartDate,FinalDate,Image) VALUES('" + txtName.Text +
                "','" + txtWriter.Text + "','" + StartDate.Value + "','" + FinishDate.Value + "','Image/" + file_name + "')", connect);
            /*com.Connection = connect;
            com.CommandText = "INSERT INTO dbo.Book(Name,Writer,StartDate,FinalDate,Image) VALUES(@name,@writer,@startDate,@finalDate,@image)";
            com.Parameters.Add("@name", SqlDbType.NVarChar);
            com.Parameters["@name"].Value = txtName.Text.Trim();
            com.Parameters.Add("@writer", SqlDbType.NVarChar);
            com.Parameters["@writer"].Value = txtWriter.Text.Trim();
            com.Parameters.Add("@startDate", SqlDbType.Time);
            com.Parameters["@startDate"].Value = Convert.ToDateTime(StartDate.Value) ;
            com.Parameters.Add("@finalDate", SqlDbType.Time);
            com.Parameters["@finalDate"].Value = Convert.ToDateTime(FinishDate.Value);*/

            connect.Open();
            com.ExecuteNonQuery();
            connect.Close();

            del_box();
            fill_table();

        }
        private void del_box()
        {
            txtName.Text = "";
            txtWriter.Text = "";
            StartDate.Value = DateTime.Now;
            FinishDate.Value = DateTime.Now;
        }
        private void fill_table()
        {
            SqlConnection connect = new SqlConnection("Server =.; Database =kutuphane; Integrated Security = True");
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Book", connect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            connect.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        string file_name = "";
        private void butonolarakkal_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.* ";
                string file_path = "";

                file_path = openFileDialog1.FileName;
                file_name = openFileDialog1.SafeFileName;
                string file = file_name;

                if (Directory.Exists(@"Image"))
                {
                    if (!File.Exists(@"Image/" + file_name))
                    {
                        File.Copy(@file_path, @"Image/" + file_name);
                    }


                }
                else
                {
                    Directory.CreateDirectory("Image");
                    if (!File.Exists(@"Image/" + file_name))
                    {
                        File.Copy(@file_path, @"Image/" + file_name);
                    }
                }

            }
        }

        // Data Source = DESKTOP - 4V2GHSG;Initial Catalog = kutuphane; Integrated Security = True
    }
}
