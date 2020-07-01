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
    public partial class FrmMember : Form
    {
        List<Member> listMem;
        DateTimePicker dtp;
        public int rowIndex;
        public FrmMember(ref List<Member> members)
        {
            InitializeComponent();
            this.listMem = members;
            this.cMemCode.DataPropertyName = nameof(Member.memcode);
            this.cMemName.DataPropertyName = nameof(Member.memname);
            this.cGender.DataPropertyName = nameof(Member.gender);
            this.cBirthday.DataPropertyName = nameof(Member.birthday);
            this.cPhoneNum.DataPropertyName = nameof(Member.phonenum);
            this.cEmail.DataPropertyName = nameof(Member.email);
            this.cAddress.DataPropertyName = nameof(Member.address);
            this.cWorks.DataPropertyName = nameof(Member.Works);
            BindingSource source = new BindingSource();
            source.DataSource = MemController.getlistMems();
            this.dataMem.DataSource = source;
        }

        private void btnAddMem_Click(object sender, EventArgs e)
        {
            Member mem = new Member();
            
            mem.memcode = this.txtMemCode.Text.Trim();
            mem.memname = this.txtMemName.Text.Trim();
            try
            {
                mem.gender = cbbGender.SelectedItem.ToString();
            }
            catch
            {
                mem.gender = "";
            }
            mem.birthday = this.dtpBirthday.Value;
            mem.address = this.txtAddress.Text.Trim();
            mem.phonenum = this.txtPhoneNum.Text.Trim();
            mem.email = this.txtEmail.Text.Trim();
            

            if (listMem.Where(x => x.memcode == mem.memcode).Count() > 0)
            {
                MessageBox.Show("MemCode đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            listMem.Add(mem);
            MemController.AddMem(mem);
            BindingSource source = new BindingSource();
            source.DataSource = MemController.getlistMems();
            this.dataMem.DataSource = source;

            this.txtMemCode.Clear();
            this.txtMemName.Clear();
            this.txtPhoneNum.Clear();
            this.txtEmail.Clear();
            this.txtAddress.Clear();
            this.cbbGender.SelectedIndex = -1;
            this.dtpBirthday.Value = DateTime.Now;

            //add users to database
            /*if (MemController.AddMem(mem) == false)
            {
                MessageBox.Show("Lỗi thêm member");
                return;
            }*/
            
        }
        private void Dtp_TextChanged(object sender, EventArgs e)
        {
            this.dataMem.CurrentRow.Cells[3].Value = this.dtp.Value.Date.ToString("dd/MM/yyyy");
        }
        private void Dtp_Closeup(object sender, EventArgs e)
        {
            dtp.Visible = false;
            dtp.Dispose();
        }
        
        

        private void dataMem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DateTime SinhNhat = new DateTime(2000, 7, 26);
            try
            {


                if (this.dataMem.Columns[e.ColumnIndex].DataPropertyName == nameof(Member.birthday))
                {
                    dtp = new DateTimePicker();
                    dtp.Format = DateTimePickerFormat.Short;
                    dtp.Visible = true;
                    Rectangle rect = this.dataMem.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Location = new Point(rect.X, rect.Y);
                    dtp.Size = new Size(rect.Width, rect.Height);
                    try
                    {
                        dtp.Value = DateTime.Parse(this.dataMem.CurrentCell.Value.ToString());
                    }
                    catch
                    {
                        dtp.Visible = false;
                        dtp.Dispose();
                        dataMem.CurrentCell.Value = SinhNhat.ToString();
                    }
                    dtp.CloseUp += Dtp_Closeup;
                    dtp.TextChanged += Dtp_TextChanged;
                    this.dataMem.Controls.Add(dtp);

                }
            }
            catch (Exception s)
            {
                Console.WriteLine(s);
            }
        }

        private void dataMem_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            Member mem = new Member();
            try
            {

                mem.memcode = this.dataMem.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {

                MessageBox.Show("Phải nhập Memcode");
                dataMem.CurrentRow.Cells[0].Value = "";
                dataMem.Rows.RemoveAt(dataMem.Rows.Count - 2);
                return;

            }
            if (mem.memcode.Length <= 0)
            {
                return;
            }
            if (this.dataMem.CurrentRow.Cells[1].Value is null)
            {
                this.dataMem.CurrentRow.Cells[1].Value = "";
            }
            mem.memname = this.dataMem.CurrentRow.Cells[1].Value.ToString();
            if (this.dataMem.CurrentRow.Cells[2].Value is null)
            {
                this.dataMem.CurrentRow.Cells[2].Value = "";
            }
            mem.gender = this.dataMem.CurrentRow.Cells[2].Value.ToString();
            if (this.dataMem.CurrentRow.Cells[3].Value is null)
            {
                this.dataMem.CurrentRow.Cells[3].Value = "1/1/1989";
            }
            mem.birthday = DateTime.Parse(this.dataMem.CurrentRow.Cells[3].Value.ToString()).Date;
            if (this.dataMem.CurrentRow.Cells[4].Value is null)
            {
                this.dataMem.CurrentRow.Cells[4].Value = "";
            }
            mem.address = this.dataMem.CurrentRow.Cells[4].Value.ToString();
            if (this.dataMem.CurrentRow.Cells[5].Value is null)
            {
                this.dataMem.CurrentRow.Cells[5].Value = "";
            }
            mem.phonenum = this.dataMem.CurrentRow.Cells[5].Value.ToString();
            if (this.dataMem.CurrentRow.Cells[6].Value is null)
            {
                this.dataMem.CurrentRow.Cells[6].Value = "";
            }
            mem.email = this.dataMem.CurrentRow.Cells[6].Value.ToString();


            //update to database
            MemController.UpdateMem(mem);
            BindingSource source = new BindingSource();
            source.DataSource = MemController.getlistMems();
            //dataUsers.DataSource = source;
        }

        private void dataMem_RowLeave_1(object sender, DataGridViewCellEventArgs e)
        {
            return;
        }

        private void btnDeleteMem_Click(object sender, EventArgs e)
        {
            Member mem = MemController.getMem(this.dataMem.SelectedRows[0].Cells[0].Value.ToString());
            MemController.DeleteMem(mem);

            BindingSource source = new BindingSource();
            source.DataSource = MemController.getlistMems();
            dataMem.DataSource = source;
        }

        private void FrmMember_Load(object sender, EventArgs e)
        {

        }
    }
}
