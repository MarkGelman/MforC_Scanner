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
        string dateDocument;
        string directory;
        string fileName;
        DataForSave dataSave ;
        List<string>  images =  new List<string>();
        List<DataForSave> dataSaveList = new List<DataForSave>();
        Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, List<DataForSave>>>>> dataForSaveById_Kod = new Dictionary<string, Dictionary<string, Dictionary<string, Dictionary<string, List<DataForSave>>>>>();
        Dictionary<string, List<DataForSave>> dataForSaveById_Kod_Date = new Dictionary<string, List<DataForSave>>();
        Dictionary<string, List<DataForSave>> dataForSaveByDate = new Dictionary<string, List<DataForSave>>();
        Dictionary<string, List<DataForSave>> dataForSaveByKod = new Dictionary<string, List<DataForSave>>();
        Dictionary<string, List<DataForSave>> dataForSaveByFirst_Name = new Dictionary<string, List<DataForSave>>();
        Dictionary<string, List<DataForSave>> dataForSaveByLast_Name = new Dictionary<string, List<DataForSave>> ();
        Dictionary<string, List<DataForSave>> dataForSaveById = new Dictionary<string, List<DataForSave>>();

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
           
           dataSave = new DataForSave
            {

                Id = txtIdStudent.Text.ToString(),
                First_Name = txtNameStudent.Text.ToString(),
                Last_Name = txtLastNameStudent.Text.ToString(),
                Date = pickerDateDocument.Value.ToString().Remove(10).Replace("/", ""),
                KodDocument = cmbTypeDocument.Text.ToString(),
                Image = images[count]
            };
            dataSaveList.Add(dataSave);
        }
       
        private void btnToPDF_Click(object sender, EventArgs e)
        {
                dataForSaveByKod.Add(dataSave.KodDocument, dataSaveList);
                dataForSaveById.Add(dataSave.Id, dataSaveList);
                dataForSaveByFirst_Name.Add(dataSave.First_Name, dataSaveList);
                dataForSaveByLast_Name.Add(dataSave.Last_Name, dataSaveList);
                dataForSaveByDate.Add(dataSave.Date, dataSaveList);
              
                
           
           foreach (KeyValuePair<string, List<DataForSave>> i in dataForSaveById)
            {
                List<DataForSave> convertToPDf = new List<DataForSave>();
                PdfDocument document = new PdfDocument();
                
               
                foreach (KeyValuePair<string, List<DataForSave>> k in dataForSaveByKod)
                {
                   convertToPDf = k.Value.Where(_ => _.Id == i.Key).ToList();
                   
                    foreach (KeyValuePair<string, List<DataForSave>> d in dataForSaveByDate)
                    {
                        convertToPDf = convertToPDf.Where(o => o.Date == d.Key).ToList();
                        int sy = 0;
                        foreach (DataForSave image in convertToPDf)
                        {
                            PdfPage page = document.AddPage();
                            XGraphics gfx = XGraphics.FromPdfPage(page);
                            System.Drawing.Image img = System.Drawing.Image.FromFile(image.Image);
                            page.Width = img.Width / 4;
                            page.Height = img.Height / 4;
                            DrawImage(gfx, image.Image, 0, 0, (int)page.Width, (int)page.Height);
                           // kodDocument = item.Key;
                        }
                        if (document.PageCount > 0)
                        {
                            directory = $"C:\\{folderToSave}\\{convertToPDf[0].Last_Name}_{convertToPDf[0].First_Name}_{convertToPDf[0].Id}";
                            fileName = $"\\{convertToPDf[0].Id}-{convertToPDf[0].KodDocument}-{convertToPDf[0].Date}.pdf";
                            if (!(Directory.Exists(directory)))
                            {
                                Directory.CreateDirectory(directory);
                            }
                            string path = directory + fileName;
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
            }
                
                    
                    
            void DrawImage(XGraphics gfx, string jpegSamplePath, int x, int y, int width, int height)
            {
                XImage image = XImage.FromFile(jpegSamplePath);
                gfx.DrawImage(image, x, y, width, height);
            }

        }
    }
}
