// ============================================================
// TeacherProjectsManager.cs
// Teacher: Post projects/assignments, grade submissions
// ============================================================

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOTNET
{
    public partial class TeacherProjectsManager : Form
    {
        string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=SMS;Integrated Security=True";
        private int teacherId;

        public TeacherProjectsManager(int tid = 1)
        {
            InitializeComponent();
            teacherId = tid;
        }

        private void TeacherProjectsManager_Load(object sender, EventArgs e)
        {
            LoadUngraded();
            LoadAllProjects();
            LoadAllAssignments();
        }

        // ─────────────────────────────────────────────────────
        // [PROJ-05] Ungraded Project Submissions
        // ─────────────────────────────────────────────────────
        private void LoadUngraded()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        ps.SubmissionID,
                        s.EnrollmentNo  AS [Enroll No],
                        s.Name          AS [Student],
                        p.Title         AS [Project],
                        p.Subject,
                        p.MaxMarks      AS [Max],
                        ps.SubmittedAt  AS [Submitted On],
                        ps.SubmissionText AS [Notes],
                        ps.Status
                    FROM ProjectSubmissions ps
                    JOIN Students s ON ps.StudentID  = s.StudentID
                    JOIN Projects p ON ps.ProjectID  = p.ProjectID
                    WHERE ps.Status = 'Submitted'
                    ORDER BY ps.SubmittedAt ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProjectSubs.DataSource = dt;
                dgvProjectSubs.Columns["SubmissionID"].Visible = false;
                lblPendingProj.Text = "Pending Project Gradings: " + dt.Rows.Count;

                // [ASSIGN-05] Ungraded Assignment Submissions
                string q2 = @"
                    SELECT 
                        asub.SubmissionID,
                        s.EnrollmentNo   AS [Enroll No],
                        s.Name           AS [Student],
                        a.Title          AS [Assignment],
                        a.Subject,
                        a.MaxMarks       AS [Max],
                        asub.SubmittedAt AS [Submitted On],
                        asub.SubmissionText AS [Answer],
                        asub.Status
                    FROM AssignmentSubmissions asub
                    JOIN Students s    ON asub.StudentID    = s.StudentID
                    JOIN Assignments a ON asub.AssignmentID = a.AssignmentID
                    WHERE asub.Status = 'Submitted'
                    ORDER BY asub.SubmittedAt ASC";

                SqlDataAdapter da2 = new SqlDataAdapter(q2, con);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dgvAssignSubs.DataSource = dt2;
                dgvAssignSubs.Columns["SubmissionID"].Visible = false;
                lblPendingAssign.Text = "Pending Assignment Gradings: " + dt2.Rows.Count;
            }
        }

        private void LoadAllProjects()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT ProjectID, Title, Subject, DueDate, MaxMarks, Status FROM Projects ORDER BY CreatedAt DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProjects.DataSource = dt;
                dgvProjects.Columns["ProjectID"].Visible = false;
            }
        }

        private void LoadAllAssignments()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT AssignmentID, Title, Subject, DueDate, MaxMarks, Status FROM Assignments ORDER BY CreatedAt DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAssignments.DataSource = dt;
                dgvAssignments.Columns["AssignmentID"].Visible = false;
            }
        }

        // ─────────────────────────────────────────────────────
        // [PROJ-04] Grade selected project submission
        // ─────────────────────────────────────────────────────
        private void btnGradeProject_Click(object sender, EventArgs e)
        {
            if (dgvProjectSubs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a project submission to grade.", "Select Row",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int subId      = Convert.ToInt32(dgvProjectSubs.SelectedRows[0].Cells["SubmissionID"].Value);
            string student = dgvProjectSubs.SelectedRows[0].Cells["Student"].Value.ToString();
            string max     = dgvProjectSubs.SelectedRows[0].Cells["Max"].Value.ToString();

            string marksStr = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter marks for " + student + " (out of " + max + "):", "Grade Project", "");
            if (string.IsNullOrWhiteSpace(marksStr)) return;

            string remark = Microsoft.VisualBasic.Interaction.InputBox("Enter remarks (optional):", "Remarks", "");

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // [PROJ-04]
                string query = @"
                    UPDATE ProjectSubmissions
                    SET MarksObtained = @marks,
                        TeacherRemarks = @remarks,
                        Status = 'Graded'
                    WHERE SubmissionID = @sid";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@marks",   Convert.ToDecimal(marksStr));
                cmd.Parameters.AddWithValue("@remarks", remark);
                cmd.Parameters.AddWithValue("@sid",     subId);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("✅ Project graded for " + student, "Graded",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUngraded();
        }

        // ─────────────────────────────────────────────────────
        // [ASSIGN-04] Grade selected assignment submission
        // ─────────────────────────────────────────────────────
        private void btnGradeAssignment_Click(object sender, EventArgs e)
        {
            if (dgvAssignSubs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an assignment submission to grade.", "Select Row",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int subId      = Convert.ToInt32(dgvAssignSubs.SelectedRows[0].Cells["SubmissionID"].Value);
            string student = dgvAssignSubs.SelectedRows[0].Cells["Student"].Value.ToString();
            string max     = dgvAssignSubs.SelectedRows[0].Cells["Max"].Value.ToString();

            string marksStr = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter marks for " + student + " (out of " + max + "):", "Grade Assignment", "");
            if (string.IsNullOrWhiteSpace(marksStr)) return;

            string remark = Microsoft.VisualBasic.Interaction.InputBox("Enter remarks (optional):", "Remarks", "");

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // [ASSIGN-04]
                string query = @"
                    UPDATE AssignmentSubmissions
                    SET MarksObtained = @marks,
                        TeacherRemarks = @remarks,
                        Status = 'Graded'
                    WHERE SubmissionID = @sid";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@marks",   Convert.ToDecimal(marksStr));
                cmd.Parameters.AddWithValue("@remarks", remark);
                cmd.Parameters.AddWithValue("@sid",     subId);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("✅ Assignment graded for " + student, "Graded",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadUngraded();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUngraded();
            LoadAllProjects();
            LoadAllAssignments();
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
