-- ============================================================
-- SMS (Student Management System) - Complete Database Setup
-- Includes: Existing Tables + Internship + Projects + Assignments
-- Database: SMS
-- ============================================================

USE SMS;
GO

-- ============================================================
-- SECTION 1: EXISTING TABLES (from your .bak / project)
-- ============================================================

-- 1. Students Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Students' AND xtype='U')
CREATE TABLE Students (
    StudentID     INT IDENTITY(1,1) PRIMARY KEY,
    EnrollmentNo  NVARCHAR(50)  NOT NULL UNIQUE,
    Name          NVARCHAR(100) NOT NULL,
    Password      NVARCHAR(100) NOT NULL,
    Email         NVARCHAR(100) NULL,
    Phone         NVARCHAR(20)  NULL,
    CreatedAt     DATETIME      DEFAULT GETDATE()
);
GO

-- 2. Teachers Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Teachers' AND xtype='U')
CREATE TABLE Teachers (
    TeacherID   INT IDENTITY(1,1) PRIMARY KEY,
    Username    NVARCHAR(100) NOT NULL UNIQUE,
    Password    NVARCHAR(100) NOT NULL,
    Name        NVARCHAR(100) NULL,
    Email       NVARCHAR(100) NULL,
    CreatedAt   DATETIME      DEFAULT GETDATE()
);
GO

-- 3. SubjectMarks Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='SubjectMarks' AND xtype='U')
CREATE TABLE SubjectMarks (
    MarkID       INT IDENTITY(1,1) PRIMARY KEY,
    StudentID    INT            NOT NULL REFERENCES Students(StudentID),
    StudentName  NVARCHAR(100)  NULL,
    DMDW         DECIMAL(5,2)   DEFAULT 0,
    DotNet       DECIMAL(5,2)   DEFAULT 0,
    CC           DECIMAL(5,2)   DEFAULT 0,
    AI           DECIMAL(5,2)   DEFAULT 0,
    AT           DECIMAL(5,2)   DEFAULT 0,
    CIA1         DECIMAL(5,2)   DEFAULT 0,
    CIA2         DECIMAL(5,2)   DEFAULT 0,
    TotalPoints  DECIMAL(7,2)   DEFAULT 0,
    UpdatedAt    DATETIME       DEFAULT GETDATE()
);
GO

-- 4. Leaderboard Table
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Leaderboard' AND xtype='U')
CREATE TABLE Leaderboard (
    LeaderboardID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID     INT           NOT NULL REFERENCES Students(StudentID),
    TotalPoints   DECIMAL(7,2)  DEFAULT 0,
    UpdatedAt     DATETIME      DEFAULT GETDATE()
);
GO

-- ============================================================
-- SECTION 2: NEW TABLES - INTERNSHIP MODULE
-- ============================================================

-- 5. Internships (Master list of available internships)
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Internships' AND xtype='U')
CREATE TABLE Internships (
    InternshipID     INT IDENTITY(1,1) PRIMARY KEY,
    Title            NVARCHAR(200)  NOT NULL,
    CompanyName      NVARCHAR(200)  NOT NULL,
    Description      NVARCHAR(1000) NULL,
    Location         NVARCHAR(200)  NULL,       -- e.g. "Ahmedabad" or "Remote"
    Duration         NVARCHAR(100)  NULL,       -- e.g. "2 Months", "Summer 2025"
    Stipend          NVARCHAR(100)  NULL,       -- e.g. "5000/month" or "Unpaid"
    Skills           NVARCHAR(500)  NULL,       -- e.g. "Python, SQL, ML"
    ApplicationDeadline DATE        NULL,
    PostedByTeacherID   INT         NULL REFERENCES Teachers(TeacherID),
    Status           NVARCHAR(50)   DEFAULT 'Open', -- Open / Closed
    CreatedAt        DATETIME       DEFAULT GETDATE()
);
GO

-- 6. InternshipApplications (Student applies for internship)
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='InternshipApplications' AND xtype='U')
CREATE TABLE InternshipApplications (
    ApplicationID    INT IDENTITY(1,1) PRIMARY KEY,
    StudentID        INT           NOT NULL REFERENCES Students(StudentID),
    InternshipID     INT           NOT NULL REFERENCES Internships(InternshipID),
    AppliedDate      DATETIME      DEFAULT GETDATE(),
    Status           NVARCHAR(50)  DEFAULT 'Pending',  -- Pending / Approved / Rejected
    ResumeLink       NVARCHAR(500) NULL,
    TeacherRemark    NVARCHAR(500) NULL,
    ReviewedByTeacherID INT        NULL REFERENCES Teachers(TeacherID),
    ReviewedDate     DATETIME      NULL
);
GO

-- 7. InternshipCompletions (Student marks internship as done)
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='InternshipCompletions' AND xtype='U')
CREATE TABLE InternshipCompletions (
    CompletionID     INT IDENTITY(1,1) PRIMARY KEY,
    ApplicationID    INT           NOT NULL REFERENCES InternshipApplications(ApplicationID),
    StudentID        INT           NOT NULL REFERENCES Students(StudentID),
    InternshipID     INT           NOT NULL REFERENCES Internships(InternshipID),
    CompletionDate   DATE          NOT NULL,
    CertificatePath  NVARCHAR(500) NULL,
    Grade            NVARCHAR(10)  NULL,       -- A / B / C / Completed
    TeacherApproved  BIT           DEFAULT 0,
    TeacherRemarks   NVARCHAR(500) NULL,
    SubmittedAt      DATETIME      DEFAULT GETDATE()
);
GO

-- ============================================================
-- SECTION 3: NEW TABLES - PROJECTS & ASSIGNMENTS MODULE
-- ============================================================

-- 8. Projects (Teacher creates a project)
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Projects' AND xtype='U')
CREATE TABLE Projects (
    ProjectID        INT IDENTITY(1,1) PRIMARY KEY,
    Title            NVARCHAR(200)  NOT NULL,
    Description      NVARCHAR(1000) NULL,
    Subject          NVARCHAR(100)  NULL,       -- e.g. "DMDW", "DotNet", "AI"
    DueDate          DATE           NULL,
    MaxMarks         DECIMAL(5,2)   DEFAULT 100,
    PostedByTeacherID INT           NULL REFERENCES Teachers(TeacherID),
    Status           NVARCHAR(50)   DEFAULT 'Active', -- Active / Closed
    CreatedAt        DATETIME       DEFAULT GETDATE()
);
GO

-- 9. Assignments (Teacher creates an assignment)
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Assignments' AND xtype='U')
CREATE TABLE Assignments (
    AssignmentID     INT IDENTITY(1,1) PRIMARY KEY,
    Title            NVARCHAR(200)  NOT NULL,
    Description      NVARCHAR(1000) NULL,
    Subject          NVARCHAR(100)  NULL,
    DueDate          DATE           NULL,
    MaxMarks         DECIMAL(5,2)   DEFAULT 20,
    PostedByTeacherID INT           NULL REFERENCES Teachers(TeacherID),
    Status           NVARCHAR(50)   DEFAULT 'Active',
    CreatedAt        DATETIME       DEFAULT GETDATE()
);
GO

-- 10. ProjectSubmissions (Student submits a project)
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ProjectSubmissions' AND xtype='U')
CREATE TABLE ProjectSubmissions (
    SubmissionID     INT IDENTITY(1,1) PRIMARY KEY,
    ProjectID        INT           NOT NULL REFERENCES Projects(ProjectID),
    StudentID        INT           NOT NULL REFERENCES Students(StudentID),
    SubmissionText   NVARCHAR(1000) NULL,
    FilePath         NVARCHAR(500)  NULL,
    SubmittedAt      DATETIME      DEFAULT GETDATE(),
    MarksObtained    DECIMAL(5,2)  NULL,
    TeacherRemarks   NVARCHAR(500) NULL,
    Status           NVARCHAR(50)  DEFAULT 'Submitted' -- Submitted / Graded / Late
);
GO

-- 11. AssignmentSubmissions (Student submits an assignment)
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='AssignmentSubmissions' AND xtype='U')
CREATE TABLE AssignmentSubmissions (
    SubmissionID     INT IDENTITY(1,1) PRIMARY KEY,
    AssignmentID     INT           NOT NULL REFERENCES Assignments(AssignmentID),
    StudentID        INT           NOT NULL REFERENCES Students(StudentID),
    SubmissionText   NVARCHAR(1000) NULL,
    FilePath         NVARCHAR(500)  NULL,
    SubmittedAt      DATETIME      DEFAULT GETDATE(),
    MarksObtained    DECIMAL(5,2)  NULL,
    TeacherRemarks   NVARCHAR(500) NULL,
    Status           NVARCHAR(50)  DEFAULT 'Submitted'
);
GO

-- ============================================================
-- SECTION 4: SAMPLE DATA INSERT QUERIES
-- Run these to populate the tables for testing
-- ============================================================

-- Insert Teachers
INSERT INTO Teachers (Username, Password, Name, Email) VALUES
('teacher1', 'pass123', 'Prof. Ramesh Shah',   'rshah@college.edu'),
('admin',    'admin123', 'Admin User',          'admin@college.edu');
GO

-- Insert Sample Students
INSERT INTO Students (EnrollmentNo, Name, Password, Email, Phone) VALUES
('2301001', 'Aarav Patel',   'student123', 'aarav@gmail.com',   '9876543210'),
('2301002', 'Priya Sharma',  'student123', 'priya@gmail.com',   '9876543211'),
('2301003', 'Rohan Mehta',   'student123', 'rohan@gmail.com',   '9876543212'),
('2301004', 'Sneha Joshi',   'student123', 'sneha@gmail.com',   '9876543213'),
('2301005', 'Karan Desai',   'student123', 'karan@gmail.com',   '9876543214');
GO

-- Insert SubjectMarks for students
INSERT INTO SubjectMarks (StudentID, StudentName, DMDW, DotNet, CC, AI, AT, CIA1, CIA2, TotalPoints) VALUES
(1, 'Aarav Patel',  55, 60, 50, 70, 65, 25, 28, 353),
(2, 'Priya Sharma', 70, 75, 65, 80, 72, 30, 29, 421),
(3, 'Rohan Mehta',  45, 50, 55, 60, 48, 20, 22, 300),
(4, 'Sneha Joshi',  80, 85, 78, 90, 82, 35, 33, 483),
(5, 'Karan Desai',  60, 65, 70, 68, 72, 28, 27, 390);
GO

-- Insert Sample Internships
INSERT INTO Internships (Title, CompanyName, Description, Location, Duration, Stipend, Skills, ApplicationDeadline, PostedByTeacherID, Status) VALUES
('Data Analyst Intern',       'TCS Ahmedabad',   'Work on SQL and Power BI dashboards',             'Ahmedabad', '2 Months', '8000/month',  'SQL, Excel, Power BI',       '2025-06-30', 1, 'Open'),
('.NET Developer Intern',     'Infosys',         'Build WinForms and ASP.NET applications',         'Pune',      '3 Months', '10000/month', '.NET, C#, SQL Server',       '2025-07-15', 1, 'Open'),
('AI/ML Intern',              'Google India',    'Work on ML pipelines and data preprocessing',     'Remote',    '6 Weeks',  '15000/month', 'Python, ML, Pandas',         '2025-06-20', 1, 'Open'),
('Cloud Computing Intern',    'Azure Labs',      'Assist in cloud migration and infra management',  'Remote',    '2 Months', '12000/month', 'Azure, Python, Networking',  '2025-08-01', 1, 'Closed'),
('Web Development Intern',    'Wipro',           'Frontend and backend web development',            'Bangalore', '3 Months', '9000/month',  'HTML, CSS, JS, React',       '2025-07-30', 1, 'Open');
GO

-- Insert Sample Projects
INSERT INTO Projects (Title, Description, Subject, DueDate, MaxMarks, PostedByTeacherID, Status) VALUES
('DMDW Mini Project',    'Design and implement a data warehouse for a retail company. Include ETL pipeline and OLAP cubes.',  'DMDW',   '2025-04-30', 100, 1, 'Active'),
('.NET CMS Application', 'Build a Content Management System using ASP.NET WinForms with full CRUD, login, and reports.',     'DotNet',  '2025-05-15', 100, 1, 'Active'),
('AI Chatbot Project',   'Develop a rule-based chatbot or use an ML model for intent classification.',                       'AI',      '2025-05-20', 100, 1, 'Active'),
('Cloud Deploy Project', 'Deploy a web application on Azure or AWS with CI/CD pipeline and monitoring.',                     'CC',      '2025-05-25', 100, 1, 'Active'),
('Network Security Lab', 'Simulate a basic network attack/defense scenario using packet capture tools.',                     'AT',      '2025-06-01', 100, 1, 'Active');
GO

-- Insert Sample Assignments
INSERT INTO Assignments (Title, Description, Subject, DueDate, MaxMarks, PostedByTeacherID, Status) VALUES
('DMDW Assignment 1',   'Write SQL queries for normalization forms (1NF, 2NF, 3NF) with examples.',        'DMDW',  '2025-04-10', 20, 1, 'Active'),
('DMDW Assignment 2',   'Create an ER Diagram for a Library Management System.',                           'DMDW',  '2025-04-20', 20, 1, 'Active'),
('.NET Assignment 1',   'Create a WinForms login system with SQL Server backend.',                         'DotNet', '2025-04-12', 20, 1, 'Active'),
('.NET Assignment 2',   'Implement DataGridView with CRUD operations and search.',                         'DotNet', '2025-04-25', 20, 1, 'Active'),
('AI Assignment 1',     'Implement Linear Regression from scratch in Python.',                             'AI',    '2025-04-15', 20, 1, 'Active'),
('CC Assignment 1',     'Describe differences between IaaS, PaaS, SaaS with real examples.',               'CC',    '2025-04-18', 20, 1, 'Active'),
('AT Assignment 1',     'List and explain 5 common network vulnerabilities with mitigation strategies.',   'AT',    '2025-04-22', 20, 1, 'Active');
GO

-- ============================================================
-- SECTION 5: ALL QUERIES FOR THE DASHBOARDS
-- ============================================================

-- =============================================
-- A) INTERNSHIP DASHBOARD QUERIES
-- =============================================

-- [INTERN-01] List all OPEN internships (Student View)
SELECT 
    InternshipID,
    Title,
    CompanyName,
    Location,
    Duration,
    Stipend,
    Skills,
    ApplicationDeadline,
    Status
FROM Internships
WHERE Status = 'Open'
ORDER BY ApplicationDeadline ASC;
GO

-- [INTERN-02] Apply for internship (Insert application)
-- Replace @StudentID and @InternshipID with actual values
-- INSERT INTO InternshipApplications (StudentID, InternshipID, Status)
-- VALUES (@StudentID, @InternshipID, 'Pending');
GO

-- [INTERN-03] Check if student already applied
-- SELECT COUNT(*) FROM InternshipApplications
-- WHERE StudentID = @StudentID AND InternshipID = @InternshipID;
GO

-- [INTERN-04] Get all applications by a student
SELECT 
    ia.ApplicationID,
    i.Title           AS InternshipTitle,
    i.CompanyName,
    i.Location,
    i.Duration,
    ia.AppliedDate,
    ia.Status,
    ia.TeacherRemark
FROM InternshipApplications ia
JOIN Internships i ON ia.InternshipID = i.InternshipID
WHERE ia.StudentID = 1   -- Replace 1 with @StudentID
ORDER BY ia.AppliedDate DESC;
GO

-- [INTERN-05] Student: View my completed/approved internships
SELECT 
    ic.CompletionID,
    i.Title            AS InternshipTitle,
    i.CompanyName,
    ic.CompletionDate,
    ic.Grade,
    ic.TeacherApproved,
    ic.TeacherRemarks
FROM InternshipCompletions ic
JOIN Internships i ON ic.InternshipID = i.InternshipID
WHERE ic.StudentID = 1;  -- Replace with @StudentID
GO

-- [INTERN-06] Teacher: View all pending applications
SELECT 
    ia.ApplicationID,
    s.EnrollmentNo,
    s.Name          AS StudentName,
    i.Title         AS InternshipTitle,
    i.CompanyName,
    ia.AppliedDate,
    ia.Status
FROM InternshipApplications ia
JOIN Students s    ON ia.StudentID    = s.StudentID
JOIN Internships i ON ia.InternshipID = i.InternshipID
WHERE ia.Status = 'Pending'
ORDER BY ia.AppliedDate ASC;
GO

-- [INTERN-07] Teacher: Approve / Reject an application
-- UPDATE InternshipApplications
-- SET Status = 'Approved',   -- or 'Rejected'
--     TeacherRemark = @Remark,
--     ReviewedByTeacherID = @TeacherID,
--     ReviewedDate = GETDATE()
-- WHERE ApplicationID = @ApplicationID;
GO

-- [INTERN-08] Teacher: Post a new internship
-- INSERT INTO Internships (Title, CompanyName, Description, Location, Duration, Stipend, Skills, ApplicationDeadline, PostedByTeacherID, Status)
-- VALUES (@Title, @Company, @Desc, @Location, @Duration, @Stipend, @Skills, @Deadline, @TeacherID, 'Open');
GO

-- [INTERN-09] Dashboard Summary: Count by status per student
SELECT 
    s.Name,
    SUM(CASE WHEN ia.Status = 'Pending'  THEN 1 ELSE 0 END) AS Pending,
    SUM(CASE WHEN ia.Status = 'Approved' THEN 1 ELSE 0 END) AS Approved,
    SUM(CASE WHEN ia.Status = 'Rejected' THEN 1 ELSE 0 END) AS Rejected
FROM Students s
LEFT JOIN InternshipApplications ia ON s.StudentID = ia.StudentID
GROUP BY s.StudentID, s.Name;
GO

-- [INTERN-10] Teacher Dashboard: Total applications per internship
SELECT 
    i.Title,
    i.CompanyName,
    COUNT(ia.ApplicationID) AS TotalApplications,
    SUM(CASE WHEN ia.Status = 'Approved' THEN 1 ELSE 0 END) AS Approved,
    SUM(CASE WHEN ia.Status = 'Pending'  THEN 1 ELSE 0 END) AS Pending
FROM Internships i
LEFT JOIN InternshipApplications ia ON i.InternshipID = ia.InternshipID
GROUP BY i.InternshipID, i.Title, i.CompanyName
ORDER BY TotalApplications DESC;
GO

-- =============================================
-- B) PROJECTS & ASSIGNMENTS DASHBOARD QUERIES
-- =============================================

-- [PROJ-01] Get all active projects (Student View)
SELECT 
    ProjectID,
    Title,
    Description,
    Subject,
    DueDate,
    MaxMarks,
    Status
FROM Projects
WHERE Status = 'Active'
ORDER BY DueDate ASC;
GO

-- [PROJ-02] Submit a project (Insert submission)
-- INSERT INTO ProjectSubmissions (ProjectID, StudentID, SubmissionText, FilePath, Status)
-- VALUES (@ProjectID, @StudentID, @Notes, @FilePath, 'Submitted');
GO

-- [PROJ-03] Student: View my project submissions and marks
SELECT 
    p.Title          AS ProjectTitle,
    p.Subject,
    p.MaxMarks,
    ps.SubmittedAt,
    ps.MarksObtained,
    ps.TeacherRemarks,
    ps.Status
FROM ProjectSubmissions ps
JOIN Projects p ON ps.ProjectID = p.ProjectID
WHERE ps.StudentID = 1   -- Replace with @StudentID
ORDER BY ps.SubmittedAt DESC;
GO

-- [PROJ-04] Teacher: Grade a project submission
-- UPDATE ProjectSubmissions
-- SET MarksObtained = @Marks,
--     TeacherRemarks = @Remarks,
--     Status = 'Graded'
-- WHERE SubmissionID = @SubmissionID;
GO

-- [PROJ-05] Teacher: View all submitted projects (ungraded)
SELECT 
    ps.SubmissionID,
    s.EnrollmentNo,
    s.Name          AS StudentName,
    p.Title         AS ProjectTitle,
    p.Subject,
    ps.SubmittedAt,
    ps.Status
FROM ProjectSubmissions ps
JOIN Students s  ON ps.StudentID  = s.StudentID
JOIN Projects p  ON ps.ProjectID  = p.ProjectID
WHERE ps.Status = 'Submitted'
ORDER BY ps.SubmittedAt ASC;
GO

-- [ASSIGN-01] Get all active assignments (Student View)
SELECT 
    AssignmentID,
    Title,
    Description,
    Subject,
    DueDate,
    MaxMarks,
    Status
FROM Assignments
WHERE Status = 'Active'
ORDER BY DueDate ASC;
GO

-- [ASSIGN-02] Submit an assignment
-- INSERT INTO AssignmentSubmissions (AssignmentID, StudentID, SubmissionText, FilePath, Status)
-- VALUES (@AssignmentID, @StudentID, @Text, @FilePath, 'Submitted');
GO

-- [ASSIGN-03] Student: View my assignment submissions and marks
SELECT 
    a.Title          AS AssignmentTitle,
    a.Subject,
    a.MaxMarks,
    asub.SubmittedAt,
    asub.MarksObtained,
    asub.TeacherRemarks,
    asub.Status
FROM AssignmentSubmissions asub
JOIN Assignments a ON asub.AssignmentID = a.AssignmentID
WHERE asub.StudentID = 1   -- Replace with @StudentID
ORDER BY asub.SubmittedAt DESC;
GO

-- [ASSIGN-04] Teacher: Grade an assignment
-- UPDATE AssignmentSubmissions
-- SET MarksObtained = @Marks,
--     TeacherRemarks = @Remarks,
--     Status = 'Graded'
-- WHERE SubmissionID = @SubmissionID;
GO

-- [ASSIGN-05] Teacher: View all ungraded assignment submissions
SELECT 
    asub.SubmissionID,
    s.EnrollmentNo,
    s.Name           AS StudentName,
    a.Title          AS AssignmentTitle,
    a.Subject,
    asub.SubmittedAt,
    asub.Status
FROM AssignmentSubmissions asub
JOIN Students s    ON asub.StudentID    = s.StudentID
JOIN Assignments a ON asub.AssignmentID = a.AssignmentID
WHERE asub.Status = 'Submitted'
ORDER BY asub.SubmittedAt ASC;
GO

-- [PROJ-06] Student progress summary across projects + assignments
SELECT 
    s.Name,
    COUNT(DISTINCT ps.SubmissionID)   AS ProjectsSubmitted,
    AVG(ps.MarksObtained)             AS AvgProjectMarks,
    COUNT(DISTINCT asub.SubmissionID) AS AssignmentsSubmitted,
    AVG(asub.MarksObtained)           AS AvgAssignmentMarks
FROM Students s
LEFT JOIN ProjectSubmissions ps       ON s.StudentID = ps.StudentID
LEFT JOIN AssignmentSubmissions asub  ON s.StudentID = asub.StudentID
GROUP BY s.StudentID, s.Name
ORDER BY s.Name;
GO

-- [PROJ-07] Check if student already submitted a project
-- SELECT COUNT(*) FROM ProjectSubmissions
-- WHERE StudentID = @StudentID AND ProjectID = @ProjectID;
GO

-- [ASSIGN-06] Check if student already submitted an assignment
-- SELECT COUNT(*) FROM AssignmentSubmissions
-- WHERE StudentID = @StudentID AND AssignmentID = @AssignmentID;
GO

-- =============================================
-- C) COMBINED STUDENT DASHBOARD SUMMARY
-- =============================================

-- [DASH-01] Full student summary (for MainForm welcome screen)
SELECT 
    s.StudentID,
    s.Name,
    s.EnrollmentNo,
    ISNULL(sm.TotalPoints, 0)                                            AS TotalMarks,
    (SELECT COUNT(*) FROM InternshipApplications 
     WHERE StudentID = s.StudentID AND Status = 'Approved')             AS ApprovedInternships,
    (SELECT COUNT(*) FROM InternshipApplications 
     WHERE StudentID = s.StudentID AND Status = 'Pending')              AS PendingApplications,
    (SELECT COUNT(*) FROM ProjectSubmissions      
     WHERE StudentID = s.StudentID)                                      AS ProjectsSubmitted,
    (SELECT COUNT(*) FROM AssignmentSubmissions   
     WHERE StudentID = s.StudentID)                                      AS AssignmentsSubmitted
FROM Students s
LEFT JOIN SubjectMarks sm ON s.StudentID = sm.StudentID
WHERE s.StudentID = 1;   -- Replace with @StudentID
GO

-- ============================================================
-- SECTION 6: USEFUL VIEWS
-- ============================================================

-- View: Student Internship Status
CREATE OR ALTER VIEW vw_StudentInternshipStatus AS
SELECT 
    s.StudentID,
    s.Name,
    s.EnrollmentNo,
    i.Title          AS InternshipTitle,
    i.CompanyName,
    ia.Status        AS ApplicationStatus,
    ia.AppliedDate
FROM Students s
JOIN InternshipApplications ia ON s.StudentID    = ia.StudentID
JOIN Internships i              ON ia.InternshipID = i.InternshipID;
GO

-- View: Student Project Marks
CREATE OR ALTER VIEW vw_StudentProjectMarks AS
SELECT 
    s.StudentID,
    s.Name,
    p.Title          AS ProjectTitle,
    p.Subject,
    p.MaxMarks,
    ps.MarksObtained,
    ps.Status        AS SubmissionStatus
FROM Students s
JOIN ProjectSubmissions ps ON s.StudentID = ps.StudentID
JOIN Projects p             ON ps.ProjectID = p.ProjectID;
GO

-- View: Student Assignment Marks
CREATE OR ALTER VIEW vw_StudentAssignmentMarks AS
SELECT 
    s.StudentID,
    s.Name,
    a.Title          AS AssignmentTitle,
    a.Subject,
    a.MaxMarks,
    asub.MarksObtained,
    asub.Status      AS SubmissionStatus
FROM Students s
JOIN AssignmentSubmissions asub ON s.StudentID   = asub.StudentID
JOIN Assignments a               ON asub.AssignmentID = a.AssignmentID;
GO

PRINT 'SMS Database Setup Complete!';
PRINT 'All tables, sample data, queries, and views created successfully.';
GO
