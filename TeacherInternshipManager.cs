// ============================================================
// TeacherInternshipManager.cs
// Teacher-side: Post internships, review applications
// ============================================================

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOTNET
{
    public partial class TeacherInternshipManager : Form
    {
        string connectionString = "Data Source=UGB2-10-50;Initial Catalog=SMS;Integrated Security=True";
        private int teacherId;

        public TeacherInternshipManager(int tid = 1)
        {
            InitializeComponent();
            teacherId = tid;
        }

        private void TeacherInternshipManager_Load(object sender, EventArgs e)
        {
            LoadAllApplications();
            LoadMyInternships();
            LoadApplicationSummary();
        }

        // ─────────────────────────────────────────────────────
        // [INTERN-06] Load all PENDING applications
        // ─────────────────────────────────────────────────────
        private void LoadAllApplications()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Show all, color-coded by status
                string query = @"
                    SELECT 
                        ia.ApplicationID,
                        s.EnrollmentNo     AS [Enroll No],
                        s.Name             AS [Student Name],
                        i.Title            AS [Internship],
                        i.CompanyName      AS [Company],
                        ia.AppliedDate     AS [Applied On],
                        ia.Status
                    FROM InternshipApplications ia
                    JOIN Students s    ON ia.StudentID    = s.StudentID
                    JOIN Internships i ON ia.InternshipID = i.InternshipID
                    ORDER BY 
                        CASE ia.Status WHEN 'Pending' THEN 0 WHEN 'Approved' THEN 1 ELSE 2 END,
                        ia.AppliedDate ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvApplications.DataSource = dt;
                dgvApplications.Columns["ApplicationID"].Visible = false;

                // Color rows by status
                foreach (System.Windows.Forms.DataGridViewRow row in dgvApplications.Rows)
                {
                    if (row.Cells["Status"].Value != null)
                    {
                        string s = row.Cells["Status"].Value.ToString();
                        if (s == "Approved")
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(200, 230, 201);
                        else if (s == "Rejected")
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 205, 210);
                        // Pending stays default
                    }
                }
            }
        }

        // ─────────────────────────────────────────────────────
        // [INTERN-10] Load internship-wise summary
        // ─────────────────────────────────────────────────────
        private void LoadApplicationSummary()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        i.Title            AS [Internship Title],
                        i.CompanyName      AS [Company],
                        i.Status           AS [Internship Status],
                        COUNT(ia.ApplicationID)                                     AS [Total Apps],
                        SUM(CASE WHEN ia.Status='Approved' THEN 1 ELSE 0 END)      AS [Approved],
                        SUM(CASE WHEN ia.Status='Pending'  THEN 1 ELSE 0 END)      AS [Pending],
                        SUM(CASE WHEN ia.Status='Rejected' THEN 1 ELSE 0 END)      AS [Rejected]
                    FROM Internships i
                    LEFT JOIN InternshipApplications ia ON i.InternshipID = ia.InternshipID
                    GROUP BY i.InternshipID, i.Title, i.CompanyName, i.Status
                    ORDER BY [Total Apps] DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSummary.DataSource = dt;
            }
        }

        // Load my posted internships
        private void LoadMyInternships()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT InternshipID, Title, CompanyName, Location, Duration,
                           Stipend, ApplicationDeadline, Status
                    FROM Internships
                    ORDER BY CreatedAt DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvInternships.DataSource = dt;
                dgvInternships.Columns["InternshipID"].Visible = false;
            }
        }

        // ─────────────────────────────────────────────────────
        // [INTERN-07] Approve selected application
        // ─────────────────────────────────────────────────────
        private void btnApprove_Click(object sender, EventArgs e)
        {
            UpdateApplicationStatus("Approved");
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            UpdateApplicationStatus("Rejected");
        }

        private void UpdateApplicationStatus(string newStatus)
        {
            if (dgvApplications.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an application.", "Select Row",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int appId       = Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["ApplicationID"].Value);
            string student  = dgvApplications.SelectedRows[0].Cells["Student Name"].Value.ToString();
            string remark   = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter remark for " + student + " (optional):", "Remark", "");

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // [INTERN-07]
                string query = @"
                    UPDATE InternshipApplications
                    SET Status = @status,
                        TeacherRemark = @remark,
                        ReviewedByTeacherID = @tid,
                        ReviewedDate = GETDATE()
                    WHERE ApplicationID = @appId";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@remark", remark);
                cmd.Parameters.AddWithValue("@tid",    teacherId);
                cmd.Parameters.AddWithValue("@appId",  appId);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Application " + newStatus + " for " + student, "Done",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAllApplications();
            LoadApplicationSummary();
        }

        // ─────────────────────────────────────────────────────
        // [INTERN-08] Post a new internship
        // ─────────────────────────────────────────────────────
        private void btnPostInternship_Click(object sender, EventArgs e)
        {
            // Simple inline input for demo; use a proper form in production
            string title    = Microsoft.VisualBasic.Interaction.InputBox("Internship Title:", "Post Internship");
            if (string.IsNullOrWhiteSpace(title)) return;
            string company  = Microsoft.VisualBasic.Interaction.InputBox("Company Name:");
            string location = Microsoft.VisualBasic.Interaction.InputBox("Location (or Remote):");
            string duration = Microsoft.VisualBasic.Interaction.InputBox("Duration (e.g. 2 Months):");
            string stipend  = Microsoft.VisualBasic.Interaction.InputBox("Stipend (e.g. 8000/month or Unpaid):");
            string skills   = Microsoft.VisualBasic.Interaction.InputBox("Required Skills (comma separated):");
            string deadline = Microsoft.VisualBasic.Interaction.InputBox("Application Deadline (YYYY-MM-DD):");
            string desc     = Microsoft.VisualBasic.Interaction.InputBox("Description:");

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Internships 
                        (Title, CompanyName, Description, Location, Duration, Stipend,
                         Skills, ApplicationDeadline, PostedByTeacherID, Status)
                    VALUES 
                        (@title, @company, @desc, @location, @duration, @stipend,
                         @skills, @deadline, @tid, 'Open')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@title",    title);
                cmd.Parameters.AddWithValue("@company",  company);
                cmd.Parameters.AddWithValue("@desc",     desc);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@stipend",  stipend);
                cmd.Parameters.AddWithValue("@skills",   skills);
                cmd.Parameters.AddWithValue("@deadline", deadline);
                cmd.Parameters.AddWithValue("@tid",      teacherId);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("✅ Internship posted successfully!", "Posted",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMyInternships();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllApplications();
            LoadMyInternships();
            LoadApplicationSummary();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
