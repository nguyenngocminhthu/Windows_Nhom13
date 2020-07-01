namespace LabManagement
{
    partial class FrmWork
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
            this.components = new System.ComponentModel.Container();
            this.listWork = new System.Windows.Forms.ListView();
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cMemCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cProCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cWorkingTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteWork = new System.Windows.Forms.Button();
            this.btnUpdateWork = new System.Windows.Forms.Button();
            this.btnAddWork = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtWorkingTime = new System.Windows.Forms.TextBox();
            this.lstPro = new System.Windows.Forms.ListBox();
            this.lstMem = new System.Windows.Forms.ListBox();
            this.lstSearchPro = new System.Windows.Forms.ListBox();
            this.lstSearchMem = new System.Windows.Forms.ListBox();
            this.txtSearchPro = new System.Windows.Forms.TextBox();
            this.txtSearchMem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.cbbProject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // listWork
            // 
            this.listWork.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cID,
            this.cMemCode,
            this.cProCode,
            this.cWorkingTime,
            this.cSalary});
            this.listWork.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listWork.GridLines = true;
            this.listWork.HideSelection = false;
            this.listWork.Location = new System.Drawing.Point(0, 206);
            this.listWork.Name = "listWork";
            this.listWork.Size = new System.Drawing.Size(800, 244);
            this.listWork.TabIndex = 38;
            this.listWork.UseCompatibleStateImageBehavior = false;
            this.listWork.View = System.Windows.Forms.View.Details;
            this.listWork.Click += new System.EventHandler(this.listWork_Click);
            // 
            // cID
            // 
            this.cID.Text = "ID";
            this.cID.Width = 45;
            // 
            // cMemCode
            // 
            this.cMemCode.Text = "MemCode";
            this.cMemCode.Width = 89;
            // 
            // cProCode
            // 
            this.cProCode.Text = "ProCode";
            this.cProCode.Width = 81;
            // 
            // cWorkingTime
            // 
            this.cWorkingTime.Text = "WorkingTime";
            this.cWorkingTime.Width = 100;
            // 
            // cSalary
            // 
            this.cSalary.Text = "Salary";
            this.cSalary.Width = 122;
            // 
            // btnDeleteWork
            // 
            this.btnDeleteWork.BackColor = System.Drawing.Color.Black;
            this.btnDeleteWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteWork.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteWork.Location = new System.Drawing.Point(558, 174);
            this.btnDeleteWork.Name = "btnDeleteWork";
            this.btnDeleteWork.Size = new System.Drawing.Size(154, 26);
            this.btnDeleteWork.TabIndex = 37;
            this.btnDeleteWork.Text = "Delete Work";
            this.btnDeleteWork.UseVisualStyleBackColor = false;
            this.btnDeleteWork.Click += new System.EventHandler(this.btnDeleteWork_Click);
            // 
            // btnUpdateWork
            // 
            this.btnUpdateWork.BackColor = System.Drawing.Color.Black;
            this.btnUpdateWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateWork.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateWork.Location = new System.Drawing.Point(301, 174);
            this.btnUpdateWork.Name = "btnUpdateWork";
            this.btnUpdateWork.Size = new System.Drawing.Size(133, 26);
            this.btnUpdateWork.TabIndex = 36;
            this.btnUpdateWork.Text = "Update Work";
            this.btnUpdateWork.UseVisualStyleBackColor = false;
            this.btnUpdateWork.Click += new System.EventHandler(this.btnUpdateWork_Click);
            // 
            // btnAddWork
            // 
            this.btnAddWork.BackColor = System.Drawing.Color.Black;
            this.btnAddWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWork.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddWork.Location = new System.Drawing.Point(53, 174);
            this.btnAddWork.Name = "btnAddWork";
            this.btnAddWork.Size = new System.Drawing.Size(114, 26);
            this.btnAddWork.TabIndex = 35;
            this.btnAddWork.Text = "Add Work";
            this.btnAddWork.UseVisualStyleBackColor = false;
            this.btnAddWork.Click += new System.EventHandler(this.btnAddWork_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(612, 78);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(138, 22);
            this.txtSalary.TabIndex = 33;
            // 
            // txtWorkingTime
            // 
            this.txtWorkingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkingTime.Location = new System.Drawing.Point(612, 40);
            this.txtWorkingTime.Name = "txtWorkingTime";
            this.txtWorkingTime.Size = new System.Drawing.Size(138, 22);
            this.txtWorkingTime.TabIndex = 32;
            // 
            // lstPro
            // 
            this.lstPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPro.FormattingEnabled = true;
            this.lstPro.ItemHeight = 16;
            this.lstPro.Location = new System.Drawing.Point(352, 116);
            this.lstPro.Name = "lstPro";
            this.lstPro.Size = new System.Drawing.Size(120, 52);
            this.lstPro.TabIndex = 31;
            this.lstPro.SelectedIndexChanged += new System.EventHandler(this.lstPro_SelectedIndexChanged);
            // 
            // lstMem
            // 
            this.lstMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMem.FormattingEnabled = true;
            this.lstMem.ItemHeight = 16;
            this.lstMem.Location = new System.Drawing.Point(352, 48);
            this.lstMem.Name = "lstMem";
            this.lstMem.Size = new System.Drawing.Size(120, 52);
            this.lstMem.TabIndex = 30;
            this.lstMem.DoubleClick += new System.EventHandler(this.lstMem_DoubleClick);
            // 
            // lstSearchPro
            // 
            this.lstSearchPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSearchPro.FormattingEnabled = true;
            this.lstSearchPro.ItemHeight = 16;
            this.lstSearchPro.Location = new System.Drawing.Point(216, 115);
            this.lstSearchPro.Name = "lstSearchPro";
            this.lstSearchPro.Size = new System.Drawing.Size(120, 52);
            this.lstSearchPro.TabIndex = 29;
            this.lstSearchPro.Visible = false;
            this.lstSearchPro.SelectedIndexChanged += new System.EventHandler(this.lstSearchPro_SelectedIndexChanged);
            // 
            // lstSearchMem
            // 
            this.lstSearchMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSearchMem.FormattingEnabled = true;
            this.lstSearchMem.ItemHeight = 16;
            this.lstSearchMem.Location = new System.Drawing.Point(216, 48);
            this.lstSearchMem.Name = "lstSearchMem";
            this.lstSearchMem.Size = new System.Drawing.Size(120, 52);
            this.lstSearchMem.TabIndex = 28;
            this.lstSearchMem.Visible = false;
            this.lstSearchMem.SelectedIndexChanged += new System.EventHandler(this.lstSearchMem_SelectedIndexChanged);
            // 
            // txtSearchPro
            // 
            this.txtSearchPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPro.Location = new System.Drawing.Point(110, 115);
            this.txtSearchPro.Name = "txtSearchPro";
            this.txtSearchPro.Size = new System.Drawing.Size(100, 22);
            this.txtSearchPro.TabIndex = 27;
            this.txtSearchPro.TextChanged += new System.EventHandler(this.txtSearchPro_TextChanged);
            // 
            // txtSearchMem
            // 
            this.txtSearchMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMem.Location = new System.Drawing.Point(110, 48);
            this.txtSearchMem.Name = "txtSearchMem";
            this.txtSearchMem.Size = new System.Drawing.Size(100, 22);
            this.txtSearchMem.TabIndex = 26;
            this.txtSearchMem.TextChanged += new System.EventHandler(this.txtSearchMem_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(501, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "WorkingTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "ProCode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "MemCode";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbbProject
            // 
            this.cbbProject.FormattingEnabled = true;
            this.cbbProject.Location = new System.Drawing.Point(522, 133);
            this.cbbProject.Name = "cbbProject";
            this.cbbProject.Size = new System.Drawing.Size(121, 24);
            this.cbbProject.TabIndex = 39;
            // 
            // FrmWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbProject);
            this.Controls.Add(this.listWork);
            this.Controls.Add(this.btnDeleteWork);
            this.Controls.Add(this.btnUpdateWork);
            this.Controls.Add(this.btnAddWork);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtWorkingTime);
            this.Controls.Add(this.lstPro);
            this.Controls.Add(this.lstMem);
            this.Controls.Add(this.lstSearchPro);
            this.Controls.Add(this.lstSearchMem);
            this.Controls.Add(this.txtSearchPro);
            this.Controls.Add(this.txtSearchMem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmWork";
            this.Text = "Work";
            this.Load += new System.EventHandler(this.FrmWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listWork;
        private System.Windows.Forms.Button btnDeleteWork;
        private System.Windows.Forms.Button btnUpdateWork;
        private System.Windows.Forms.Button btnAddWork;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtWorkingTime;
        private System.Windows.Forms.ListBox lstPro;
        private System.Windows.Forms.ListBox lstMem;
        private System.Windows.Forms.ListBox lstSearchPro;
        private System.Windows.Forms.ListBox lstSearchMem;
        private System.Windows.Forms.TextBox txtSearchPro;
        private System.Windows.Forms.TextBox txtSearchMem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.ColumnHeader cMemCode;
        private System.Windows.Forms.ColumnHeader cProCode;
        private System.Windows.Forms.ColumnHeader cWorkingTime;
        private System.Windows.Forms.ColumnHeader cSalary;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ComboBox cbbProject;
    }
}