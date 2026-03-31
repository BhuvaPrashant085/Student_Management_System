using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DOTNET
{
    public partial class InternshipDashboard : Form
    {
        string connectionString = @"Data Source=.\SQLEXPRESS02;Initial Catalog=SMS;Integrated Security=True;Encrypt=False";
        private int studentId;

        public InternshipDashboard(int id)
        {
            InitializeComponent();
            studentId = id;
        }

        private void InternshipDashboard_Load(object sender, EventArgs e)
        {
            LoadOpenInternships();
            LoadMyApplications();
        }

        private void LoadOpenInternships()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
    ia.ApplicationID,
    s.Name,
    i.Title,
    i.Location,
    i.Duration,
    i.Stipend,
    i.Skills,
    i.ApplicationDeadline,
    ia.Status,
    ia.AppliedDate
FROM InternshipApplications ia
JOIN Students s ON ia.StudentID = s.StudentID
JOIN Internships i ON ia.InternshipID = i.InternshipID;";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvOpenInternships.DataSource = dt;
                if (dgvOpenInternships.Columns["InternshipID"] != null)
                    dgvOpenInternships.Columns["InternshipID"].Visible = false;
                lblOpenCount.Text = "Available: " + dt.Rows.Count;
            }
        }

        private void LoadMyApplications()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        ia.ApplicationID,
                        i.Title           AS [Internship Title],
                        i.CompanyName     AS [Company],
                        i.Location,
                        i.Duration,
                        ia.AppliedDate    AS [Applied On],
                        ia.Status,
                        ISNULL(ia.TeacherRemark, '-') AS [Remark]
                    FROM InternshipApplications ia
                    JOIN Internships i ON ia.InternshipID = i.InternshipID
                    WHERE ia.StudentID = @id
                    ORDER BY ia.AppliedDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", studentId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMyApplications.DataSource = dt;
                if (dgvMyApplications.Columns["ApplicationID"] != null)
                    dgvMyApplications.Columns["ApplicationID"].Visible = false;

                int approved = 0, pending = 0, rejected = 0;
                foreach (DataRow row in dt.Rows)
                {
                    string s = row["Status"].ToString();
                    if (s == "Approved")  approved++;
                    else if (s == "Pending")   pending++;
                    else if (s == "Rejected")  rejected++;
                }
                lblApproved.Text = "Approved: " + approved;
                lblPending.Text  = "Pending: "  + pending;
                lblRejected.Text = "Rejected: " + rejected;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (dgvOpenInternships.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an internship to apply.");
                return;
            }

            int internshipId = Convert.ToInt32(
    dgvOpenInternships.SelectedRows[0].Cells[0].Value
);
            string title     = dgvOpenInternships.SelectedRows[0].Cells["Title"].Value.ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM InternshipApplications WHERE StudentID=@sid AND InternshipID=@iid", con);
                checkCmd.Parameters.AddWithValue("@sid", studentId);
                checkCmd.Parameters.AddWithValue("@iid", internshipId);
                if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                {
                    MessageBox.Show("You have already applied for: " + title);
                    return;
                }

                SqlCommand applyCmd = new SqlCommand(
                    "INSERT INTO InternshipApplications (StudentID, InternshipID, Status) VALUES (@sid, @iid, 'Pending')", con);
                applyCmd.Parameters.AddWithValue("@sid", studentId);
                applyCmd.Parameters.AddWithValue("@iid", internshipId);
                applyCmd.ExecuteNonQuery();
            }

            MessageBox.Show("Applied for: " + title + "\nStatus: Pending.");
            LoadMyApplications();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOpenInternships();
            LoadMyApplications();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
