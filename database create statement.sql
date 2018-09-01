drop table tbl_AbuseReport;
drop table tbl_Attendance;
drop table tbl_Lesson;
drop table tbl_PushNotification;
drop table tbl_Educator;
drop table tbl_Staff;
drop table tbl_Employee;
drop table tbl_Student;
drop table tbl_Guardian;

CREATE TABLE tbl_Employee(
fld_NationalID int primary key,
fld_FName varchar(25),
fld_LName varchar(25),
fld_ContactNo varchar(10),
fld_Email varchar(10),
fld_Password varchar(30),
fld_Active bit
);

CREATE TABLE tbl_Guardian(
fld_GuardianID int primary key,
fld_FName varchar(25),
fld_LName varchar(25),
fld_Contact varchar(10),
fld_Active bit,
fld_Email varchar(30),
fld_Address varchar(40)
);

CREATE TABLE tbl_Student(
fld_StudentID int primary key,
fld_StudFName varchar(25),
fld_StudLName varchar(25),
fld_Password varchar(25),
fld_Active bit,
fld_GuardianID int FOREIGN KEY REFERENCES tbl_Guardian(fld_GuardianID)
);


CREATE TABLE tbl_Staff(
fld_StaffID int primary key
);

CREATE TABLE tbl_Educator(
fld_StaffID int primary key
);

CREATE TABLE tbl_PushNotification(
fld_PushID int primary key,
fld_Description varchar(50),
fld_Message varchar(200),
fld_Sent bit,
fld_Date datetime,
fld_isStaff bit,
fld_isStudent bit,
fld_isGuardian bit,
fld_StaffID int FOREIGN KEY REFERENCES tbl_Staff(fld_StaffID)
);

CREATE TABLE tbl_Lesson(
fld_LessonID int primary key,
fld_DateTime datetime,
fld_Description varchar(30),
fld_DurationHours real,
fld_StaffID int FOREIGN KEY REFERENCES tbl_Educator(fld_StaffID)
);

CREATE TABLE tbl_Attendance(
fld_AttendanceID int primary key,
fld_LessonID int FOREIGN KEY REFERENCES tbl_Lesson(fld_LessonID),
fld_StudentID  int FOREIGN KEY REFERENCES tbl_Student(fld_StudentID),
fld_DateRecorded datetime,
fld_GuardianID int FOREIGN KEY REFERENCES tbl_Guardian(fld_GuardianID),
fld_DidAttend bit
);

CREATE TABLE tbl_AbuseReport(
fld_AbuseID int primary key,
fld_Description varchar(140),
fld_ActionTaken varchar(140),
fld_Comment varchar(140),
fld_Date date,
fld_RecordedBy int FOREIGN KEY REFERENCES tbl_Staff(fld_StaffID),
fld_StudentID int FOREIGN KEY REFERENCES tbl_Student(fld_StudentID),
fld_GuardianID int FOREIGN KEY REFERENCES tbl_Guardian(fld_GuardianID)
);


