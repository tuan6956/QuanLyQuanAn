using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
           


        }
        dbConnection _dbConn = null;
        QuanAnBUS quanAnBus = null;

        private void btnAddorEdit_Click(object sender, EventArgs e)
        {
            var qa = new QuanAn(txtNameRestaurant.Text, txtTimeOpen.Text, txtTimeClose.Text, txtTypeFood.Text, txtPhone.Text, txtAddress.Text);
            
            if (btnAddorEdit.Text == "Edit")
            {
                qa.ID = int.Parse(txtID.Text);
                grvQuanLy.DataSource = quanAnBus.updateRestaurent(qa);
                UpdateView("", "", "", "", "", "", "", "Add");
            }
            else
                grvQuanLy.DataSource = quanAnBus.addRestaurent(qa);
        }

        private void btnTestConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSvName.Text) || string.IsNullOrWhiteSpace(txtSvName.Text))
            {
                MessageBox.Show("Chưa nhập Server Name");
                return;
            }
            if (string.IsNullOrEmpty(txtDBName.Text) || string.IsNullOrWhiteSpace(txtDBName.Text))
            {
                MessageBox.Show("Chưa nhập Database Name");
                return;
            }
            _dbConn = new dbConnection(txtSvName.Text, txtDBName.Text, txtUser.Text, txtPass.Text);
            if (_dbConn.IsAvailable())
                MessageBox.Show("Database có thể kết nối");
            else
                MessageBox.Show("Không thể kết nối Database");

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSvName.Text) || string.IsNullOrWhiteSpace(txtSvName.Text))
            {
                MessageBox.Show("Chưa nhập Server Name");
                return;
            }
            if (string.IsNullOrEmpty(txtDBName.Text) || string.IsNullOrWhiteSpace(txtDBName.Text))
            {
                MessageBox.Show("Chưa nhập Database Name");
                return;
            }
            _dbConn = new dbConnection(txtSvName.Text, txtDBName.Text, txtUser.Text, txtPass.Text);
            if (_dbConn.IsAvailable())
            {
                MessageBox.Show("Kết nối thành công");
                quanAnBus = new QuanAnBUS(_dbConn);
                grvQuanLy.DataSource = quanAnBus.getAllRestaurant();
                tabControl.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Không thể kết nối Database");
        }

        private void grvQuanLy_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                var mn1 = new MenuItem("Sửa");
                var mn2 = new MenuItem("Xóa");
                mn1.Click += edit_Click;
                mn2.Click += delete_Click;
                m.MenuItems.Add(mn1);
                m.MenuItems.Add(mn2);

                int currentMouseOverRow = grvQuanLy.HitTest(e.X, e.Y).RowIndex;
                m.Show(grvQuanLy, new Point(e.X, e.Y));

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grvQuanLy.SelectedRows)
            {
                string name = row.Cells[1].Value.ToString();
                string timeOpen = row.Cells[2].Value.ToString();
                string timeClose = row.Cells[3].Value.ToString();
                string typeFood = row.Cells[4].Value.ToString();
                string phone = row.Cells[5].Value.ToString();
                string address = row.Cells[6].Value.ToString();
                string id = row.Cells[0].Value.ToString();
                grvQuanLy.DataSource = quanAnBus.deleteRestaurant(new QuanAn(int.Parse(id), name, timeOpen, timeClose, typeFood, phone, address));
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            //btnAddorEdit.Text = "Edit";
            foreach (DataGridViewRow row in grvQuanLy.SelectedRows)
            {
                string name = row.Cells[1].Value.ToString();
                string timeOpen = row.Cells[2].Value.ToString();
                string timeClose = row.Cells[3].Value.ToString();
                string typeFood = row.Cells[4].Value.ToString();
                string phone = row.Cells[5].Value.ToString();
                string address = row.Cells[6].Value.ToString();
                string id = row.Cells[0].Value.ToString();
                UpdateView(id, name, timeOpen, timeClose, typeFood, phone, address, "Edit");
            }
        }

        private void UpdateView(string id, string name, string timeOpen, string timeClose, string typeFood, string phoneContact, string address, string titleButton)
        {
            txtNameRestaurant.Text = name;
            txtTimeOpen.Text = timeOpen;
            txtTimeClose.Text = timeClose;
            txtTypeFood.Text = typeFood;
            txtPhone.Text = phoneContact;
            txtAddress.Text = address;
            btnAddorEdit.Text = titleButton;
            txtID.Text = id;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl.SelectedIndex == 0 && quanAnBus == null)
            {
                MessageBox.Show("Chưa connect database");
                tabControl.SelectedIndex = 1;
            }
            else if (tabControl.SelectedIndex == 1 && quanAnBus != null)
            {
                btnConnect.Text = "Đã connect database";
                btnConnect.Enabled = false;
                //btnTestConnect.Enabled = false;
            }
        }
    }
}
