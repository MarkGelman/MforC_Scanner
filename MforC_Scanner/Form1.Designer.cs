
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnToPDF = new System.Windows.Forms.Button();
            this.dgvTableStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTableStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // picDocument
            // 
            this.picDocument.Location = new System.Drawing.Point(12, 2);
            this.picDocument.Name = "picDocument";
            this.picDocument.Size = new System.Drawing.Size(559, 647);
            this.picDocument.TabIndex = 0;
            this.picDocument.TabStop = false;
            // 
            // btnLoadfromScanner
            // 
            this.btnLoadfromScanner.Location = new System.Drawing.Point(815, 2);
            this.btnLoadfromScanner.Name = "btnLoadfromScanner";
            this.btnLoadfromScanner.Size = new System.Drawing.Size(121, 30);
            this.btnLoadfromScanner.TabIndex = 1;
            this.btnLoadfromScanner.Text = "SCAN";
            this.btnLoadfromScanner.UseVisualStyleBackColor = true;
            this.btnLoadfromScanner.Click += new System.EventHandler(this.btnLoadfromScanner_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(878, 39);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(58, 30);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "הקודם";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(815, 39);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(58, 30);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "הבא";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(815, 75);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(688, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(815, 111);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(942, 111);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // btnToPDF
            // 
            this.btnToPDF.Location = new System.Drawing.Point(815, 616);
            this.btnToPDF.Name = "btnToPDF";
            this.btnToPDF.Size = new System.Drawing.Size(121, 23);
            this.btnToPDF.TabIndex = 9;
            this.btnToPDF.Text = " המרה לPDF";
            this.btnToPDF.UseVisualStyleBackColor = true;
            // 
            // dgvTableStudents
            // 
            this.dgvTableStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTableStudents.Location = new System.Drawing.Point(601, 159);
            this.dgvTableStudents.Name = "dgvTableStudents";
            this.dgvTableStudents.Size = new System.Drawing.Size(543, 434);
            this.dgvTableStudents.TabIndex = 10;
            // 
            // frmToPickCloud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 661);
            this.Controls.Add(this.dgvTableStudents);
            this.Controls.Add(this.btnToPDF);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox picDocument;
        private System.Windows.Forms.Button btnLoadfromScanner;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnToPDF;
        private System.Windows.Forms.DataGridView dgvTableStudents;
    }
}

