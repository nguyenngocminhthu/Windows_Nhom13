namespace LabManagement.Views
{
    partial class FrmListOfWork
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtsearchpro = new System.Windows.Forms.TextBox();
            this.lstpro = new System.Windows.Forms.ListBox();
            this.lstsearchpro = new System.Windows.Forms.ListBox();
            this.Project = new System.Windows.Forms.Label();
            this.listLOW = new System.Windows.Forms.ListView();
            this.cNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rtJob = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(200, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 30);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtsearchpro
            // 
            this.txtsearchpro.Location = new System.Drawing.Point(499, 21);
            this.txtsearchpro.Name = "txtsearchpro";
            this.txtsearchpro.Size = new System.Drawing.Size(140, 22);
            this.txtsearchpro.TabIndex = 24;
            this.txtsearchpro.TextChanged += new System.EventHandler(this.txtsearchpro_TextChanged);
            // 
            // lstpro
            // 
            this.lstpro.FormattingEnabled = true;
            this.lstpro.ItemHeight = 16;
            this.lstpro.Location = new System.Drawing.Point(645, 17);
            this.lstpro.Name = "lstpro";
            this.lstpro.Size = new System.Drawing.Size(139, 68);
            this.lstpro.TabIndex = 23;
            this.lstpro.SelectedIndexChanged += new System.EventHandler(this.lstpro_SelectedIndexChanged);
            // 
            // lstsearchpro
            // 
            this.lstsearchpro.FormattingEnabled = true;
            this.lstsearchpro.ItemHeight = 16;
            this.lstsearchpro.Location = new System.Drawing.Point(499, 49);
            this.lstsearchpro.Name = "lstsearchpro";
            this.lstsearchpro.Size = new System.Drawing.Size(140, 68);
            this.lstsearchpro.TabIndex = 22;
            this.lstsearchpro.Visible = false;
            this.lstsearchpro.SelectedIndexChanged += new System.EventHandler(this.lstsearchpro_SelectedIndexChanged);
            // 
            // Project
            // 
            this.Project.AutoSize = true;
            this.Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Project.Location = new System.Drawing.Point(434, 21);
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(59, 17);
            this.Project.TabIndex = 21;
            this.Project.Text = "Project";
            // 
            // listLOW
            // 
            this.listLOW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cNo,
            this.cPro,
            this.cJob,
            this.cStatus});
            this.listLOW.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listLOW.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLOW.GridLines = true;
            this.listLOW.HideSelection = false;
            this.listLOW.Location = new System.Drawing.Point(0, 212);
            this.listLOW.Name = "listLOW";
            this.listLOW.Size = new System.Drawing.Size(834, 227);
            this.listLOW.TabIndex = 20;
            this.listLOW.UseCompatibleStateImageBehavior = false;
            this.listLOW.View = System.Windows.Forms.View.Details;
            this.listLOW.Click += new System.EventHandler(this.listLOW_Click);
            // 
            // cNo
            // 
            this.cNo.Text = "No";
            // 
            // cPro
            // 
            this.cPro.Text = "Project";
            this.cPro.Width = 124;
            // 
            // cJob
            // 
            this.cJob.Text = "Job";
            this.cJob.Width = 112;
            // 
            // cStatus
            // 
            this.cStatus.Text = "Status";
            this.cStatus.Width = 76;
            // 
            // cbbStatus
            // 
            this.cbbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Done",
            "Not Done"});
            this.cbbStatus.Location = new System.Drawing.Point(499, 125);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbbStatus.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(373, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 30);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(24, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 30);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtJob
            // 
            this.rtJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtJob.Location = new System.Drawing.Point(24, 37);
            this.rtJob.Name = "rtJob";
            this.rtJob.Size = new System.Drawing.Size(392, 112);
            this.rtJob.TabIndex = 16;
            this.rtJob.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Job";
            // 
            // FrmListOfWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 439);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtsearchpro);
            this.Controls.Add(this.lstpro);
            this.Controls.Add(this.lstsearchpro);
            this.Controls.Add(this.Project);
            this.Controls.Add(this.listLOW);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rtJob);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmListOfWork";
            this.Text = "ListOfWork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtsearchpro;
        private System.Windows.Forms.ListBox lstpro;
        private System.Windows.Forms.ListBox lstsearchpro;
        private System.Windows.Forms.Label Project;
        private System.Windows.Forms.ListView listLOW;
        private System.Windows.Forms.ColumnHeader cNo;
        private System.Windows.Forms.ColumnHeader cPro;
        private System.Windows.Forms.ColumnHeader cJob;
        private System.Windows.Forms.ColumnHeader cStatus;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RichTextBox rtJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}