namespace LabManagement
{
    partial class FrmMainGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainGUI));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.mMem = new System.Windows.Forms.ToolStripMenuItem();
            this.mPro = new System.Windows.Forms.ToolStripMenuItem();
            this.mWork = new System.Windows.Forms.ToolStripMenuItem();
            this.mListOfWork = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.btnJob = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFunction});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mFunction
            // 
            this.mFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMem,
            this.mPro,
            this.mWork,
            this.mListOfWork});
            this.mFunction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mFunction.Name = "mFunction";
            this.mFunction.Size = new System.Drawing.Size(84, 26);
            this.mFunction.Text = "&Function";
            // 
            // mMem
            // 
            this.mMem.Name = "mMem";
            this.mMem.Size = new System.Drawing.Size(172, 26);
            this.mMem.Text = "&Member";
            this.mMem.Click += new System.EventHandler(this.mMem_Click);
            // 
            // mPro
            // 
            this.mPro.Name = "mPro";
            this.mPro.Size = new System.Drawing.Size(172, 26);
            this.mPro.Text = "&Project";
            this.mPro.Click += new System.EventHandler(this.mPro_Click);
            // 
            // mWork
            // 
            this.mWork.Name = "mWork";
            this.mWork.Size = new System.Drawing.Size(172, 26);
            this.mWork.Text = "&Work";
            this.mWork.Click += new System.EventHandler(this.mWork_Click);
            // 
            // mListOfWork
            // 
            this.mListOfWork.Name = "mListOfWork";
            this.mListOfWork.Size = new System.Drawing.Size(172, 26);
            this.mListOfWork.Text = "&ListOfWork";
            this.mListOfWork.Click += new System.EventHandler(this.mListOfWork_Click);
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 516);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1005, 42);
            this.tabMain.TabIndex = 5;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMember.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMember.Image = ((System.Drawing.Image)(resources.GetObject("btnMember.Image")));
            this.btnMember.Location = new System.Drawing.Point(160, 138);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(167, 125);
            this.btnMember.TabIndex = 7;
            this.btnMember.Text = "Member";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnProject
            // 
            this.btnProject.BackColor = System.Drawing.Color.Black;
            this.btnProject.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProject.Image = ((System.Drawing.Image)(resources.GetObject("btnProject.Image")));
            this.btnProject.Location = new System.Drawing.Point(361, 138);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(167, 125);
            this.btnProject.TabIndex = 8;
            this.btnProject.Text = "Project";
            this.btnProject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProject.UseVisualStyleBackColor = false;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnJob
            // 
            this.btnJob.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJob.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJob.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJob.Image = ((System.Drawing.Image)(resources.GetObject("btnJob.Image")));
            this.btnJob.Location = new System.Drawing.Point(361, 309);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(167, 125);
            this.btnJob.TabIndex = 9;
            this.btnJob.Text = "Job";
            this.btnJob.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJob.UseVisualStyleBackColor = false;
            this.btnJob.Click += new System.EventHandler(this.btnJob_Click);
            // 
            // btnWork
            // 
            this.btnWork.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWork.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWork.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWork.Image = ((System.Drawing.Image)(resources.GetObject("btnWork.Image")));
            this.btnWork.Location = new System.Drawing.Point(160, 309);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(167, 125);
            this.btnWork.TabIndex = 9;
            this.btnWork.Text = "Work";
            this.btnWork.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWork.UseVisualStyleBackColor = false;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // FrmMainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1005, 558);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnJob);
            this.Controls.Add(this.btnProject);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMainGUI";
            this.Text = "Laboratory Management";
            this.TransparencyKey = System.Drawing.Color.LightSeaGreen;
            this.MdiChildActivate += new System.EventHandler(this.FrmMainGUI_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mFunction;
        private System.Windows.Forms.ToolStripMenuItem mMem;
        private System.Windows.Forms.ToolStripMenuItem mPro;
        private System.Windows.Forms.ToolStripMenuItem mWork;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.ToolStripMenuItem mListOfWork;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnJob;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Timer timer1;
    }
}



