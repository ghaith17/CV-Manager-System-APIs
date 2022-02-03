USE  Repository 
GO


CREATE TABLE  dbo.Personal_Information  (
     Id     INT IDENTITY(1,1) PRIMARY KEY 
,    FullName   VARCHAR(50) NOT NULL
,    CityName   VARCHAR(50) 
,    Email   VARCHAR(50) 
,    MobileNumber   VARCHAR(50) 
);



CREATE TABLE  dbo.Experience_Information  (
     Id     INT IDENTITY(1,1) PRIMARY KEY
,    CompanyName   VARCHAR(20) NOT NULL
,    City   VARCHAR(50) 
,    CompanyField   VARCHAR(50) 
);
CREATE TABLE  dbo.CV  (
     Id     INT IDENTITY(1,1) PRIMARY KEY
,    Name   VARCHAR(50)
,    Personal_Information_Id  INT UNIQUE FOREIGN KEY  REFERENCES dbo.Personal_Information(Id) NOT NULL
,    Experience_Information_Id  INT FOREIGN KEY REFERENCES dbo.Experience_Information(Id)

);
GO
