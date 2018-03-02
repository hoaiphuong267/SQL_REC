----===Create Database===----
USE master
GO
CREATE DATABASE QLTD
GO

----====Create Table=====-----

USE QLTD
GO
----dang ky---
CREATE TABLE dbo.Register
(
	UserID VARCHAR(10) PRIMARY KEY,
	Ho NVARCHAR(100),
	Ten NVARCHAR(50),
	Username NVARCHAR(150),
	Password VARCHAR(50)
);
----dang nhap---
CREATE TABLE dbo.Account
(
	Username NVARCHAR(150)PRIMARY KEY,
	Password VARCHAR(50),
	UserID VARCHAR(10),
	FOREIGN KEY (UserID) REFERENCES dbo.Register(UserID)
);
----Nhan vien ---
CREATE TABLE dbo.Profile
(
	ProfileID INT PRIMARY KEY,
	ProfileName NVARCHAR(200),
	DateBrith DATE,
	StatusHire VARCHAR(50),
);
----dieu kien tuyen---
CREATE TABLE dbo.JobCondition
(
	JobConditionID INT PRIMARY KEY,
	JobConditionName NVARCHAR(100),
	Value1 VARCHAR(10),
	Value2 INT 
);
----yeu cau tuyen dung----
CREATE TABLE dbo.JobVancany
(
	JobVancanyID INT PRIMARY KEY,
	JobVancanyName NVARCHAR(100),
	DateStart DATE,
	DateEnd DATE,
	Soluong INT,
	LevelInterview INT,
	JobConditionID INT,
	FOREIGN KEY (JobConditionID) REFERENCES dbo.JobCondition(JobConditionID)
);
-----Ho so ung vien----
CREATE TABLE dbo.Candidate
(
	CandidateID VARCHAR(50) PRIMARY KEY,
	CandidateName NVARCHAR(200),
	DateBirthday DATE,
	Genth NVARCHAR(10),
	Phone NVARCHAR(500),
	Email NVARCHAR(500),
	CandidateHistory NVARCHAR(250),
	Status VARCHAR(50),
	JobVancanyID INT,
	FOREIGN KEY (JobVancanyID) REFERENCES dbo.JobVancany(JobVancanyID)

);
----Lịch sử tuyển dụng----
CREATE	TABLE dbo.Rec_RecruitmentHistory
(
	RecruitmentHistoryID INT PRIMARY KEY,
	CandidateName NVARCHAR(200),
	Gender VARCHAR(50),
	LevelInterview INT,
	JobVancanyID INT,
	CandidateID VARCHAR(50),
	FOREIGN KEY (JobVancanyID) REFERENCES dbo.JobVancany(JobVancanyID),
	FOREIGN KEY (CandidateID) REFERENCES dbo.Candidate(CandidateID)
);
----ke hoach/hen cho phong van----
CREATE TABLE dbo.InterviewCampaign
(
	InterviewCampaignID INT PRIMARY KEY,
	InterviewCampaignName NVARCHAR(100),
	DateInterview DATE,
	HourInterview NVARCHAR(100),
	ProfileID INT,
	FOREIGN KEY (ProfileID) REFERENCES dbo.Profile(ProfileID),
);
---Ke hoach/hen phong van chi tiet----
CREATE TABLE dbo.InterviewCampaignDetail
(
	InterviewCampaignDetailID INT PRIMARY KEY,
	CandidateID VARCHAR(50),
	InterviewCampaignID INT,
	DateInterview DATE,
	HourInterview NVARCHAR(100),
	ProfileID INT,
	FOREIGN KEY (ProfileID) REFERENCES dbo.Profile(ProfileID),
	FOREIGN KEY (InterviewCampaignID) REFERENCES dbo.InterviewCampaign(InterviewCampaignID),
	FOREIGN KEY (CandidateID) REFERENCES dbo.Candidate(CandidateID)
);
----phong van----
CREATE TABLE dbo.Interview
(
	InterviewID INT PRIMARY KEY,
	InterviewName NVARCHAR(200),
	CandidateID VARCHAR(50),
	DateInterview DATE,
	StatusInterview VARCHAR(50),
	InterviewCampaignID INT,
	ProfileID INT,
	Score FLOAT,
	LevelInterview INT,
	InterviewCampaignDetailID INT,
	JobVancanyID INT,
	Comment NVARCHAR(200),
	HourInterview NVARCHAR(100),
	ResultInterview NVARCHAR(50),
	RecruitmentHistoryID INT,
	FOREIGN KEY (CandidateID)REFERENCES dbo.Candidate(CandidateID),
	FOREIGN KEY ( InterviewCampaignID) REFERENCES dbo.InterviewCampaign(InterviewCampaignID),
	FOREIGN KEY (InterviewCampaignDetailID) REFERENCES dbo.InterviewCampaignDetail(InterviewCampaignDetailID),
	FOREIGN KEY(JobVancanyID) REFERENCES dbo.JobVancany(JobVancanyID),
	FOREIGN KEY (RecruitmentHistoryID) REFERENCES dbo.Rec_RecruitmentHistory(RecruitmentHistoryID)
);
