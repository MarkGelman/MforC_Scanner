using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MforC_Scanner
{
    public partial class frmToPickCloud : Form
    {
        string conn_string = "Server =localhost;Port=5432;Database=DB_Cohar;User Id = postgres;Password=admin";
        Image image;
        public frmToPickCloud()
        {
            InitializeComponent();
        }

        private void btnLoadfromScanner_Click(object sender, EventArgs e)
        {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Файлы изображений|*.bmp;*.png;*.jpg";
                if (openDialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    image = Image.FromFile(openDialog.FileName);
                }
                catch (OutOfMemoryException ex)
                {
                    MessageBox.Show("Ошибка чтения картинки");
                    return;
                }

                  
        }

        private void frmToPickCloud_Load(object sender, EventArgs e)
        {
            if(TestDBConnection(conn_string))
            {
                try
                {
                   // List<Dictionary<string, object>> Run_sp(string conn_string, string sp_name,NpgsqlParameter[] parameters)                                                         
                    
                       List<Dictionary<string, object>> items = new List<Dictionary<string, object>>();

                    using (var conn = new NpgsqlConnection(conn_string))
                    {
                        conn.Open();

                        NpgsqlCommand command = new NpgsqlCommand("sp_students", conn);
                        command.CommandType = System.Data.CommandType.StoredProcedure; // this is default

                        //используя AddRange мы можем сразу передать СП полученый массив параметров
                        //command.Parameters.AddRange(parameters);

                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Dictionary<string, object> one_row = new Dictionary<string, object>();
                            foreach (var item in reader.GetColumnSchema())
                            {
                                object column_value = reader[item.ColumnName];
                                one_row.Add(item.ColumnName, column_value);
                            }
                            items.Add(one_row);
                        }
                    }
                 
                }
                catch
                {
                    Console.WriteLine(ex);
                    Console.WriteLine($"Function {sp_name} failed. parameters: {string.Join(",", parameters.Select(_ => _.ParameterName + " : " + _.Value))}");
                }
            }

            else
            {
                Console.WriteLine("Connection failed!!!");
                Console.ReadKey();
            }
           
        }

        bool TestDBConnection (string conn_string)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(conn_string))
                {
                    conn.Open();
                }
                return true;
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
