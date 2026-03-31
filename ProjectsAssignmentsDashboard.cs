using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOTNET
{
    public partial class ProjectsAssignmentsDashboard : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS02;Initial Catalog=SMS;Integrated Security=True;Encrypt=False";
        private int studentId;

        public ProjectsAssignmentsDashboard(int id)
        {
            InitializeComponent();
            studentId = id;
        }

        private void ProjectsAssignmentsDashboard_Load(object sender, EventArgs e)
        {
            LoadActiveProjects();
            LoadActiveAssignments();
            LoadMyProjectSubmissions();
            LoadMyAssignmentSubmissions();
        }

        private void LoadActiveProjects()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT ProjectID, Title, Description, Subject, DueDate, MaxMarks
                    FROM Projects
                    WHERE Status = 'Active'
                    ORDER BY DueDate ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvProjects.DataSource = dt;
                if (dgvProjects.Columns["ProjectID"] != null)
                    dgvProjects.Columns["ProjectID"].Visible = false;
                lblProjectCount.Text = "Active Projects: " + dt.Rows.Count;
            }
        }

        private void LoadActiveAssignments()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT AssignmentID, Title, Description, Subject, DueDate, MaxMarks
                    FROM Assignments
                    WHERE Status = 'Active'
                    ORDER BY DueDate ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAssignments.DataSource = dt;
                if (dgvAssignments.Columns["AssignmentID"] != null)
                    dgvAssignments.Columns["AssignmentID"].Visible = false;
                lblAssignCount.Text = "Active Assignments: " + dt.Rows.Count;
            }
        }

        private void LoadMyProjectSubmissions()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        p.Title        AS [Project Title],
                        p.Subject,
                        p.MaxMarks     AS [Max Marks],
                        ps.SubmittedAt AS [Submitted On],
                        ISNULL(CAST(ps.MarksObtained AS NVARCHAR), 'Pending') AS [Marks],
                        ISNULL(ps.TeacherRemarks, '-') AS [Remarks],
                        ps.Status
                    FROM ProjectSubmissions ps
                    JOIN Projects p ON ps.ProjectID = p.ProjectID
                    WHERE ps.StudentID = @id
                    ORDER BY ps.SubmittedAt DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", studentId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMyProjects.DataSource = dt;
            }
        }

        private void LoadMyAssignmentSubmissions()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        a.Title         AS [Assignment Title],
                        a.Subject,
                        a.MaxMarks      AS [Max Marks],
                        asub.SubmittedAt AS [Submitted On],
                        ISNULL(CAST(asub.MarksObtained AS NVARCHAR), 'Pending') AS [Marks],
                        ISNULL(asub.TeacherRemarks, '-') AS [Remarks],
                        asub.Status
                    FROM AssignmentSubmissions asub
                    JOIN Assignments a ON asub.AssignmentID = a.AssignmentID
                    WHERE asub.StudentID = @id
                    ORDER BY asub.SubmittedAt DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", studentId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMyAssignments.DataSource = dt;
            }
        }

        private void btnSubmitProject_Click(object sender, EventArgs e)
        {
            if (dgvProjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a project to submit.");
                return;
            }

            int projectId  = Convert.ToInt32(dgvProjects.SelectedRows[0].Cells["ProjectID"].Value);
            string title   = dgvProjects.SelectedRows[0].Cells["Title"].Value.ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM ProjectSubmissions WHERE StudentID=@sid AND ProjectID=@pid", con);
                checkCmd.Parameters.AddWithValue("@sid", studentId);
                checkCmd.Parameters.AddWithValue("@pid", projectId);
                if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("You have already submitted: " + title);
                    return;
                }

                string notes = txtNotes.Text.Trim();
                if (notes == "")
                {
                    MessageBox.Show("Please enter submission notes in the text box.");
                    return;
                }

                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO ProjectSubmissions (ProjectID, StudentID, SubmissionText, Status) VALUES (@pid, @sid, @notes, 'Submitted')", con);
                insertCmd.Parameters.AddWithValue("@pid",   projectId);
                insertCmd.Parameters.AddWithValue("@sid",   studentId);
                insertCmd.Parameters.AddWithValue("@notes", notes);
                insertCmd.ExecuteNonQuery();
            }

            txtNotes.Clear();
            MessageBox.Show("Project submitted successfully!");
            LoadMyProjectSubmissions();
        }

        private void btnSubmitAssignment_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment to submit.");
                return;
            }

            int assignmentId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["AssignmentID"].Value);
            string title     = dgvAssignments.SelectedRows[0].Cells["Title"].Value.ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM AssignmentSubmissions WHERE StudentID=@sid AND AssignmentID=@aid", con);
                checkCmd.Parameters.AddWithValue("@sid", studentId);
                checkCmd.Parameters.AddWithValue("@aid", assignmentId);
                if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("You have already submitted: " + title);
                    return;
                }

                string answer = txtNotes.Text.Trim();
                if (answer == "")
                {
                    MessageBox.Show("Please enter your answer in the text box.");
                    return;
                }

                SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO AssignmentSubmissions (AssignmentID, StudentID, SubmissionText, Status) VALUES (@aid, @sid, @ans, 'Submitted')", con);
                insertCmd.Parameters.AddWithValue("@aid", assignmentId);
                insertCmd.Parameters.AddWithValue("@sid", studentId);
                insertCmd.Parameters.AddWithValue("@ans", answer);
                insertCmd.ExecuteNonQuery();
            }

            txtNotes.Clear();
            MessageBox.Show("Assignment submitted successfully!");
            LoadMyAssignmentSubmissions();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadActiveProjects();
            LoadActiveAssignments();
            LoadMyProjectSubmissions();
            LoadMyAssignmentSubmissions();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
