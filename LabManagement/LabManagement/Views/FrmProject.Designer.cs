namespace LabManagement
{
    partial class FrmProject
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
            this.rtDescription = new System.Windows.Forms.RichTextBox();
            this.btnDeletePro = new System.Windows.Forms.Button();
            this.btnAddPro = new System.Windows.Forms.Button();
            this.dataPro = new System.Windows.Forms.DataGridView();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtProName = new System.Windows.Forms.TextBox();
            this.txtProCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cProCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cWorks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cListOfWorks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataPro)).BeginInit();
            this.SuspendLayout();
            // 
            // rtDescription
            // 
            this.rtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtDescription.Location = new System.Drawing.Point(114, 119);
            this.rtDescription.Name = "rtDescription";
            this.rtDescription.Size = new System.Drawing.Size(561, 25);
            this.rtDescription.TabIndex = 31;
            this.rtDescription.Text = "";
            // 
            // btnDeletePro
            // 
            this.btnDeletePro.BackColor = System.Drawing.Color.Black;
            this.btnDeletePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeletePro.Location = new System.Drawing.Point(411, 156);
            this.btnDeletePro.Name = "btnDeletePro";
            this.btnDeletePro.Size = new System.Drawing.Size(200, 32);
            this.btnDeletePro.TabIndex = 30;
            this.btnDeletePro.Text = "Delete Project";
            this.btnDeletePro.UseVisualStyleBackColor = false;
            this.btnDeletePro.Click += new System.EventHandler(this.btnDeletePro_Click);
            // 
            // btnAddPro
            // 
            this.btnAddPro.BackColor = System.Drawing.Color.Black;
            this.btnAddPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddPro.Location = new System.Drawing.Point(114, 156);
            this.btnAddPro.Name = "btnAddPro";
            this.btnAddPro.Size = new System.Drawing.Size(173, 32);
            this.btnAddPro.TabIndex = 28;
            this.btnAddPro.Text = "Add Project";
            this.btnAddPro.UseVisualStyleBackColor = false;
            this.btnAddPro.Click += new System.EventHandler(this.btnAddPro_Click);
            // 
            // dataPro
            // 
            this.dataPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cProCode,
            this.cProName,
            this.cDescription,
            this.cFromDate,
            this.cToDate,
            this.cWorks,
            this.cListOfWorks});
            this.dataPro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataPro.Location = new System.Drawing.Point(0, 194);
            this.dataPro.Name = "dataPro";
            this.dataPro.RowHeadersWidth = 51;
            this.dataPro.RowTemplate.Height = 24;
            this.dataPro.Size = new System.Drawing.Size(747, 256);
            this.dataPro.TabIndex = 27;
            this.dataPro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPro_CellClick);
            this.dataPro.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPro_CellEndEdit);
            this.dataPro.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPro_RowLeave);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(411, 84);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(141, 22);
            this.dtpToDate.TabIndex = 26;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(411, 48);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(141, 22);
            this.dtpFromDate.TabIndex = 25;
            // 
            // txtProName
            // 
            this.txtProName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProName.Location = new System.Drawing.Point(115, 87);
            this.txtProName.Name = "txtProName";
            this.txtProName.Size = new System.Drawing.Size(180, 22);
            this.txtProName.TabIndex = 24;
            // 
            // txtProCode
            // 
            this.txtProCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProCode.Location = new System.Drawing.Point(115, 50);
            this.txtProCode.Name = "txtProCode";
            this.txtProCode.Size = new System.Drawing.Size(180, 22);
            this.txtProCode.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "ToDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(328, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "FromDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "ProName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "ProCode";
            // 
            // cProCode
            // 
            this.cProCode.HeaderText = "ProCode";
            this.cProCode.MinimumWidth = 6;
            this.cProCode.Name = "cProCode";
            this.cProCode.Width = 125;
            // 
            // cProName
            // 
            this.cProName.HeaderText = "ProName";
            this.cProName.MinimumWidth = 6;
            this.cProName.Name = "cProName";
            this.cProName.Width = 125;
            // 
            // cDescription
            // 
            this.cDescription.HeaderText = "Description";
            this.cDescription.MinimumWidth = 6;
            this.cDescription.Name = "cDescription";
            this.cDescription.Width = 125;
            // 
            // cFromDate
            // 
            this.cFromDate.HeaderText = "FromDate";
            this.cFromDate.MinimumWidth = 6;
            this.cFromDate.Name = "cFromDate";
            this.cFromDate.Width = 125;
            // 
            // cToDate
            // 
            this.cToDate.HeaderText = "ToDate";
            this.cToDate.MinimumWidth = 6;
            this.cToDate.Name = "cToDate";
            this.cToDate.Width = 125;
            // 
            // cWorks
            // 
            this.cWorks.HeaderText = "Works";
            this.cWorks.MinimumWidth = 6;
            this.cWorks.Name = "cWorks";
            this.cWorks.ReadOnly = true;
            this.cWorks.Visible = false;
            this.cWorks.Width = 125;
            // 
            // cListOfWorks
            // 
            this.cListOfWorks.HeaderText = "ListOfWorks";
            this.cListOfWorks.MinimumWidth = 6;
            this.cListOfWorks.Name = "cListOfWorks";
            this.cListOfWorks.Visible = false;
            this.cListOfWorks.Width = 125;
            // 
            // FrmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.rtDescription);
            this.Controls.Add(this.btnDeletePro);
            this.Controls.Add(this.btnAddPro);
            this.Controls.Add(this.dataPro);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.txtProName);
            this.Controls.Add(this.txtProCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProject";
            this.Text = "Project";
            ((System.ComponentModel.ISupportInitialize)(this.dataPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtDescription;
        private System.Windows.Forms.Button btnDeletePro;
        private System.Windows.Forms.Button btnAddPro;
        private System.Windows.Forms.DataGridView dataPro;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.TextBox txtProName;
        private System.Windows.Forms.TextBox txtProCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cWorks;
        private System.Windows.Forms.DataGridViewTextBoxColumn cListOfWorks;
    }
}