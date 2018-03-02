﻿----===Create Database===----
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

-----====DELETE dbo.Account====----
------dang nhap---
--CREATE TABLE dbo.Account
--(
--	Username NVARCHAR(150)PRIMARY KEY,
--	Password VARCHAR(50),
--	UserID int,
--	FOREIGN KEY (UserID) REFERENCES dbo.Register(UserID)
--);
----Nhan vien ---
CREATE TABLE dbo.Profile
(
	ProfileID int IDENTITY(1,1) PRIMARY KEY,
	ProfileName NVARCHAR(200),
	CodeEmp NVARCHAR(200),
	DateBrith DATE,
	StatusHire VARCHAR(50),
);
----dieu kien tuyen---
CREATE TABLE dbo.JobCondition
(
	JobConditionID INT  IDENTITY(1,1) PRIMARY KEY,
	JobConditionName NVARCHAR(100),
	Value1 VARCHAR(10),
	Value2 INT 
);
----yeu cau tuyen dung----
CREATE TABLE dbo.JobVancany
(
	JobVancanyID INT IDENTITY(1,1) PRIMARY KEY,
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
	CandidateID INT IDENTITY(1,1) PRIMARY KEY,
	CandidateName NVARCHAR(200),
	CodeCandidate VARCHAR(50),
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
	RecruitmentHistoryID Int IDENTITY(1,1) PRIMARY KEY,
	CandidateName NVARCHAR(200),
	Gender VARCHAR(50),
	LevelInterview INT,
	JobVancanyID INT,
	CandidateID INT,
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
	FOREIGN KEY (ProfileID) REFERENCES dbo.Profile(ProfileID),
	FOREIGN KEY (InterviewCampaignID) REFERENCES dbo.InterviewCampaign(InterviewCampaignID),
	FOREIGN KEY (CandidateID) REFERENCES dbo.Candidate(CandidateID)
);
----phong van----
CREATE TABLE dbo.Interview
(
	InterviewID INT IDENTITY(1,1) PRIMARY KEY,
	InterviewName NVARCHAR(200),
	CandidateID INT,
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
