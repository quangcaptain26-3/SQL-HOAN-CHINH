using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _97291_MinhQuang
{
    public partial class FrmChucVu : Form
    {
        public FrmChucVu()
        {
            InitializeComponent();

            LoadDgv();
        }

        private void LoadDgv()
        {
            dgv_load_cv.DataSource = Database.Query("select * from ChucVu_2");
            btn_sua.Enabled = btn_xoa.Enabled = dgv_load_cv.Rows.Count > 0;
        }

        private bool Check()
        {
            bool kq = true;
            erp_loi.Clear();
            if (txt_ma_cv.Text.Trim() == "")
            {
                erp_loi.SetError(txt_ma_cv, "Mã chức vụ không được để trống");
                kq = false;
            }
            if (txt_ten_cv.Text.Trim() == "")
            {
                erp_loi.SetError(txt_ten_cv, "Tên chức vụ không được để trống");
                kq = false;
            }
            if (txt_mucluong.Text.Trim() == "")
            {
                erp_loi.SetError(txt_mucluong, "Mức lương không được để trống");
                kq = false;
            }
            if (txt_phucap.Text.Trim() == "")
            {
                erp_loi.SetError(txt_phucap, "Phụ cấp không được để trống");
                kq = false;
            }
            return kq;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (Check() == false)
                return;
            string sql = "EXEC ThemChucVu @MaChucVu, @TenChucVu, @MucLuong, @PhuCap";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaChucVu", txt_ma_cv.Text);
            dictionary.Add("@TenChucVu", txt_ten_cv.Text);
            dictionary.Add("@MucLuong", txt_mucluong.Text);
            dictionary.Add("@PhuCap", txt_phucap.Text);
            try
            {
                Database.Execute(sql, dictionary);
                LoadDgv();
                txt_ten_cv.Text = "";
                txt_ma_cv.Text = "";
                txt_mucluong.Text = "";
                txt_phucap.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "EXEC SuaChucVu @MaChucVu, @TenChucVu, @MucLuong, @PhuCap";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaChucVu", txt_ma_cv.Text);
            dictionary.Add("@TenChucVu", txt_ten_cv.Text);
            dictionary.Add("@MucLuong", txt_mucluong.Text);
            dictionary.Add("@PhuCap", txt_phucap.Text);
            try
            {
                Database.Execute(sql, dictionary);
                LoadDgv();
                txt_ma_cv.Text = "";
                txt_mucluong.Text = "";
                txt_phucap.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "EXEC XoaChucVu @MaChucVu";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            dictionary.Add("@MaChucVu", txt_ma_cv.Text);
            try
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa chức vụ này không?",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.Yes)
                {
                    Database.Execute(sql, dictionary);
                    LoadDgv();
                    txt_ma_cv.Text = "";
                    txt_mucluong.Text = "";
                    txt_phucap.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_load_cv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_ma_cv.Text = dgv_load_cv.Rows[e.RowIndex].Cells["colMaChucVu"].Value.ToString();
            txt_ten_cv.Text = dgv_load_cv.Rows[e.RowIndex].Cells["colTenChucVu"].Value.ToString();
            txt_mucluong.Text = dgv_load_cv.Rows[e.RowIndex].Cells["colMucLuong"].Value.ToString();
            txt_phucap.Text = dgv_load_cv.Rows[e.RowIndex].Cells["colPhuCap"].Value.ToString();
        }

        private void btn_find_depart_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TimKiemChucVu(@MaChucVu, @TenChucVu, @MucLuong, @PhuCap)";
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            if (cb_find_id.Checked)
            {
                dictionary.Add("@MaChucVu", txt_find_id.Text);
            }
            else
            {
                dictionary.Add("@MaChucVu", DBNull.Value);
            }
            if (cb_find_depart.Checked)
            {
                dictionary.Add("@TenChucVu", txt_find_ten_cv.Text);
            }
            else
            {
                dictionary.Add("@TenChucVu", DBNull.Value);
            }
            if (cb_find_luong.Checked)
            {
                dictionary.Add("@MucLuong", txt_find_luong.Text);
            }
            else
            {
                dictionary.Add("@MucLuong", DBNull.Value);
            }
            if (cb_find_pc.Checked)
            {
                dictionary.Add("@PhuCap", txt_find_pc.Text);
            }
            else
            {
                dictionary.Add("@PhuCap", DBNull.Value);
            }
            dgv_load_cv.DataSource = Database.Query(sql, dictionary);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            LoadDgv();
            txt_find_id.Text = "";
            txt_find_luong.Text = "";
            txt_find_pc.Text = "";
            txt_find_ten_cv.Text = "";
            cb_find_depart.Checked = false;
            cb_find_id.Checked = false;
            cb_find_luong.Checked = false;
            cb_find_pc.Checked = false;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txt_find_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_find_id.Text.Length >= 3)
            {
                e.Handled = true;
            }
        }

        private void txt_find_ten_cv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsDigit(e.KeyChar)
                || char.IsPunctuation(e.KeyChar)
                || char.IsSymbol(e.KeyChar)
                || char.IsWhiteSpace(e.KeyChar)
            )
            {
                e.Handled = true;
            }
        }

        private void txt_find_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar)
                || char.IsPunctuation(e.KeyChar)
                || char.IsSymbol(e.KeyChar)
                || char.IsWhiteSpace(e.KeyChar)
            )
            {
                e.Handled = true;
            }
        }

        private void txt_find_pc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar)
                || char.IsPunctuation(e.KeyChar)
                || char.IsSymbol(e.KeyChar)
                || char.IsWhiteSpace(e.KeyChar)
            )
            {
                e.Handled = true;
            }
        }

        private void txt_ma_cv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                txt_ma_cv.Text.Length >= 3
                || char.IsWhiteSpace(e.KeyChar)
                || char.IsPunctuation(e.KeyChar)
                || char.IsSymbol(e.KeyChar)
            )
            {
                e.Handled = true;
            }
        }

        private void txt_ten_cv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsDigit(e.KeyChar)
                || char.IsPunctuation(e.KeyChar)
                || char.IsSymbol(e.KeyChar)
                || char.IsWhiteSpace(e.KeyChar)
            )
            {
                e.Handled = true;
            }
        }

        private void txt_mucluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar)
                || char.IsWhiteSpace(e.KeyChar)
                || char.IsPunctuation(e.KeyChar)
                || char.IsSymbol(e.KeyChar)
            )
            {
                e.Handled = true;
            }
        }

        private void txt_phucap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                char.IsLetter(e.KeyChar)
                || char.IsWhiteSpace(e.KeyChar)
                || char.IsPunctuation(e.KeyChar)
                || char.IsSymbol(e.KeyChar)
            )
            {
                e.Handled = true;
            }
        }
    }
}
