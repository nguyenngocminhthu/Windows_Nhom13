using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using LabManagement.Controllers;
using LabManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManagement
{
    public partial class FrmWork : Form
    {
       
        private int ID;
        private List<Work> listWorks;
        public FrmWork(ref List<Member> listmems, List<Project> listpros, List<Work> listworks)
        {
            InitializeComponent();
            ID = 0;
            displayWorks();


        }
        private void displayWorks()
        {
            string displaymems = "";
            string displaypros = "";
            List<Work> lstWork = WorkController.getAllWorks();
            foreach (Work work in lstWork)
            {
                displaymems = "";
                foreach (Member u in work.Members)
                {
                    displaymems = displaymems + u + " ";
                }

                displaypros = "";
                foreach (Project u in work.Projects)
                {
                    displaypros = displaypros + u + " ";
                }
                ListViewItem wOrk = new ListViewItem(work.ID.ToString());                
                wOrk.SubItems.Add(new ListViewItem.ListViewSubItem(wOrk, displaymems));
                wOrk.SubItems.Add(new ListViewItem.ListViewSubItem(wOrk, displaypros));
                wOrk.SubItems.Add(new ListViewItem.ListViewSubItem(wOrk, work.workingtime));
                wOrk.SubItems.Add(new ListViewItem.ListViewSubItem(wOrk, work.salary));
                
                
                this.listWork.Items.Add(wOrk);
            }
        }

        private void btnAddWork_Click(object sender, EventArgs e)
        {
            if (this.txtWorkingTime.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtWorkingTime, "Hãy nhập thời gian làm việc");
                return;
            }
            if (this.txtSalary.Text.Trim().Length <= 0)
            {
                this.errorProvider1.SetError(this.txtSalary, "Hãy nhập mức lương");
                return;
            }
            
            Work works = new Work();
            this.ID = WorkController.getIDfromDB();
            works.ID = this.ID;
            works.workingtime = this.txtWorkingTime.Text;
            works.salary = this.txtSalary.Text;

            works.Members = new List<Member>();

            string displaymems = "";
            for (int i = 0; i < lstMem.Items.Count; i++)
            {
                displaymems = displaymems + this.lstMem.Items[i] + " ";
                works.Members.Add(this.lstMem.Items[i] as Member);
            }

            works.listPros = new List<Project>();

            string displaypros = "";
            for (int i = 0; i < lstPro.Items.Count; i++)
            {
                displaypros = displaypros + this.lstPro.Items[i] + " ";
                works.listPros.Add(this.lstPro.Items[i] as Project);
            }

            WorkController.AddWork(works);

            ListViewItem wOrk = new ListViewItem(works.ID.ToString());
            wOrk.SubItems.Add(new ListViewItem.ListViewSubItem(wOrk, displaymems));
            wOrk.SubItems.Add(new ListViewItem.ListViewSubItem(wOrk, displaypros));
            wOrk.SubItems.Add(new ListViewItem.ListViewSubItem(wOrk, works.workingtime));
            wOrk.SubItems.Add(new ListViewItem.ListViewSubItem(wOrk, works.salary));

            this.listWork.Items.Add(wOrk);

            
            works.salary = "";
            works.workingtime = "";

        }

        private void txtSearchMem_TextChanged(object sender, EventArgs e)
        {
            this.lstSearchMem.Items.Clear();
            List<Member> searchMems = MemController.getListMems(this.txtSearchMem.Text.Trim());
            if (searchMems.Count > 0)
            {
                this.lstSearchMem.Visible = true;
            }
            else
            {
                this.lstSearchMem.Visible = false;
            }
            for (int i = 0; i < searchMems.Count; i++)
            {
                this.lstSearchMem.Items.Add(searchMems[i]);
            }
        }
        private void lstSearchMem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstSearchMem.SelectedIndex >= 0)
            {
                this.lstMem.Items.Add(this.lstSearchMem.SelectedItem);

            }
        }

        private void lstMem_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstMem.SelectedIndex >= 0)
            {
                this.lstMem.Items.RemoveAt(this.lstMem.SelectedIndex);
            }
        }


        private void txtSearchPro_TextChanged(object sender, EventArgs e)
        {
            this.lstSearchPro.Items.Clear();
            List<Project> searchPros = ProController.getListPros(this.txtSearchPro.Text.Trim());
            if (searchPros.Count > 0)
            {
                this.lstSearchPro.Visible = true;
            }
            else
            {
                this.lstSearchPro.Visible = false;
            }
            for (int i = 0; i < searchPros.Count; i++)
            {
                this.lstSearchPro.Items.Add(searchPros[i]);
            }
        }

        private void lstSearchPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstSearchPro.SelectedIndex >= 0)
            {
                this.lstPro.Items.Add(this.lstSearchPro.SelectedItem);

            }
        }

        private void lstPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstPro.SelectedIndex >= 0)
            {
                this.lstPro.Items.RemoveAt(this.lstPro.SelectedIndex);
            }
        }

        private void listWork_Click(object sender, EventArgs e)
        {


            
            this.txtWorkingTime.Text = this.listWork.SelectedItems[0].SubItems[3].Text.Trim();
            this.txtSalary.Text = this.listWork.SelectedItems[0].SubItems[4].Text.Trim();

            if (this.lstMem.Items.Count > 0)
            {

                this.lstMem.Items.Clear();
                int index;
                foreach (Work item in listWorks)
                {
                    if (item.ID == Convert.ToInt32(this.listWork.SelectedItems[0].SubItems[0].Text))
                    {
                        index = listWorks.IndexOf(item);
                        if (index != -1)
                        {
                            foreach (Member mem in listWorks[index].Members)
                            {
                                this.lstMem.Items.Add(mem);
                            }
                            this.lstMem.DisplayMember = "MemCode";
                        }
                        break;
                    }
                }
            }
            if (this.lstPro.Items.Count > 0)
            {

                this.lstPro.Items.Clear();
                int index1;
                foreach (Work item in listWorks)
                {
                    if (item.ID == Convert.ToInt32(this.listWork.SelectedItems[0].SubItems[0].Text))
                    {
                        index1 = listWorks.IndexOf(item);
                        if (index1 != -1)
                        {
                            foreach (Project pro in listWorks[index1].Projects)
                            {
                                this.lstPro.Items.Add(pro);
                            }
                            this.lstPro.DisplayMember = "ProCode11" +
                                "";
                        }
                        break;
                    }
                }
            }
        }

        private void btnDeleteWork_Click(object sender, EventArgs e)
        {
            try
            {

                if (listWork.Items.Count > 0)
                {
                    int id = Convert.ToInt32(this.listWork.SelectedItems[0].SubItems[0].Text);
                    WorkController.DeleteWork(id);
                    this.listWork.SelectedItems[0].Remove();
                }

                this.txtSalary.Clear();
                
                this.txtWorkingTime.Clear();


            }
            catch
            {
               
                MessageBox.Show("Vui lòng chọn sự kiện cần xóa!", "", MessageBoxButtons.OKCancel);
            }
        }

        private void btnUpdateWork_Click(object sender, EventArgs e)
        {
            Work work = new Work();
            try
            {
                work.ID = Convert.ToInt32(this.listWork.SelectedItems[0].SubItems[0].Text);
                work.workingtime = this.txtWorkingTime.Text;
                work.salary = this.txtSalary.Text;
                work.Members = new List<Member>();
                foreach (Member mem in lstMem.Items)
                {
                    work.Members.Add(mem);

                }
                              
                work.Projects = new List<Project>();
                foreach (Project pro in lstPro.Items)
                {
                    work.Projects.Add(pro);

                }
                WorkController.UpdateWork(work);
                this.listWork.SelectedItems[0].Remove();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn sự kiện cần sửa!", "", MessageBoxButtons.OKCancel);
            }

           
            
            displayWorks();

            this.txtWorkingTime.Text = "";
            this.txtSalary.Text = "";
                


            
            
        }

        private void FrmWork_Load(object sender, EventArgs e)
        {
           
            this.helpProvider1.SetShowHelp(this.txtWorkingTime, true);
            this.helpProvider1.SetHelpString(this.txtWorkingTime, "Hay nhap thoi gian lam viec");
            this.helpProvider1.SetShowHelp(this.txtSalary, true);
            this.helpProvider1.SetHelpString(this.txtSalary, "Hay nhap muc luong");
            

        }

       
        
    }
}
