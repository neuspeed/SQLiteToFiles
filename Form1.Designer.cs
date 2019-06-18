namespace SQLiteToFiles
{
    partial class Form1
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
            this.ofdDBOpen = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenDB = new System.Windows.Forms.Button();
            this.btnDBExport = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblDBStatus = new System.Windows.Forms.Label();
            this.fbdTileFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.pbConvertData = new System.Windows.Forms.ProgressBar();
            this.lblConvertData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ofdDBOpen
            // 
            this.ofdDBOpen.FileName = "Data.gmdb";
            // 
            // btnOpenDB
            // 
            this.btnOpenDB.Location = new System.Drawing.Point(24, 39);
            this.btnOpenDB.Name = "btnOpenDB";
            this.btnOpenDB.Size = new System.Drawing.Size(106, 23);
            this.btnOpenDB.TabIndex = 0;
            this.btnOpenDB.Text = "Соединение с БД";
            this.btnOpenDB.UseVisualStyleBackColor = true;
            this.btnOpenDB.Click += new System.EventHandler(this.btnOpenDB_Click);
            // 
            // btnDBExport
            // 
            this.btnDBExport.Location = new System.Drawing.Point(24, 103);
            this.btnDBExport.Name = "btnDBExport";
            this.btnDBExport.Size = new System.Drawing.Size(132, 23);
            this.btnDBExport.TabIndex = 1;
            this.btnDBExport.Text = "Сохранить в папке";
            this.btnDBExport.UseVisualStyleBackColor = true;
            this.btnDBExport.Click += new System.EventHandler(this.btnDBExport_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(23, 74);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(113, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Статус соединения:  ";
            // 
            // lblDBStatus
            // 
            this.lblDBStatus.AutoSize = true;
            this.lblDBStatus.Location = new System.Drawing.Point(142, 74);
            this.lblDBStatus.Name = "lblDBStatus";
            this.lblDBStatus.Size = new System.Drawing.Size(0, 13);
            this.lblDBStatus.TabIndex = 3;
            // 
            // pbConvertData
            // 
            this.pbConvertData.Location = new System.Drawing.Point(24, 132);
            this.pbConvertData.Name = "pbConvertData";
            this.pbConvertData.Size = new System.Drawing.Size(100, 23);
            this.pbConvertData.TabIndex = 4;
            // 
            // lblConvertData
            // 
            this.lblConvertData.AutoSize = true;
            this.lblConvertData.Location = new System.Drawing.Point(130, 138);
            this.lblConvertData.Name = "lblConvertData";
            this.lblConvertData.Size = new System.Drawing.Size(0, 13);
            this.lblConvertData.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 160);
            this.Controls.Add(this.lblConvertData);
            this.Controls.Add(this.pbConvertData);
            this.Controls.Add(this.lblDBStatus);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnDBExport);
            this.Controls.Add(this.btnOpenDB);
            this.Name = "Form1";
            this.Text = "SQLite To Files";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdDBOpen;
        private System.Windows.Forms.Button btnOpenDB;
        private System.Windows.Forms.Button btnDBExport;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblDBStatus;
        private System.Windows.Forms.FolderBrowserDialog fbdTileFolder;
        private System.Windows.Forms.ProgressBar pbConvertData;
        private System.Windows.Forms.Label lblConvertData;
    }
}

