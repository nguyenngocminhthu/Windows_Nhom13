using LabManagement.Models;
using LabManagement.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManagement
{
    public partial class FrmMainGUI : Form
    {

        FrmMember formMem;
        FrmProject formPro;
        FrmWork formWork;
        FrmListOfWork formListOfWork;
        List<Member> listMems;
        List<Project> listPros;
        List<Work> listWorks;
        List<ListOfWork> listOfWorks;
        
        public FrmMainGUI()
        {
            InitializeComponent();
            listMems = new List<Member>();
            listPros = new List<Project>();
            listWorks = new List<Work>();
            listOfWorks = new List<ListOfWork>();
        }

        private void mMem_Click(object sender, EventArgs e)
        {
            if (this.formMem is null || this.formMem.IsDisposed)
            {
                this.formMem = new FrmMember(ref listMems);
                this.formMem.MdiParent = this;
                this.formMem.Show();
            }
            else
                this.formMem.Select();
            this.btnMember.Visible = false;
            this.btnJob.Visible = false;
            this.btnProject.Visible = false;
            this.btnWork.Visible = false;
        }

        private void mPro_Click(object sender, EventArgs e)
        {
            if (this.formPro is null || this.formPro.IsDisposed)
            {
                this.formPro = new FrmProject(ref listPros);
                this.formPro.MdiParent = this;
                this.formPro.Show();
            }
            else
                this.formPro.Select();
            this.btnMember.Visible = false;
            this.btnJob.Visible = false;
            this.btnProject.Visible = false;
            this.btnWork.Visible = false;
        }

        private void mWork_Click(object sender, EventArgs e)
        {
            if (this.formWork is null || this.formWork.IsDisposed)
            {
                this.formWork = new FrmWork(ref listMems, listPros, listWorks);
                this.formWork.MdiParent = this;
                this.formWork.Show();
            }
            else
                this.formWork.Select();
            this.btnMember.Visible = false;
            this.btnJob.Visible = false;
            this.btnProject.Visible = false;
            this.btnWork.Visible = false;
        }

        private void FrmMainGUI_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if (this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabMain;
                this.tabMain.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }
        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedTab != null && this.tabMain.SelectedTab.Tag != null)
            {
                (this.tabMain.SelectedTab.Tag as Form).Select();
            }
        }

        private void mListOfWork_Click(object sender, EventArgs e)
        {
            if (this.formListOfWork is null || this.formListOfWork.IsDisposed)
            {
                this.formListOfWork = new FrmListOfWork(ref listOfWorks);
                this.formListOfWork.MdiParent = this;
                this.formListOfWork.Show();
            }
            else
                this.formListOfWork.Select();
            this.btnMember.Visible = false;
            this.btnJob.Visible = false;
            this.btnProject.Visible = false;
            this.btnWork.Visible = false;
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            if (this.formMem is null || this.formMem.IsDisposed)
            {
                this.formMem = new FrmMember(ref listMems);
                this.formMem.MdiParent = this;
                this.formMem.Show();
            }
            else
                this.formMem.Select();
            this.btnMember.Visible = false;
            this.btnJob.Visible = false;
            this.btnProject.Visible = false;
            this.btnWork.Visible = false;
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            if (this.formPro is null || this.formPro.IsDisposed)
            {
                this.formPro = new FrmProject(ref listPros);
                this.formPro.MdiParent = this;
                this.formPro.Show();
                
            }
            else
                this.formPro.Select();
            this.btnMember.Visible = false;
            this.btnJob.Visible = false;
            this.btnProject.Visible = false;
            this.btnWork.Visible = false;
        }

        private void btnJob_Click(object sender, EventArgs e)
        {
            if (this.formListOfWork is null || this.formListOfWork.IsDisposed)
            {
                this.formListOfWork = new FrmListOfWork(ref listOfWorks);
                this.formListOfWork.MdiParent = this;
                this.formListOfWork.Show();
            }
            else
                this.formListOfWork.Select();
            this.btnMember.Visible = false;
            this.btnJob.Visible = false;
            this.btnProject.Visible = false;
            this.btnWork.Visible = false;
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            if (this.formWork is null || this.formWork.IsDisposed)
            {
                this.formWork = new FrmWork(ref listMems, listPros, listWorks);
                this.formWork.MdiParent = this;
                this.formWork.Show();
            }
            else
                this.formWork.Select();
            this.btnMember.Visible = false;
            this.btnJob.Visible = false;
            this.btnProject.Visible = false;
            this.btnWork.Visible = false;
        }

        private void tabMain_TabIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
