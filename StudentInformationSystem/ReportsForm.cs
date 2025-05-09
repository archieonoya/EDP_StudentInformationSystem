using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClosedXML.Excel;
using System.Drawing;

namespace StudentInformationSystem
{
    public partial class ReportsForm : Form
    {
        private string connectionString = "Server=your_server;Database=StudentInformationSystem;Uid=your_username;Pwd=your_password;";
        private DataTable dataTable;

        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            // Populate report type dropdown
            cmbReportType.Items.Add("Student List");
            cmbReportType.Items.Add("Course Enrollment");
            cmbReportType.Items.Add("Grade Report");
            cmbReportType.SelectedIndex = 0;

            // Populate department filter dropdown
            LoadDepartments();

            // Load initial data
            LoadReportData();
        }

        private void LoadDepartments()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT DepartmentId, DepartmentName FROM Departments";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Add "All Departments" option
                    DataRow allRow = dt.NewRow();
                    allRow["DepartmentId"] = 0;
                    allRow["DepartmentName"] = "All Departments";
                    dt.Rows.InsertAt(allRow, 0);

                    cmbDepartmentFilter.DataSource = dt;
                    cmbDepartmentFilter.DisplayMember = "DepartmentName";
                    cmbDepartmentFilter.ValueMember = "DepartmentId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading departments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadReportData()
        {
            try
            {
                string query = "";

                // Determine which report to generate based on selection
                switch (cmbReportType.SelectedItem.ToString())
                {
                    case "Student List":
                        query = @"SELECT s.StudentId, s.FirstName, s.LastName, s.Email, d.DepartmentName 
                                FROM Students s 
                                JOIN Departments d ON s.DepartmentId = d.DepartmentId 
                                WHERE 1=1";
                        break;

                    case "Course Enrollment":
                        query = @"SELECT c.CourseCode, c.CourseName, COUNT(e.StudentId) AS EnrollmentCount
                                FROM Courses c
                                LEFT JOIN Enrollments e ON c.CourseId = e.CourseId
                                GROUP BY c.CourseCode, c.CourseName";
                        break;

                    case "Grade Report":
                        query = @"SELECT s.StudentId, s.FirstName, s.LastName, c.CourseCode, c.CourseName, e.Grade
                                FROM Enrollments e
                                JOIN Students s ON e.StudentId = s.StudentId
                                JOIN Courses c ON e.CourseId = c.CourseId
                                WHERE 1=1";
                        break;
                }

                // Apply filters only for student-related reports
                if (cmbReportType.SelectedItem.ToString() == "Student List" ||
                    cmbReportType.SelectedItem.ToString() == "Grade Report")
                {
                    // Apply search filter
                    if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                    {
                        query += " AND (s.FirstName LIKE @Search OR s.LastName LIKE @Search)";
                    }

                    // Apply department filter
                    if (cmbDepartmentFilter.SelectedValue != null && Convert.ToInt32(cmbDepartmentFilter.SelectedValue) != 0)
                    {
                        query += " AND s.DepartmentId = @DepartmentId";
                    }
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(txtSearch.Text) &&
                            (cmbReportType.SelectedItem.ToString() == "Student List" ||
                             cmbReportType.SelectedItem.ToString() == "Grade Report"))
                        {
                            cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                        }

                        if (cmbDepartmentFilter.SelectedValue != null &&
                            Convert.ToInt32(cmbDepartmentFilter.SelectedValue) != 0 &&
                            (cmbReportType.SelectedItem.ToString() == "Student List" ||
                             cmbReportType.SelectedItem.ToString() == "Grade Report"))
                        {
                            cmd.Parameters.AddWithValue("@DepartmentId", Convert.ToInt32(cmbDepartmentFilter.SelectedValue));
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvReport.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel Files|*.xlsx";
                sfd.FileName = $"{cmbReportType.SelectedItem}_Report_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Report");

                            // Add headers
                            for (int i = 0; i < dataTable.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dataTable.Columns[i].ColumnName;
                                worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                            }

                            // Add data rows
                            for (int i = 0; i < dataTable.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataTable.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dataTable.Rows[i][j].ToString();
                                }
                            }

                            // Auto-fit columns and apply some styling
                            worksheet.Columns().AdjustToContents();
                            worksheet.Range(1, 1, 1, dataTable.Columns.Count).Style.Fill.BackgroundColor = XLColor.LightGray;

                            workbook.SaveAs(sfd.FileName);
                        }

                        MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting to Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void cmbDepartmentFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReportData();
        }

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable/disable filters based on report type
            bool enableFilters = cmbReportType.SelectedItem.ToString() == "Student List" ||
                               cmbReportType.SelectedItem.ToString() == "Grade Report";

            cmbDepartmentFilter.Enabled = enableFilters;
            txtSearch.Enabled = enableFilters;

            LoadReportData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Close();
        }
    }
}