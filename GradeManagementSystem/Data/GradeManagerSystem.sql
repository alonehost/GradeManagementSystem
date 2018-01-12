CREATE DATABASE SG;
GO
use SG
GO
-- Teacher ��ʦ�˺ű���
CREATE TABLE Teacher(
	Username nchar(20) PRIMARY KEY ,
	Password nchar(20) 
) ;
GO

-- ��ʦ�˺Ų���
INSERT INTO Teacher
values ('teacher','teacher'),
('monitor','monitor');

-- chb ��˱���
CREATE TABLE chb(
	Sno nchar(100) PRIMARY KEY,
	Sname nchar(10) ,
	Grade int 
) ;

GO


-- dyb ����������

CREATE TABLE dyb(
	Sno nchar(100) PRIMARY KEY,
	Sname nchar(100) ,
	Sc smallint ,
	Sd smallint ,
	Se smallint ,
	Sf smallint ,
	Sg smallint ,
	Grade int ,
	Nopass int
);

GO

-- zyb ����������

CREATE TABLE zyb(
	Sno nchar(100) PRIMARY KEY ,
	Sname nchar(100) ,
	Sc smallint ,
	Sd smallint ,
	Se smallint ,
	Grade int ,
	Nopass int
);

GO

-- �ۺ���ͼ������
create view zhb
as
SELECT a.Sno,a.Sname ,zyavg, zyrank, dyavg, dyrank, (zyavg*0.7 + dyavg*0.3) zhavg, row_number() OVER (ORDER BY (zyavg*0.7 + dyavg*0.3) DESC) zhrank, (zynopass + dynopass) nopass
FROM (SELECT Sno,Sname, Grade AS zyavg, row_number() OVER (ORDER BY Grade DESC) AS zyrank, Nopass AS zynopass
FROM zyb ) a 
JOIN
(SELECT Sno,Sname ,Grade AS dyavg, row_number() OVER (ORDER BY Grade DESC) AS dyrank, Nopass as dynopass
FROM dyb) b ON a.Sno = b.Sno;

GO

-- temp��ͼ������
create view temp
as
SELECT Sno, Sname,zyavg, row_number() OVER (ORDER BY zyavg DESC) AS zyrank, dyavg, row_number() OVER (ORDER BY dyavg DESC) AS dyrank, zhavg,row_number() OVER (ORDER BY zhavg DESC) zhrank
FROM zhb
WHERE nopass = 0;

GO