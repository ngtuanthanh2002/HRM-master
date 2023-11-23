using HumanResourceManagement.DAO;
using HumanResourceManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace HumanResourceManagement.ChildForms
{
    public partial class frmRate : Form
    {
        public frmRate()
        {
            InitializeComponent();
            LoadTheme();
            LoadReward();
            LoadDiscipline();
        }

        private void LoadTheme()
        {
            panelTitleBarReward.BackColor = ThemeColor.PrimaryColor;
            foreach (Control btns in this.panelTitleBarReward.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            panelTitleBarDiscipline.BackColor = ThemeColor.PrimaryColor;
            foreach (Control btns in this.panelTitleBarDiscipline.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void LoadReward()
        {
            try
            {
                if (int.Parse(RewardDAO.Instance.CountReward().ToString()) == 0)
                {
                    lblNonReward.Visible = true;
                    dgvReward.Visible = false;
                    return;
                }
                lblNonReward.Visible = false;
                List<RewardDTO> rewards = RewardDAO.Instance.LoadReward();

                dgvReward.DataSource = rewards;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDiscipline()
        {
            try
            {
                if (int.Parse(DisciplineDAO.Instance.CountDiscipline().ToString()) == 0)
                {
                    lblNonDiscipline.Visible = true;
                    dgvDiscipline.Visible = false;
                    return;
                }
                lblNonDiscipline.Visible = false;
                List<DisciplineDTO> disciplines = DisciplineDAO.Instance.LoadDiscipline();

                dgvDiscipline.DataSource = disciplines;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddReward_Click(object sender, EventArgs e)
        {
            ChildForms.Rate_Child.frmAddReward frmAddReward = new Rate_Child.frmAddReward();
            frmAddReward.ShowDialog();
            LoadReward();
        }

        private void btnAddDiscipline_Click(object sender, EventArgs e)
        {
            ChildForms.Rate_Child.frmAddDiscipline frmAddDiscipline = new Rate_Child.frmAddDiscipline();
            frmAddDiscipline.ShowDialog();
            LoadDiscipline();
        }

        private void btnEditReward_Click(object sender, EventArgs e)
        {
            if (dgvReward.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn cần chọn một dòng trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idReward = dgvReward.SelectedRows[0].Cells["idReward"].Value.ToString();
            string idEmployee = dgvReward.SelectedRows[0].Cells["idEmployeeReward"].Value.ToString();
            string reason = dgvReward.SelectedRows[0].Cells["reasonReward"].Value.ToString();
            string desc = dgvReward.SelectedRows[0].Cells["descriptionReward"].Value.ToString();

            ChildForms.Rate_Child.frmEditReward frmEditReward = new Rate_Child.frmEditReward(idReward, idEmployee, reason, desc);
            frmEditReward.ShowDialog();
            LoadReward();
        }

        private void btnEditDiscipline_Click(object sender, EventArgs e)
        {
            if (dgvDiscipline.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn cần chọn một dòng trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idDiscipline = dgvDiscipline.SelectedRows[0].Cells["idDiscipline"].Value.ToString();
            string idEmployee = dgvDiscipline.SelectedRows[0].Cells["idEmployeeDiscipline"].Value.ToString();
            string reason = dgvDiscipline.SelectedRows[0].Cells["reasonDiscipline"].Value.ToString();
            string desc = dgvDiscipline.SelectedRows[0].Cells["descDiscipline"].Value.ToString();
            string dateStart = dgvDiscipline.SelectedRows[0].Cells["dateStart"].Value.ToString();
            string dateEnd = dgvDiscipline.SelectedRows[0].Cells["dateEnd"].Value.ToString();

            ChildForms.Rate_Child.frmEditDiscipline frmEditDiscipline = new Rate_Child.frmEditDiscipline(idDiscipline, idEmployee, reason, desc, dateStart, dateEnd);
            frmEditDiscipline.ShowDialog();
            LoadDiscipline();
            
        }

        private void btnDeleteReward_Click(object sender, EventArgs e)
        {
            if (dgvReward.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn cần chọn 1 dòng trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string id = dgvReward.SelectedRows[0].Cells["idReward"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá quyết định số " + id + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (RewardDAO.Instance.DeleteReward_Discipline(id))
                {
                    MessageBox.Show("Xoá quyết định" + id + "thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadReward();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnDeleteDiscipline_Click(object sender, EventArgs e)
        {
            if (dgvReward.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Bạn cần chọn 1 dòng trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            string id = dgvDiscipline.SelectedRows[0].Cells["idDiscipline"].Value.ToString();
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xoá quyết định số " + id + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (RewardDAO.Instance.DeleteReward_Discipline(id))
                {
                    MessageBox.Show("Xoá quyết định" + id + "thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDiscipline();
                }
                else
                {
                    MessageBox.Show("Xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvReward.Rows.Count > 0)
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.Worksheets[1];

                Excel._Worksheet workSheet = excelApp.ActiveSheet;
                Excel.Range titleRange = workSheet.get_Range("A1", "G1");
                titleRange.Merge();
                titleRange.Value = "DANH SÁCH KHEN THƯỞNG NHÂN VIÊN";
                titleRange.Font.Bold = true;
                titleRange.Font.Size = 20;
             

                worksheet.Cells[3, 1] = "STT";
                worksheet.Cells[3, 1].Font.Bold = true;
                worksheet.Cells[3, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                worksheet.Cells[3, 1].BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);

                for (int i = 0; i < dgvReward.Columns.Count; i++)
                {
                    worksheet.Cells[3, i + 2] = dgvReward.Columns[i].HeaderText;
                    worksheet.Cells[3, i + 2].Font.Bold = true;
                    worksheet.Cells[3, i + 2].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                    worksheet.Cells[3, i + 2].BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                }

                for (int row = 0; row < dgvReward.Rows.Count; row++)
                {
                    worksheet.Cells[row + 4, 1] = row + 1;
                    worksheet.Cells[row + 4, 1].BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);

                    for (int col = 0; col < dgvReward.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 4, col + 2] = dgvReward.Rows[row].Cells[col].Value.ToString();
                        worksheet.Cells[row + 4, col + 2].BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                    }
                }

                worksheet.Columns.AutoFit();

                MessageBox.Show("Dữ liệu đã được xuất ra Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất ra Excel",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvDiscipline.Rows.Count > 0)
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.Worksheets[1];

                Excel._Worksheet workSheet = excelApp.ActiveSheet;
                Excel.Range titleRange = workSheet.get_Range("A1", "H1"); // Adjusted the range to include 7 columns
                titleRange.Merge();
                titleRange.Value = "DANH SÁCH KỶ LUẬT NHÂN VIÊN";
                titleRange.Font.Bold = true;
                titleRange.Font.Size = 20;

                worksheet.Cells[3, 1] = "STT";
                worksheet.Cells[3, 1].Font.Bold = true;
                worksheet.Cells[3, 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                worksheet.Cells[3, 1].BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);

                for (int i = 0; i < dgvDiscipline.Columns.Count; i++)
                {
                    worksheet.Cells[3, i + 2] = dgvDiscipline.Columns[i].HeaderText; // Use dgvDiscipline.Columns[i] instead of dgvReward.Columns[i]
                    worksheet.Cells[3, i + 2].Font.Bold = true;
                    worksheet.Cells[3, i + 2].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                    worksheet.Cells[3, i + 2].BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                }

                for (int row = 0; row < dgvDiscipline.Rows.Count; row++)
                {
                    worksheet.Cells[row + 4, 1] = row + 1;
                    worksheet.Cells[row + 4, 1].BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);

                    for (int col = 0; col < dgvDiscipline.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 4, col + 2] = dgvDiscipline.Rows[row].Cells[col].Value.ToString();
                        worksheet.Cells[row + 4, col + 2].BorderAround(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                    }
                }

                worksheet.Columns.AutoFit();

                MessageBox.Show("Dữ liệu đã được xuất ra Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất ra Excel",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
