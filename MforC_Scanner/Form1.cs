using Npgsql;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MforC_Scanner
{
    public partial class frmToPickCloud : Form
    {
        string conn_string = "Server =localhost;Port=5432;Database=DB_Cohar;User Id = postgres;Password=admin";
        int count = 0;
        string folderToSave = "צוהר";
        string kodDocument;
        string directory;
        string fileName;
        List<string>  images =  new List<string>();
        Dictionary<string, Dictionary<string, DataForSave>> dataForSaveById_Kod = new Dictionary<string, Dictionary<string, DataForSave>>();
        Dictionary<string,  DataForSave> dataForSaveByDate = new Dictionary<string, DataForSave>();
        Dictionary<string, DataForSave> dataForSaveByKod = new Dictionary<string, DataForSave>();
        Dictionary<string, DataForSave> dataForSaveByFirst_Name = new Dictionary<string, DataForSave>();
        Dictionary<string, DataForSave> dataForSaveByLast_Name = new Dictionary<string, DataForSave> ();
        Dictionary<string, DataForSave> dataForSaveById = new Dictionary<string, DataForSave>();

        string image;
        public frmToPickCloud()
        {
            InitializeComponent();
        }

       
        private void frmToPickCloud_Load(object sender, EventArgs e)
        {
            if(TestDBConnection(conn_string))
            {
                try
                {
                    images.AddRange( Directory.GetFiles("C:\\Users\\USER\\Pictures\\PhotoFromScann\\"));

                    List<Dictionary<string, object>> items = new List<Dictionary<string, object>>();

                    using (var conn = new NpgsqlConnection(conn_string))
                    {
                        conn.Open();

                        NpgsqlCommand command = new NpgsqlCommand("sp_students_for_scan_documents", conn);
                        command.CommandType = System.Data.CommandType.StoredProcedure; // this is default
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT id,first_name,last_name FROM students", conn);
                        DataTable tb = new DataTable();
                        adapter.Fill(tb);
                        dgvTableStudents.DataSource = tb;
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
                                switch (item.ColumnName)
                                {
                                    case "_id": cmbId.Items.Add(column_value.ToString()); break;
                                    case "_first_name": cmbName.Items.Add(column_value.ToString()); break;
                                    case "_last_name": cmbLastName.Items.Add(column_value.ToString()); break;
                                }
                            }
                            items.Add(one_row);
                        }
                    }

                  
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"{ex}");
                    //Console.WriteLine($"Function {sp_name} failed. parameters: {string.Join(",", parameters.Select(_ => _.ParameterName + " : " + _.Value))}");
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

        private void btnLoadfromScanner_Click(object sender, EventArgs e)
        {
            image = images[count];
            picDocument.Image = new Bitmap(image);
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (image !="" && count != images.Count()-1)
            {
                count++;
                image = images[count];
                picDocument.Image = new Bitmap(image);
            }
        } 

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvTableStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdStudent.Text       = dgvTableStudents.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtNameStudent.Text     = dgvTableStudents.Rows[e.RowIndex].Cells["first_name"].Value.ToString().Replace("\t", "");
            txtLastNameStudent.Text     = dgvTableStudents.Rows[e.RowIndex].Cells["last_name"].Value.ToString().Replace("\t", "");
            cmbTypeDocument.Text    = "601";
        }

        private void btnLoadToDictionary_Click(object sender, EventArgs e)
        {

            DataForSave dataSave = new DataForSave
            {

                Id = txtIdStudent.Text.ToString(),
                First_Name = txtNameStudent.Text.ToString(),
                Last_Name = txtLastNameStudent.Text.ToString(),
                Date = pickerDateDocument.Value.ToString().Remove(10).Replace("/", ""),
                KodDocument = cmbTypeDocument.Text.ToString(),
                Image = images[count]
            };
            dataForSaveByKod.Add(dataSave.KodDocument, dataSave);
            dataForSaveById.Add(dataSave.Id, dataSave);
            dataForSaveByFirst_Name.Add(dataSave.First_Name, dataSave);
            dataForSaveByLast_Name.Add(dataSave.Last_Name, dataSave);
            dataForSaveByDate.Add(dataSave.Date, dataSave);
            dataForSaveById_Kod.Add(dataSave.Id, dataForSaveByKod);
        }
       
        private void btnToPDF_Click(object sender, EventArgs e)
        {
            PdfDocument document = new PdfDocument();
            //document.Info.Title = "Created using PDFsharp";
            
            foreach (KeyValuePair<string,Dictionary<string, DataForSave>> id in dataForSaveById_Kod)
            {
               
                    PdfPage page = document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);

                    foreach (KeyValuePair<string, DataForSave> item in dataForSaveByKod)
                    {
                        System.Drawing.Image img = System.Drawing.Image.FromFile(item.Value.Image);
                        page.Width = img.Width/4;
                        page.Height = img.Height/4;
                        DrawImage(gfx, item.Value.Image, 0, 0, (int)page.Width, (int)page.Height);
                        kodDocument = item.Key;
                    }
                   
                    /* 
                     * PdfPage page = document.AddPage();
                     int StartX = 0 - (int)page.Width / 2;
                     int StartY = 0 - (int)page.Height / 2;
                     XGraphics gfx = XGraphics.FromPdfPage(page);

                     foreach (KeyValuePair<string,DataForSave> item in dataForSaveByKod)
                     {
                         DrawImage(gfx, item.Value.Image, StartX, StartY, (int)page.Width * 2, (int)page.Height * 2);
                         StartX += (int)page.Width / 2;
                         StartY += (int)page.Height / 2;
                         kodDocument = item.Key;
                     }
                    */
                foreach (KeyValuePair<string,DataForSave> item in dataForSaveById)
                {
                    if (item.Key == id.Key)
                        if (document.PageCount > 0)
                        {
                            directory = $"C:\\{folderToSave}\\{item.Value.Last_Name}_{item.Value.First_Name}_{item.Value.Id}";
                            fileName = $"\\{item.Value.Id}-{kodDocument}-{item.Value.Date}.pdf";
                            if (!(Directory.Exists(directory)))
                            {
                                Directory.CreateDirectory(directory);
                            }
                            string path = directory+ fileName;
                            FileInfo fi = new FileInfo(path);
                            if (!(fi.Exists))
                            {
                                using (FileStream fs = fi.Create())
                                {
                                   
                                }
                            }
                            document.Save(directory + fileName);       
                        }
                    
                }
            }
            void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
            {
                XImage image = XImage.FromFile(jpegSamplePath);
                gfx.DrawImage(image, x, y, width, height);
            }

        }
    }
}
