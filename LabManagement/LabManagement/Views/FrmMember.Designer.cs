namespace LabManagement
{
    partial class FrmMember
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
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteMem = new System.Windows.Forms.Button();
            this.btnAddMem = new System.Windows.Forms.Button();
            this.dataMem = new System.Windows.Forms.DataGridView();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtMemName = new System.Windows.Forms.TextBox();
            this.txtMemCode = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhoneNum = new System.Windows.Forms.Label();
            this.lbBirthday = new System.Windows.Forms.Label();
            this.lbMemName = new System.Windows.Forms.Label();
            this.lbMemCode = new System.Windows.Forms.Label();
            this.cMemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cWorks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataMem)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(390, 49);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(123, 22);
            this.dtpBirthday.TabIndex = 37;
            // 
            // btnDeleteMem
            // 
            this.btnDeleteMem.BackColor = System.Drawing.Color.Black;
            this.btnDeleteMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteMem.Location = new System.Drawing.Point(380, 156);
            this.btnDeleteMem.Name = "btnDeleteMem";
            this.btnDeleteMem.Size = new System.Drawing.Size(160, 31);
            this.btnDeleteMem.TabIndex = 36;
            this.btnDeleteMem.Text = "Delete Member";
            this.btnDeleteMem.UseVisualStyleBackColor = false;
            this.btnDeleteMem.Click += new System.EventHandler(this.btnDeleteMem_Click);
            // 
            // btnAddMem
            // 
            this.btnAddMem.BackColor = System.Drawing.Color.Black;
            this.btnAddMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddMem.Location = new System.Drawing.Point(55, 156);
            this.btnAddMem.Name = "btnAddMem";
            this.btnAddMem.Size = new System.Drawing.Size(150, 31);
            this.btnAddMem.TabIndex = 34;
            this.btnAddMem.Text = "Add Member";
            this.btnAddMem.UseVisualStyleBackColor = false;
            this.btnAddMem.Click += new System.EventHandler(this.btnAddMem_Click);
            // 
            // dataMem
            // 
            this.dataMem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMemCode,
            this.cMemName,
            this.cGender,
            this.cBirthday,
            this.cAddress,
            this.cPhoneNum,
            this.cEmail,
            this.cWorks});
            this.dataMem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataMem.Location = new System.Drawing.Point(0, 193);
            this.dataMem.Name = "dataMem";
            this.dataMem.RowHeadersWidth = 51;
            this.dataMem.RowTemplate.Height = 24;
            this.dataMem.Size = new System.Drawing.Size(1008, 257);
            this.dataMem.TabIndex = 33;
            this.dataMem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMem_CellClick);
            this.dataMem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMem_CellEndEdit_1);
            this.dataMem.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMem_RowLeave_1);
            // 
            // cbbGender
            // 
            this.cbbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "..."});
            this.cbbGender.Location = new System.Drawing.Point(654, 44);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(121, 24);
            this.cbbGender.TabIndex = 32;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(592, 46);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(62, 17);
            this.lbGender.TabIndex = 31;
            this.lbGender.Text = "Gender";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(389, 113);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(285, 22);
            this.txtAddress.TabIndex = 30;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(389, 80);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(285, 22);
            this.txtEmail.TabIndex = 29;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNum.Location = new System.Drawing.Point(104, 110);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(127, 22);
            this.txtPhoneNum.TabIndex = 28;
            // 
            // txtMemName
            // 
            this.txtMemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemName.Location = new System.Drawing.Point(104, 78);
            this.txtMemName.Name = "txtMemName";
            this.txtMemName.Size = new System.Drawing.Size(178, 22);
            this.txtMemName.TabIndex = 27;
            // 
            // txtMemCode
            // 
            this.txtMemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemCode.Location = new System.Drawing.Point(104, 48);
            this.txtMemCode.Name = "txtMemCode";
            this.txtMemCode.Size = new System.Drawing.Size(127, 22);
            this.txtMemCode.TabIndex = 26;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(316, 113);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(67, 17);
            this.lbAddress.TabIndex = 25;
            this.lbAddress.Text = "Address";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(316, 83);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(47, 17);
            this.lbEmail.TabIndex = 24;
            this.lbEmail.Text = "Email";
            // 
            // lbPhoneNum
            // 
            this.lbPhoneNum.AutoSize = true;
            this.lbPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhoneNum.Location = new System.Drawing.Point(12, 113);
            this.lbPhoneNum.Name = "lbPhoneNum";
            this.lbPhoneNum.Size = new System.Drawing.Size(86, 17);
            this.lbPhoneNum.TabIndex = 23;
            this.lbPhoneNum.Text = "PhoneNum";
            // 
            // lbBirthday
            // 
            this.lbBirthday.AutoSize = true;
            this.lbBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBirthday.Location = new System.Drawing.Point(316, 49);
            this.lbBirthday.Name = "lbBirthday";
            this.lbBirthday.Size = new System.Drawing.Size(68, 17);
            this.lbBirthday.TabIndex = 22;
            this.lbBirthday.Text = "Birthday";
            // 
            // lbMemName
            // 
            this.lbMemName.AutoSize = true;
            this.lbMemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemName.Location = new System.Drawing.Point(12, 83);
            this.lbMemName.Name = "lbMemName";
            this.lbMemName.Size = new System.Drawing.Size(82, 17);
            this.lbMemName.TabIndex = 21;
            this.lbMemName.Text = "MemName";
            // 
            // lbMemCode
            // 
            this.lbMemCode.AutoSize = true;
            this.lbMemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMemCode.Location = new System.Drawing.Point(12, 51);
            this.lbMemCode.Name = "lbMemCode";
            this.lbMemCode.Size = new System.Drawing.Size(78, 17);
            this.lbMemCode.TabIndex = 20;
            this.lbMemCode.Text = "MemCode";
            // 
            // cMemCode
            // 
            this.cMemCode.HeaderText = "MemCode";
            this.cMemCode.MinimumWidth = 6;
            this.cMemCode.Name = "cMemCode";
            this.cMemCode.Width = 125;
            // 
            // cMemName
            // 
            this.cMemName.HeaderText = "MemName";
            this.cMemName.MinimumWidth = 6;
            this.cMemName.Name = "cMemName";
            this.cMemName.Width = 125;
            // 
            // cGender
            // 
            this.cGender.HeaderText = "Gender";
            this.cGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "..."});
            this.cGender.MinimumWidth = 6;
            this.cGender.Name = "cGender";
            this.cGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cGender.Width = 125;
            // 
            // cBirthday
            // 
            this.cBirthday.HeaderText = "Birthday";
            this.cBirthday.MinimumWidth = 6;
            this.cBirthday.Name = "cBirthday";
            this.cBirthday.Width = 125;
            // 
            // cAddress
            // 
            this.cAddress.HeaderText = "Address";
            this.cAddress.MinimumWidth = 6;
            this.cAddress.Name = "cAddress";
            this.cAddress.Width = 125;
            // 
            // cPhoneNum
            // 
            this.cPhoneNum.HeaderText = "PhoneNum";
            this.cPhoneNum.MinimumWidth = 6;
            this.cPhoneNum.Name = "cPhoneNum";
            this.cPhoneNum.Width = 125;
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Email";
            this.cEmail.MinimumWidth = 6;
            this.cEmail.Name = "cEmail";
            this.cEmail.Width = 125;
            // 
            // cWorks
            // 
            this.cWorks.HeaderText = "Works";
            this.cWorks.MinimumWidth = 6;
            this.cWorks.Name = "cWorks";
            this.cWorks.Visible = false;
            this.cWorks.Width = 125;
            // 
            // FrmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.btnDeleteMem);
            this.Controls.Add(this.btnAddMem);
            this.Controls.Add(this.dataMem);
            this.Controls.Add(this.cbbGender);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtMemName);
            this.Controls.Add(this.txtMemCode);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPhoneNum);
            this.Controls.Add(this.lbBirthday);
            this.Controls.Add(this.lbMemName);
            this.Controls.Add(this.lbMemCode);
            this.Name = "FrmMember";
            this.Text = "Member";
            this.Load += new System.EventHandler(this.FrmMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Button btnDeleteMem;
        private System.Windows.Forms.Button btnAddMem;
        private System.Windows.Forms.DataGridView dataMem;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtMemName;
        private System.Windows.Forms.TextBox txtMemCode;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhoneNum;
        private System.Windows.Forms.Label lbBirthday;
        private System.Windows.Forms.Label lbMemName;
        private System.Windows.Forms.Label lbMemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMemName;
        private System.Windows.Forms.DataGridViewComboBoxColumn cGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cWorks;
    }
}

