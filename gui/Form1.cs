using gui.Models;
using System.Data;

namespace gui
{
    public partial class Form1 : Form
    {


        private Net1021FinalContext dbContext = new Net1021FinalContext();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Ten", typeof(string));
            dt.Columns.Add("Nganh", typeof(string));
            dt.Columns.Add("GioiTinh", typeof(bool));

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string thongDiep = txtThongDIep.Text;
            MessageBox.Show(thongDiep);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                cbbLuaChon.Items.Add(i);
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "D:\\hoc\\toi yeu gai anime.txt";
                StreamReader sr = new StreamReader(path);
                string doiDung = sr.ReadToEnd();
                txtCau2.Text = doiDung;
                sr.Close();
                MessageBox.Show("Chuc mung ");
            }
            catch (Exception)
            {
                MessageBox.Show("Bo thang ngu ");
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            string path = "D:\\hoc\\toi yeu gai anime.txt";
            StreamWriter sw = new StreamWriter(path);
            sw.Write(txtCau2.Text);
            sw.Close();
        }

        private void btnLoad2_Click(object sender, EventArgs e)
        {
            var sinhVien = dbContext.Sinhviens.ToList();
            foreach (var sv in sinhVien)
            {
                DataRow dr = dt.NewRow();
                dr["Ten"] = sv.Ten;
                dr["Nganh"] = sv.Nganh;
                dr["GioiTinh"] = sv.Gioitinh;
                dt.Rows.Add(dr);

            }
            dgvCau3.DataSource = dt;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtNganh.Text = "";
            rdnNam.Checked = true;

        }

        private void dgvCau3_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var cell = dgvCau3.Rows[e.RowIndex];
            var ten = cell.Cells[0].Value;
            var nganh = cell.Cells[1].Value;
            var gioitinh = (bool)cell.Cells[2].Value;

            txtTen.Text = ten.ToString();
            txtNganh.Text = nganh.ToString();
            if (gioitinh == true)
            {
                rdnNam.Checked = true;
            }
            else
            {
                rdnNu.Checked = true;
            }


        }

        private void dgvCau3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
