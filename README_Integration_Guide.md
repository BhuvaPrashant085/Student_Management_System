# SMS Project — Complete Integration Guide
## New Modules: Internship + Projects & Assignments Dashboards

---

## 📁 Files Delivered

### SQL Setup
| File | Purpose |
|------|---------|
| `SMS_Complete_Database_Setup.sql` | Run this in SSMS on your SMS database — creates all tables, inserts sample data, and contains every query used by the dashboards |

### New C# Forms (Student)
| File | Form | Purpose |
|------|------|---------|
| `InternshipDashboard.cs` + `.Designer.cs` | `InternshipDashboard` | Student views/applies for internships |
| `ProjectsAssignmentsDashboard.cs` + `.Designer.cs` | `ProjectsAssignmentsDashboard` | Student views/submits projects & assignments |

### New C# Forms (Teacher)
| File | Form | Purpose |
|------|------|---------|
| `TeacherInternshipManager.cs` + `.Designer.cs` | `TeacherInternshipManager` | Post internships, approve/reject applications |
| `TeacherProjectsManager.cs` + `.Designer.cs` | `TeacherProjectsManager` | Grade project & assignment submissions |

### Updated Existing Forms
| File | What Changed |
|------|-------------|
| `MainForm_UPDATED.cs` | `btnInternship` → opens `InternshipDashboard`, `btnProjects` → opens `ProjectsAssignmentsDashboard` |
| `Teacher_Dashboard_UPDATED.cs` | `btnManageInternships` → opens `TeacherInternshipManager`, `btnManageProjects` → opens `TeacherProjectsManager` |

---

## 🚀 Step-by-Step Integration

### Step 1: Run the SQL Script
1. Open **SQL Server Management Studio (SSMS)**
2. Connect to your server (`UGB2-10-50`)
3. Open `SMS_Complete_Database_Setup.sql`
4. Press **F5** to execute
5. All new tables will be created and sample data inserted

### Step 2: Add New Files to Visual Studio Project
1. Open your DOTNET solution in Visual Studio
2. Right-click the project → **Add → Existing Item**
3. Add all new `.cs` and `.Designer.cs` files

### Step 3: Replace Updated Files
- Replace `MainForm.cs` content with `MainForm_UPDATED.cs`
- Replace `Teacher_Dashboard.cs` content with `Teacher_Dashboard_UPDATED.cs`

### Step 4: Add Buttons to Teacher Dashboard (Designer)
In `Teacher_Dashboard.Designer.cs`, add two new buttons:
```csharp
// Add to InitializeComponent():
this.btnManageInternships = new System.Windows.Forms.Button();
this.btnManageProjects    = new System.Windows.Forms.Button();

// Configure btnManageInternships:
this.btnManageInternships.Text     = "🎓 Manage Internships";
this.btnManageInternships.Location = new System.Drawing.Point(/* choose position */);
this.btnManageInternships.Click   += new System.EventHandler(this.btnManageInternships_Click);

// Configure btnManageProjects:
this.btnManageProjects.Text     = "📚 Projects & Assignments";
this.btnManageProjects.Location = new System.Drawing.Point(/* choose position */);
this.btnManageProjects.Click   += new System.EventHandler(this.btnManageProjects_Click);

// Add to Controls.Add():
this.Controls.Add(this.btnManageInternships);
this.Controls.Add(this.btnManageProjects);
```

### Step 5: Add Microsoft.VisualBasic Reference
The new forms use `Microsoft.VisualBasic.Interaction.InputBox`.
- In Solution Explorer → References → Right-click → Add Reference
- Check **Microsoft.VisualBasic** → OK

### Step 6: Build and Run
- Press **F5** or Build → Run
- Log in as Student → test Internship and Projects dashboards
- Log in as Teacher → test Internship Manager and Projects Manager

---

## 🗄️ Database Schema (New Tables)

```
Students ──┬──► InternshipApplications ──► Internships
           ├──► ProjectSubmissions     ──► Projects
           ├──► AssignmentSubmissions  ──► Assignments
           └──► InternshipCompletions  ──► Internships

Teachers ──┬──► Internships (PostedBy)
           ├──► Projects (PostedBy)
           └──► Assignments (PostedBy)
```

---

## 📋 SQL Query Reference (All Labelled Queries)

| Query ID | Description | Used In |
|----------|-------------|---------|
| INTERN-01 | List open internships | InternshipDashboard |
| INTERN-02 | Apply for internship | InternshipDashboard |
| INTERN-03 | Check if already applied | InternshipDashboard |
| INTERN-04 | My applications list | InternshipDashboard |
| INTERN-05 | My completed internships | InternshipDashboard |
| INTERN-06 | All pending applications | TeacherInternshipManager |
| INTERN-07 | Approve/Reject application | TeacherInternshipManager |
| INTERN-08 | Post new internship | TeacherInternshipManager |
| INTERN-09 | Student application summary | Dashboard stats |
| INTERN-10 | Applications per internship | TeacherInternshipManager |
| PROJ-01 | Active projects list | ProjectsAssignmentsDashboard |
| PROJ-02 | Submit a project | ProjectsAssignmentsDashboard |
| PROJ-03 | My project submissions | ProjectsAssignmentsDashboard |
| PROJ-04 | Grade a project | TeacherProjectsManager |
| PROJ-05 | Ungraded submissions | TeacherProjectsManager |
| PROJ-06 | Student progress summary | Reports |
| PROJ-07 | Already submitted check | ProjectsAssignmentsDashboard |
| ASSIGN-01 | Active assignments list | ProjectsAssignmentsDashboard |
| ASSIGN-02 | Submit an assignment | ProjectsAssignmentsDashboard |
| ASSIGN-03 | My assignment submissions | ProjectsAssignmentsDashboard |
| ASSIGN-04 | Grade an assignment | TeacherProjectsManager |
| ASSIGN-05 | Ungraded assignments | TeacherProjectsManager |
| ASSIGN-06 | Already submitted check | ProjectsAssignmentsDashboard |
| DASH-01 | Full student summary | MainForm stats |

---

## 🔧 Connection String
All forms use:
```
Data Source=UGB2-10-50;Initial Catalog=SMS;Integrated Security=True
```
Change `UGB2-10-50` to your SQL Server instance name if needed.

---
*Generated for SMS (.NET WinForms + SQL Server) Project*
