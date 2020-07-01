using LabManagement.Controllers;
using LabManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabManagement.Views
{
    public partial class FrmListOfWork : Form
    {
        private List<ListOfWork> LOWs;
        private int no;
        public FrmListOfWork(ref List<ListOfWork> listofworks)
        {
            InitializeComponent();
            no = 0;
            displayLOWs();
        }
        private void displayLOWs()
        {

            string displaypros = "";
            List<ListOfWork> lstLOW = LOWController.getAllLOWs();
            foreach (ListOfWork low in lstLOW)
            {

                displaypros = "";
                foreach (Project u in low.Projects)
                {
                    displaypros = displaypros + u + " ";
                }
                ListViewItem lOw = new ListViewItem(low.no.ToString());

                lOw.SubItems.Add(new ListViewItem.ListViewSubItem(lOw, displaypros));
                lOw.SubItems.Add(new ListViewItem.ListViewSubItem(lOw, low.job));
                lOw.SubItems.Add(new ListViewItem.ListViewSubItem(lOw, low.status));

                this.listLOW.Items.Add(lOw);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListOfWork lows = new ListOfWork();
            this.no = LOWController.getNofromDB();
            lows.no = this.no;
            lows.job = this.rtJob.Text;
            lows.status = this.cbbStatus.Text;

            lows.Projects = new List<Project>();



            string displaypros = "";
            for (int i = 0; i < lstpro.Items.Count; i++)
            {
                displaypros = displaypros + this.lstpro.Items[i] + " ";
                lows.Projects.Add(this.lstpro.Items[i] as Project);
            }

            LOWController.AddLOW(lows);

            ListViewItem lOw = new ListViewItem(lows.no.ToString());
            lOw.SubItems.Add(new ListViewItem.ListViewSubItem(lOw, displaypros));

            lOw.SubItems.Add(new ListViewItem.ListViewSubItem(lOw, lows.job));
            lOw.SubItems.Add(new ListViewItem.ListViewSubItem(lOw, lows.status));

            this.listLOW.Items.Add(lOw);


            lows.job = "";
            lows.status = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ListOfWork low = new ListOfWork();
            try
            {
                low.no = Convert.ToInt32(this.listLOW.SelectedItems[0].SubItems[0].Text);
                low.job = this.rtJob.Text;
                low.status = this.cbbStatus.Text;
                low.Projects = new List<Project>();
                foreach (Project pro in lstpro.Items)
                {

                    low.Projects.Add(pro);

                }
                LOWController.UpdateLOW(low);
                this.listLOW.SelectedItems[0].Remove();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn công việc cần sửa!", "", MessageBoxButtons.OKCancel);
            }

            
            
           

            displayLOWs();





            this.rtJob.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (listLOW.Items.Count > 0)
                {
                    int no = Convert.ToInt32(this.listLOW.SelectedItems[0].SubItems[0].Text);
                    LOWController.DeleteLOW(no);
                    this.listLOW.SelectedItems[0].Remove();
                }

                this.rtJob.Clear();




            }
            catch
            {

                MessageBox.Show("Vui lòng chọn công việc cần xóa!", "", MessageBoxButtons.OKCancel);
            }
        }

        private void txtsearchpro_TextChanged(object sender, EventArgs e)
        {
            this.lstsearchpro.Items.Clear();
            List<Project> searchpros = ProController.getListPros(this.txtsearchpro.Text.Trim());
            if (searchpros.Count > 0)
            {
                this.lstsearchpro.Visible = true;
            }
            else
            {
                this.lstsearchpro.Visible = false;
            }
            for (int i = 0; i < searchpros.Count; i++)
            {
                this.lstsearchpro.Items.Add(searchpros[i]);
            }
        }

        private void lstsearchpro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstsearchpro.SelectedIndex >= 0)
            {
                this.lstpro.Items.Add(this.lstsearchpro.SelectedItem);

            }
        }

        private void lstpro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstpro.SelectedIndex >= 0)
            {
                this.lstpro.Items.RemoveAt(this.lstpro.SelectedIndex);
            }
        }

        private void listLOW_Click(object sender, EventArgs e)
        {
            this.rtJob.Text = this.listLOW.SelectedItems[0].SubItems[2].Text.Trim();
            this.cbbStatus.Text = this.listLOW.SelectedItems[0].SubItems[3].Text.Trim();

            if (this.lstpro.Items.Count > 0)
            {

                this.lstpro.Items.Clear();
                int index;
                foreach (ListOfWork item in LOWs)
                {
                    if (item.no == Convert.ToInt32(this.listLOW.SelectedItems[0].SubItems[0].Text))
                    {
                        index = LOWs.IndexOf(item);
                        if (index != -1)
                        {
                            foreach (Project pro in LOWs[index].Projects)
                            {
                                this.lstpro.Items.Add(pro);
                            }
                            this.lstpro.DisplayMember = "ProCode";
                        }
                        break;
                    }
                }
            }
        }
    }
}
