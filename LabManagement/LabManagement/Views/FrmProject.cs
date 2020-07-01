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

namespace LabManagement
{
    public partial class FrmProject : Form
    {
        List<Project> listPro;
        DateTimePicker dtp;
        DateTimePicker dtp1;
        public int rowIndex;
        
        public FrmProject(ref List<Project> projects)
        {
            
            InitializeComponent();

            this.listPro = projects;
            this.cProCode.DataPropertyName = nameof(Project.procode);
            this.cProName.DataPropertyName = nameof(Project.proname);
            this.cDescription.DataPropertyName = nameof(Project.description);
            this.cFromDate.DataPropertyName = nameof(Project.fromdate);
            this.cToDate.DataPropertyName = nameof(Project.todate);
            this.cWorks.DataPropertyName = nameof(Project.Works);
            this.cListOfWorks.DataPropertyName = nameof(Project.ListOfWorks);

            BindingSource source = new BindingSource();
            source.DataSource = ProController.getlistPros();
            this.dataPro.DataSource = source;
        }

       

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            Project pro = new Project();
            pro.procode = this.txtProCode.Text.Trim();
            pro.proname = this.txtProName.Text.Trim();
            pro.description = this.rtDescription.Text.Trim();
            pro.fromdate = this.dtpFromDate.Value;
            pro.todate = this.dtpToDate.Value;


            if (listPro.Where(x => x.procode == pro.procode).Count() > 0)
            {
                MessageBox.Show("ProCode đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listPro.Add(pro);
            ProController.AddPro(pro);
            BindingSource source = new BindingSource();
            source.DataSource = ProController.getlistPros();
            this.dataPro.DataSource = source;
            
            this.txtProCode.Clear();
            this.txtProName.Clear();
            this.rtDescription.Clear();
            this.dtpFromDate.Value = DateTime.Now;
            this.dtpToDate.Value = DateTime.Now;

            /*if (ProController.AddPro(pro) == false)
            {
                MessageBox.Show("Lỗi thêm project");
                return;
            }*/
        }

        private void dataPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime datefrom = new DateTime(2000, 7, 26);
            try
            {


                if (this.dataPro.Columns[e.ColumnIndex].DataPropertyName == nameof(Project.fromdate))
                {
                    dtp = new DateTimePicker();
                    dtp.Format = DateTimePickerFormat.Short;
                    dtp.Visible = true;
                    Rectangle rect = this.dataPro.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Location = new Point(rect.X, rect.Y);
                    dtp.Size = new Size(rect.Width, rect.Height);
                    try
                    {
                        dtp.Value = DateTime.Parse(this.dataPro.CurrentCell.Value.ToString());
                    }
                    catch
                    {
                        dtp.Visible = false;
                        dtp.Dispose();
                        dataPro.CurrentCell.Value = datefrom.ToString();
                    }
                    dtp.CloseUp += Dtp_Closeup;
                    dtp.TextChanged += Dtp_TextChanged;
                    this.dataPro.Controls.Add(dtp);

                }
                
            }
            
            catch (Exception s)
            {
                Console.WriteLine(s);
            }
            DateTime dateto = new DateTime(2000, 7, 26);
            try
            {
                if (this.dataPro.Columns[e.ColumnIndex].DataPropertyName == nameof(Project.todate))
                {
                    dtp1 = new DateTimePicker();
                    dtp1.Format = DateTimePickerFormat.Short;
                    dtp1.Visible = true;
                    Rectangle rect = this.dataPro.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp1.Location = new Point(rect.X, rect.Y);
                    dtp1.Size = new Size(rect.Width, rect.Height);
                    try
                    {
                        dtp1.Value = DateTime.Parse(this.dataPro.CurrentCell.Value.ToString());
                    }
                    catch
                    {
                        dtp1.Visible = false;
                        dtp1.Dispose();
                        dataPro.CurrentCell.Value = dateto.ToString();
                    }
                    dtp1.CloseUp += Dtp_Closeup1;
                    dtp1.TextChanged += Dtp_TextChanged1;
                    this.dataPro.Controls.Add(dtp1);

                }
            }
            catch (Exception s)
            {
                Console.WriteLine(s);
            }
        }
        private void Dtp_TextChanged(object sender, EventArgs e)
        {

            this.dataPro.CurrentRow.Cells[3].Value = this.dtp.Value.Date.ToString("dd/MM/yyyy");
           
        }
        private void Dtp_Closeup(object sender, EventArgs e)
        {
            dtp.Visible = false;
            dtp.Dispose();
        }
        private void Dtp_TextChanged1(object sender, EventArgs e)
        {

            this.dataPro.CurrentRow.Cells[4].Value = this.dtp1.Value.Date.ToString("dd/MM/yyyy");

        }
        private void Dtp_Closeup1(object sender, EventArgs e)
        {
            dtp1.Visible = false;
            dtp1.Dispose();
        }

        private void dataPro_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Project pro = new Project();
            try
            {

                pro.procode = this.dataPro.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {

                MessageBox.Show("Phải nhập Procode");
                dataPro.CurrentRow.Cells[0].Value = "";
                dataPro.Rows.RemoveAt(dataPro.Rows.Count - 2);
                return;

            }
            if (pro.procode.Length <= 0)
            {
                return;
            }
            if (this.dataPro.CurrentRow.Cells[1].Value is null)
            {
                this.dataPro.CurrentRow.Cells[1].Value = "";
            }
            pro.proname = this.dataPro.CurrentRow.Cells[1].Value.ToString();
            if (this.dataPro.CurrentRow.Cells[2].Value is null)
            {
                this.dataPro.CurrentRow.Cells[2].Value = "";
            }
            pro.description = this.dataPro.CurrentRow.Cells[2].Value.ToString();
            if (this.dataPro.CurrentRow.Cells[3].Value is null)
            {
                this.dataPro.CurrentRow.Cells[3].Value = "1/1/1989";
            }
            pro.fromdate = DateTime.Parse(this.dataPro.CurrentRow.Cells[3].Value.ToString()).Date;
            if (this.dataPro.CurrentRow.Cells[4].Value is null)
            {
                this.dataPro.CurrentRow.Cells[4].Value = "1/1/1989";
            }
            pro.todate = DateTime.Parse(this.dataPro.CurrentRow.Cells[4].Value.ToString()).Date;
            
            //update to database
            ProController.UpdatePro(pro);
            BindingSource source = new BindingSource();
            source.DataSource = ProController.getlistPros();
            //dataUsers.DataSource = source;
        }

        private void dataPro_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private void btnDeletePro_Click(object sender, EventArgs e)
        {
            Project pro = ProController.getPro(this.dataPro.SelectedRows[0].Cells[0].Value.ToString());
            ProController.DeletePro(pro);           
            BindingSource source = new BindingSource();
            source.DataSource = ProController.getlistPros();
            dataPro.DataSource = source;
        }

        
    }
}
