
namespace MforC_Scanner
{
    partial class frmToPickCloud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picDocument = new System.Windows.Forms.PictureBox();
            this.btnLoadfromScanner = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pickerDateDocument = new System.Windows.Forms.DateTimePicker();
            this.cmbLastName = new System.Windows.Forms.ComboBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.cmbId = new System.Windows.Forms.ComboBox();
            this.btnToPDF = new System.Windows.Forms.Button();
            this.dgvTableStudents = new System.Windows.Forms.DataGridView();
            this.btnLoadToDictionary = new System.Windows.Forms.Button();
            this.cmbTypeDocument = new System.Windows.Forms.ComboBox();
            this.txtIdStudent = new System.Windows.Forms.TextBox();
            this.lblDateDocument = new System.Windows.Forms.Label();
            this.lblTypeDocument = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNameStudent = new System.Windows.Forms.TextBox();
            this.lblNameStudent = new System.Windows.Forms.Label();
            this.txtLastNameStudent = new System.Windows.Forms.TextBox();
            this.lblLastNameStudent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // picDocument
            // 
            this.picDocument.Location = new System.Drawing.Point(710, 48);
            this.picDocument.Name = "picDocument";
            this.picDocument.Size = new System.Drawing.Size(434, 601);
            this.picDocument.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDocument.TabIndex = 0;
            this.picDocument.TabStop = false;
            // 
            // btnLoadfromScanner
            // 
            this.btnLoadfromScanner.Location = new System.Drawing.Point(1023, 12);
            this.btnLoadfromScanner.Name = "btnLoadfromScanner";
            this.btnLoadfromScanner.Size = new System.Drawing.Size(121, 30);
            this.btnLoadfromScanner.TabIndex = 1;
            this.btnLoadfromScanner.Text = "SCAN";
            this.btnLoadfromScanner.UseVisualStyleBackColor = true;
            this.btnLoadfromScanner.Click += new System.EventHandler(this.btnLoadfromScanner_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(895, 12);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(58, 30);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "הקודם";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(959, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(58, 30);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "הבא";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pickerDateDocument
            // 
            this.pickerDateDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pickerDateDocument.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pickerDateDocument.Location = new System.Drawing.Point(25, 58);
            this.pickerDateDocument.Name = "pickerDateDocument";
            this.pickerDateDocument.RightToLeftLayout = true;
            this.pickerDateDocument.Size = new System.Drawing.Size(121, 22);
            this.pickerDateDocument.TabIndex = 4;
            // 
            // cmbLastName
            // 
            this.cmbLastName.FormattingEnabled = true;
            this.cmbLastName.Location = new System.Drawing.Point(309, 18);
            this.cmbLastName.Name = "cmbLastName";
            this.cmbLastName.Size = new System.Drawing.Size(121, 21);
            this.cmbLastName.TabIndex = 6;
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(436, 18);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(121, 21);
            this.cmbName.TabIndex = 7;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbId
            // 
            this.cmbId.FormattingEnabled = true;
            this.cmbId.Location = new System.Drawing.Point(563, 18);
            this.cmbId.Name = "cmbId";
            this.cmbId.Size = new System.Drawing.Size(121, 21);
            this.cmbId.TabIndex = 8;
            // 
            // btnToPDF
            // 
            this.btnToPDF.Location = new System.Drawing.Point(25, 258);
            this.btnToPDF.Name = "btnToPDF";
            this.btnToPDF.Size = new System.Drawing.Size(121, 23);
            this.btnToPDF.TabIndex = 9;
            this.btnToPDF.Text = " המרה לPDF";
            this.btnToPDF.UseVisualStyleBackColor = true;
            this.btnToPDF.Click += new System.EventHandler(this.btnToPDF_Click);
            // 
            // dgvTableStudents
            // 
            this.dgvTableStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableStudents.Location = new System.Drawing.Point(295, 49);
            this.dgvTableStudents.Name = "dgvTableStudents";
            this.dgvTableStudents.Size = new System.Drawing.Size(409, 600);
            this.dgvTableStudents.TabIndex = 10;
            this.dgvTableStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableStudents_CellClick);
            // 
            // btnLoadToDictionary
            // 
            this.btnLoadToDictionary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLoadToDictionary.Location = new System.Drawing.Point(25, 194);
            this.btnLoadToDictionary.Name = "btnLoadToDictionary";
            this.btnLoadToDictionary.Size = new System.Drawing.Size(125, 31);
            this.btnLoadToDictionary.TabIndex = 11;
            this.btnLoadToDictionary.Text = "Load";
            this.btnLoadToDictionary.UseVisualStyleBackColor = true;
            this.btnLoadToDictionary.Click += new System.EventHandler(this.btnLoadToDictionary_Click);
            // 
            // cmbTypeDocument
            // 
            this.cmbTypeDocument.FormattingEnabled = true;
            this.cmbTypeDocument.Location = new System.Drawing.Point(25, 86);
            this.cmbTypeDocument.Name = "cmbTypeDocument";
            this.cmbTypeDocument.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeDocument.TabIndex = 12;
            // 
            // txtIdStudent
            // 
            this.txtIdStudent.Location = new System.Drawing.Point(25, 113);
            this.txtIdStudent.Name = "txtIdStudent";
            this.txtIdStudent.Size = new System.Drawing.Size(121, 20);
            this.txtIdStudent.TabIndex = 13;
            // 
            // lblDateDocument
            // 
            this.lblDateDocument.AutoSize = true;
            this.lblDateDocument.Location = new System.Drawing.Point(167, 65);
            this.lblDateDocument.Name = "lblDateDocument";
            this.lblDateDocument.Size = new System.Drawing.Size(81, 13);
            this.lblDateDocument.TabIndex = 14;
            this.lblDateDocument.Text = "תאריך המסמך:";
            // 
            // lblTypeDocument
            // 
            this.lblTypeDocument.AutoSize = true;
            this.lblTypeDocument.Location = new System.Drawing.Point(167, 89);
            this.lblTypeDocument.Name = "lblTypeDocument";
            this.lblTypeDocument.Size = new System.Drawing.Size(66, 13);
            this.lblTypeDocument.TabIndex = 15;
            this.lblTypeDocument.Text = "סוג המסמך:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(167, 116);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 13);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "תעודת זהות התלמיד:";
            // 
            // txtNameStudent
            // 
            this.txtNameStudent.Location = new System.Drawing.Point(25, 139);
            this.txtNameStudent.Name = "txtNameStudent";
            this.txtNameStudent.Size = new System.Drawing.Size(121, 20);
            this.txtNameStudent.TabIndex = 17;
            // 
            // lblNameStudent
            // 
            this.lblNameStudent.AutoSize = true;
            this.lblNameStudent.Location = new System.Drawing.Point(167, 142);
            this.lblNameStudent.Name = "lblNameStudent";
            this.lblNameStudent.Size = new System.Drawing.Size(69, 13);
            this.lblNameStudent.TabIndex = 18;
            this.lblNameStudent.Text = "שם התלמיד:";
            // 
            // txtLastNameStudent
            // 
            this.txtLastNameStudent.Location = new System.Drawing.Point(25, 165);
            this.txtLastNameStudent.Name = "txtLastNameStudent";
            this.txtLastNameStudent.Size = new System.Drawing.Size(121, 20);
            this.txtLastNameStudent.TabIndex = 19;
            // 
            // lblLastNameStudent
            // 
            this.lblLastNameStudent.AutoSize = true;
            this.lblLastNameStudent.Location = new System.Drawing.Point(167, 171);
            this.lblLastNameStudent.Name = "lblLastNameStudent";
            this.lblLastNameStudent.Size = new System.Drawing.Size(109, 13);
            this.lblLastNameStudent.TabIndex = 20;
            this.lblLastNameStudent.Text = "שם משפחה התלמיד:";
            // 
            // frmToPickCloud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 661);
            this.Controls.Add(this.lblLastNameStudent);
            this.Controls.Add(this.txtLastNameStudent);
            this.Controls.Add(this.lblNameStudent);
            this.Controls.Add(this.txtNameStudent);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTypeDocument);
            this.Controls.Add(this.lblDateDocument);
            this.Controls.Add(this.txtIdStudent);
            this.Controls.Add(this.cmbTypeDocument);
            this.Controls.Add(this.btnLoadToDictionary);
            this.Controls.Add(this.dgvTableStudents);
            this.Controls.Add(this.btnToPDF);
            this.Controls.Add(this.cmbId);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.cmbLastName);
            this.Controls.Add(this.pickerDateDocument);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnLoadfromScanner);
            this.Controls.Add(this.picDocument);
            this.Name = "frmToPickCloud";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "העברת מסמכים ל Pick Cloud";
            this.Load += new System.EventHandler(this.frmToPickCloud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDocument;
        private System.Windows.Forms.Button btnLoadfromScanner;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DateTimePicker pickerDateDocument;
        private System.Windows.Forms.ComboBox cmbLastName;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.ComboBox cmbId;
        private System.Windows.Forms.Button btnToPDF;
        private System.Windows.Forms.DataGridView dgvTableStudents;
        private System.Windows.Forms.Button btnLoadToDictionary;
        private System.Windows.Forms.ComboBox cmbTypeDocument;
        private System.Windows.Forms.TextBox txtIdStudent;
        private System.Windows.Forms.Label lblDateDocument;
        private System.Windows.Forms.Label lblTypeDocument;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNameStudent;
        private System.Windows.Forms.Label lblNameStudent;
        private System.Windows.Forms.TextBox txtLastNameStudent;
        private System.Windows.Forms.Label lblLastNameStudent;
    }
}

