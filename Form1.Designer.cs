namespace Kutuphane
{
    partial class vrbkutuphane
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
            this.panelSave = new System.Windows.Forms.Panel();
            this.butonolarakkal = new System.Windows.Forms.Button();
            this.FinishDate = new System.Windows.Forms.DateTimePicker();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.lblWriter = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelShow = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripLabelSave = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelShow = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelSave.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSave
            // 
            this.panelSave.Controls.Add(this.butonolarakkal);
            this.panelSave.Controls.Add(this.FinishDate);
            this.panelSave.Controls.Add(this.StartDate);
            this.panelSave.Controls.Add(this.pictureBox1);
            this.panelSave.Controls.Add(this.btnSave);
            this.panelSave.Controls.Add(this.lblFinishDate);
            this.panelSave.Controls.Add(this.lblStartDate);
            this.panelSave.Controls.Add(this.txtWriter);
            this.panelSave.Controls.Add(this.lblWriter);
            this.panelSave.Controls.Add(this.txtName);
            this.panelSave.Controls.Add(this.lblName);
            this.panelSave.Location = new System.Drawing.Point(46, 51);
            this.panelSave.Name = "panelSave";
            this.panelSave.Size = new System.Drawing.Size(462, 330);
            this.panelSave.TabIndex = 1;
            this.panelSave.Visible = false;
            // 
            // butonolarakkal
            // 
            this.butonolarakkal.Location = new System.Drawing.Point(253, 241);
            this.butonolarakkal.Name = "butonolarakkal";
            this.butonolarakkal.Size = new System.Drawing.Size(115, 40);
            this.butonolarakkal.TabIndex = 11;
            this.butonolarakkal.Text = "Select Image";
            this.butonolarakkal.UseVisualStyleBackColor = true;
            this.butonolarakkal.Click += new System.EventHandler(this.butonolarakkal_Click);
            // 
            // FinishDate
            // 
            this.FinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FinishDate.Location = new System.Drawing.Point(120, 140);
            this.FinishDate.Name = "FinishDate";
            this.FinishDate.Size = new System.Drawing.Size(100, 22);
            this.FinishDate.TabIndex = 10;
            this.FinishDate.Value = new System.DateTime(2017, 10, 2, 13, 54, 34, 720);
            // 
            // StartDate
            // 
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(120, 101);
            this.StartDate.MinDate = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(100, 22);
            this.StartDate.TabIndex = 3;
            this.StartDate.Value = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(239, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(25, 186);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.AutoSize = true;
            this.lblFinishDate.Location = new System.Drawing.Point(22, 145);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(83, 17);
            this.lblFinishDate.TabIndex = 6;
            this.lblFinishDate.Text = "Finish Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(22, 106);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(76, 17);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            // 
            // txtWriter
            // 
            this.txtWriter.Location = new System.Drawing.Point(120, 59);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.Size = new System.Drawing.Size(100, 22);
            this.txtWriter.TabIndex = 3;
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Location = new System.Drawing.Point(22, 64);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(50, 17);
            this.lblWriter.TabIndex = 2;
            this.lblWriter.Text = "Writer:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.dataGridView1);
            this.panelShow.Location = new System.Drawing.Point(514, 51);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(462, 330);
            this.panelShow.TabIndex = 2;
            this.panelShow.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(419, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStripLabelSave
            // 
            this.toolStripLabelSave.Name = "toolStripLabelSave";
            this.toolStripLabelSave.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabelSave.Text = "Save";
            this.toolStripLabelSave.Click += new System.EventHandler(this.toolStripLabelSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabelShow
            // 
            this.toolStripLabelShow.Name = "toolStripLabelShow";
            this.toolStripLabelShow.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabelShow.Text = "Show";
            this.toolStripLabelShow.Click += new System.EventHandler(this.toolStripLabelShow_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelSave,
            this.toolStripSeparator1,
            this.toolStripLabelShow});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(959, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // vrbkutuphane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 480);
            this.Controls.Add(this.panelSave);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelShow);
            this.Name = "vrbkutuphane";
            this.Text = "Kutuphane";
            this.panelSave.ResumeLayout(false);
            this.panelSave.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelSave;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFinishDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelShow;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.DateTimePicker FinishDate;
        private System.Windows.Forms.Button butonolarakkal;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

