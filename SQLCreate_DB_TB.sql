----===Create Database===----
USE master
GO
-- Drop the database if it already exists
IF  EXISTS (
	SELECT name 
		FROM sys.databases 
		WHERE name = N'QLTD'
)
DROP DATABASE QLTD
GO
CREATE DATABASE QLTD
GO
----====Create Table=====-----
USE QLTD
GO
----dang ky---
CREATE TABLE dbo.Register
(
	UserID int IDENTITY(1,1) PRIMARY KEY,
	Ho NVARCHAR(100),
	Ten NVARCHAR(50),
	Username NVARCHAR(150),
	Password VARCHAR(50)
);
INSERT INTO dbo.Register VALUES (N'Duong',N'3',N'123','123')
----Nhan vien ---
CREATE TABLE dbo.Profile
(
	ProfileID int IDENTITY(1,1) PRIMARY KEY,
	ProfileName NVARCHAR(200),
	CodeEmp NVARCHAR(200),
	DateBrith DATE,
	StatusHire VARCHAR(50),
);
----yeu cau tuyen dung----
CREATE TABLE dbo.JobVancany
(
	JobVancanyID INT IDENTITY(1,1) PRIMARY KEY,
	JobVancanyName NVARCHAR(100),
	CodeJobVancany VARCHAR(50),
	DateStart DATE,
	DateEnd DATE,
	Soluong INT,
	LevelInterview INT,
	Gender NVARCHAR(10),
	CandidateHistory NVARCHAR(250),
	isdelete  BIT DEFAULT ((0)),	
);
-----Ho so ung vien----
CREATE TABLE dbo.Candidate
(
	CandidateID INT IDENTITY(1,1) PRIMARY KEY,
	CandidateName NVARCHAR(200),
	CodeCandidate VARCHAR(50),
	DateBirthday DATE,
	Gender NVARCHAR(10),
	Phone NVARCHAR(500),
	Email NVARCHAR(500),
	CandidateHistory NVARCHAR(250),
	Status VARCHAR(50) DEFAULT 'E_NEW',
	isdelete  BIT DEFAULT ((0)),
	JobVancanyID INT,
	pic image,
	FOREIGN KEY (JobVancanyID) REFERENCES dbo.JobVancany(JobVancanyID)
);
----Lịch sử tuyển dụng----
CREATE	TABLE dbo.Rec_RecruitmentHistory
(
	RecruitmentHistoryID Int IDENTITY(1,1) PRIMARY KEY,
	CandidateName NVARCHAR(200),
	Gender VARCHAR(50),
	LevelInterview INT,
	JobVancanyID INT,
	CandidateID INT,
	isdelete  BIT DEFAULT ((0)),
	FOREIGN KEY (JobVancanyID) REFERENCES dbo.JobVancany(JobVancanyID),
	FOREIGN KEY (CandidateID) REFERENCES dbo.Candidate(CandidateID)
);
----ke hoach/hen cho phong van----
CREATE TABLE dbo.InterviewCampaign
(
	InterviewCampaignID INT IDENTITY(1,1) PRIMARY KEY,
	InterviewCampaignName NVARCHAR(100),
	DateInterview DATE,
	HourInterview NVARCHAR(100),
	ProfileID INT,
	isdelete  BIT DEFAULT ((0)),
	FOREIGN KEY (ProfileID) REFERENCES dbo.Profile(ProfileID),
);
---Ke hoach/hen phong van chi tiet----
CREATE TABLE dbo.InterviewCampaignDetail
(
	InterviewCampaignDetailID INT IDENTITY(1,1) PRIMARY KEY,
	CandidateID INT,
	InterviewCampaignID INT,
	DateInterview DATE,
	HourInterview NVARCHAR(100),
	ProfileID INT,
	isdelete  BIT DEFAULT ((0)),
	FOREIGN KEY (ProfileID) REFERENCES dbo.Profile(ProfileID),
	FOREIGN KEY (InterviewCampaignID) REFERENCES dbo.InterviewCampaign(InterviewCampaignID),
	FOREIGN KEY (CandidateID) REFERENCES dbo.Candidate(CandidateID)
);
----phong van----
CREATE TABLE dbo.Interview
(
	InterviewID INT IDENTITY(1,1) PRIMARY KEY,
	CandidateID INT, CanidateName nvarchar (50),
	JobVancanyName nvarchar(100),
	InterviewerName1 nvarchar(50), Result1 INT,
	InterviewerName2 nvarchar(50), Result2 INT,
	InterviewerName3 nvarchar(50), Result3 INT,
	InterviewDate date, InterviewTime nvarchar(20)
	--Comment NVARCHAR(200),
	--ResultInterview NVARCHAR(50)
	--StatusInterview VARCHAR(50),
	--JobVancanyID INT,
	--HourInterview NVARCHAR(100),
	--InterviewCampaignID INT,
	--ProfileID INT,
	--Score FLOAT,
	--LevelInterview INT,
	--InterviewCampaignDetailID INT,
	--InterviewName NVARCHAR(200),
	--RecruitmentHistoryID INT,
	--isdelete  BIT DEFAULT ((0)),
	--FOREIGN KEY (CandidateID)REFERENCES dbo.Candidate(CandidateID),
	--FOREIGN KEY ( InterviewCampaignID) REFERENCES dbo.InterviewCampaign(InterviewCampaignID),
	--FOREIGN KEY (InterviewCampaignDetailID) REFERENCES dbo.InterviewCampaignDetail(InterviewCampaignDetailID),
	--FOREIGN KEY(JobVancanyID) REFERENCES dbo.JobVancany(JobVancanyID),
	--FOREIGN KEY (RecruitmentHistoryID) REFERENCES dbo.Rec_RecruitmentHistory(RecruitmentHistoryID)
);

--INSERT INTO dbo.JobVancany VALUES (N'Dev',N'D01',N'10/08/2018',N'16/08/2018','4','2',N'Nam','3')
--INSERT INTO dbo.JobVancany VALUES (N'BA',N'B01',N'12/06/2018',N'16/06/2018','3','2',N'Nu','2')
--INSERT INTO dbo.JobVancany VALUES (N'Database',N'Da01',N'20/07/2018',N'25/07/2018','2','1',N'Nam','1')
--INSERT INTO dbo.JobVancany VALUES (N'Tester',N'T01',N'10/07/2018',N'15/07/2018','5','2',N'Nu','1')
--INSERT INTO dbo.JobVancany VALUES (N'Manager',N'M01',N'15/07/2018',N'18/07/2018','1','1',N'Nam','5')

--INSERT INTO dbo.Candidate VALUES (N'Phuong',N'P11',N'10/08/1995',N'Nu',N'1232554',N'phuong.pham@gmail.com','2')
--INSERT INTO dbo.Candidate VALUES (N'Linh',N'T11',N'10/08/1994',N'Nu',N'65641231',N'linh.duong@gmail.com','3')
--INSERT INTO dbo.Candidate VALUES (N'Nhu',N'N11',N'10/08/1993',N'Nu',N'6565561',N'nhu.hong@gmail.com','3')
--INSERT INTO dbo.Candidate VALUES (N'Khoi',N'K11',N'10/08/1992',N'Nam',N'6598412',N'khoi.nguyen@gmail.com','1')

--INSERT INTO dbo.Profile VALUES (N'Duong',N'B01','10/06/1998',N'H')
--INSERT INTO dbo.Profile VALUES (N'Nhu',N'B02','10/07/1998',N'H')
--INSERT INTO dbo.Profile VALUES (N'Phuong',N'B03','4/07/1998',N'H')



