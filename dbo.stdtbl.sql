CREATE TABLE [dbo].[stdtbl] (
    [Username]    NVARCHAR (25) NOT NULL,
    [Password]    NVARCHAR (20) NOT NULL,
    [First_Name]  CHAR (20)     NOT NULL,
    [Last_Name]   CHAR (20)     NOT NULL,
    [Phone_No]    NCHAR (12)    NOT NULL,
    [Email]       NVARCHAR (29) NOT NULL,
    [No_of_Books] INT           DEFAULT ((0)) NOT NULL,
    [Bk1]         NVARCHAR (70) DEFAULT ('0') NOT NULL,
    [Bk2]         NVARCHAR (70) DEFAULT ('0') NOT NULL,
    [Bk3]         NVARCHAR (70) DEFAULT ('0') NOT NULL,
    [Dt1] DATE NOT NULL DEFAULT 01/01/9999, 
    [Dt2] DATE NOT NULL DEFAULT 01/01/9999, 
    [Dt3] DATE NOT NULL DEFAULT 01/01/9999, 
    [Fine] INT NOT NULL DEFAULT 0, 
    [Dart1] DATE NOT NULL DEFAULT 01/01/9999, 
    [Dart2] DATE NOT NULL DEFAULT 01/01/9999, 
    [Dart3] DATE NOT NULL DEFAULT 01/01/9999, 
    PRIMARY KEY CLUSTERED ([Username] ASC)
);

