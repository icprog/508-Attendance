--2014-3-12 ���ӿ�����
if not exists (SELECT * FROM dbo.syscolumns WHERE name ='CardID' AND id = OBJECT_ID(N'[dbo].[TAStaff]')) 
BEGIN
	exec ('alter table TAStaff add CardID nvarchar(50) null')
end
go

--2014-3-12 ���ӿ�����
if not exists (SELECT * FROM dbo.syscolumns WHERE name ='Password' AND id = OBJECT_ID(N'[dbo].[TAStaff]')) 
BEGIN
	exec ('alter table TAStaff add Password nvarchar(50) null')
end
go