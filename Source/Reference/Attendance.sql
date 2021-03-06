
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAAttendanceResult]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAAttendanceResult](
	[ID] [uniqueidentifier] NOT NULL,
	[StaffID] [int] NOT NULL,
	[StaffName] [nvarchar](50) NOT NULL,
	[ShiftDate] [datetime] NOT NULL,
	[ShiftID] [nvarchar](50) NULL,
	[ShiftName] [nvarchar](50) NULL,
	[SheetType] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NOT NULL,
	[OnDutyTime] [datetime] NULL,
	[OffDutyTime] [datetime] NULL,
	[ShiftTime] [decimal](10, 4) NOT NULL,
	[Present] [decimal](10, 4) NOT NULL,
	[Absent] [decimal](10, 4) NOT NULL,
	[BeLate] [decimal](10, 4) NOT NULL,
	[LeaveEarly] [decimal](10, 4) NOT NULL,
	[OTTime] [decimal](10, 4) NOT NULL,
	[Result] [tinyint] NOT NULL,
	[Modified] [bit] NOT NULL,
	[Modifier] [nvarchar](50) NULL,
	[ModifiedTime] [datetime] NULL,
	[Approval] [nvarchar](50) NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TAAttendanceResult] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TASheet]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TASheet](
	[StaffID] [int] NOT NULL,
	[SheetID] [nvarchar](50) NOT NULL,
	[SheetType] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[StaffName] [nvarchar](50) NOT NULL,
	[Department] [nvarchar](50) NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[Header] [nvarchar](50) NULL,
	[Manager] [nvarchar](50) NULL,
	[HR] [nvarchar](50) NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TASheet_1] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC,
	[SheetID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAShiftArrange]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAShiftArrange](
	[StaffID] [int] NOT NULL,
	[ShiftID] [nvarchar](50) NOT NULL,
	[ShiftDate] [datetime] NOT NULL,
 CONSTRAINT [PK_TAShiftArrange] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC,
	[ShiftID] ASC,
	[ShiftDate] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAStaff]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAStaff](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DepartmentID] [nvarchar](50) NULL,
	[CardID] [nvarchar](50) null,
	[Sex] [nvarchar](50) NULL,
	[Birthday] [datetime] NULL,
	[Certificate] [nvarchar](50) NULL,
	[UserPosition] [nvarchar](50) NULL,
	[HireDate] [datetime] NOT NULL,
	[Resigned] [bit] NOT NULL,
	[ResignDate] [datetime] NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAStaffPhoto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAStaffPhoto](
	[StaffID] [int] NOT NULL,
	[Photo] [image] NOT NULL,
 CONSTRAINT [PK_StaffPhoto] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAVacationType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAVacationType](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TAVacationType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAOTType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAOTType](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Multiple] [decimal](10, 2) NOT NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TAOTType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAShiftItem]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAShiftItem](
	[ID] [uniqueidentifier] NOT NULL,
	[ShiftID] [nvarchar](50) NOT NULL,
	[StartTime] [varchar](6) NOT NULL,
	[LogAtStart] [bit] NOT NULL,
	[NextDay] [bit] NOT NULL,
	[EndTime] [varchar](6) NOT NULL,
	[LogAtEnd] [bit] NOT NULL,
	[AllowLateTime] [decimal](10, 4) NOT NULL,
	[AllowLeaveEarlyTime] [decimal](10, 4) NOT NULL,
	[BeforeStartTime] [decimal](10, 4) NOT NULL,
	[AfterEndTime] [decimal](10, 4) NOT NULL,
	[Duration] [decimal](10, 4) NOT NULL,
 CONSTRAINT [PK_TAShiftItem_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TADepartment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TADepartment](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ParentID] [nvarchar](50) NOT NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TADepartment] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAOperator]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAOperator](
	[ID] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[RoleID] [nvarchar](50) NOT NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TAOperator] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAOperatorDept]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAOperatorDept](
	[OperatorID] [nvarchar](50) NOT NULL,
	[DepartmentID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TAOperatorDept] PRIMARY KEY CLUSTERED 
(
	[OperatorID] ASC,
	[DepartmentID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TARole]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TARole](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Permission] [nvarchar](1000) NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TARoles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TATripType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TATripType](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TATripType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StringID]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StringID](
	[Prefix] [nvarchar](50) NOT NULL,
	[Serial] [bigint] NOT NULL,
	[Entity] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StringID] PRIMARY KEY CLUSTERED 
(
	[Prefix] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAShift]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAShift](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ShortName] [nvarchar](50) NULL,
 CONSTRAINT [PK_TAShift] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAHoliday]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAHoliday](
	[ID] [nvarchar](50) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[WeekendToWorkDay1] [datetime] NULL,
	[WeekendToWorkDay2] [datetime] NULL,
	[WeekendToWorkDay3] [datetime] NULL,
	[WeekendToWorkDay4] [datetime] NULL,
	[WeekendToWorkDay5] [datetime] NULL,
	[WeekendToWorkDay6] [datetime] NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TAHoliday] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAParameter]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAParameter](
	[ID] [nvarchar](200) NOT NULL,
	[Value] [nvarchar](4000) NULL,
 CONSTRAINT [PK_TAParameter] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAShiftTemplate]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAShiftTemplate](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Options] [tinyint] NOT NULL,
	[Value] [nvarchar](4000) NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_ShiftArrangeTemplate] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TASheetItem]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TASheetItem](
	[ID] [uniqueidentifier] NOT NULL,
	[SheetID] [nvarchar](50) NOT NULL,
	[StartTime] [nvarchar](50) NOT NULL,
	[NextDay] [bit] NOT NULL,
	[EndTime] [nvarchar](50) NOT NULL,
	[Duration] [decimal](10, 4) NOT NULL,
 CONSTRAINT [PK_TASheetItem_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TADeviceGroup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TADeviceGroup](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ParentID] [nvarchar](50) NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TADeviceGroup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TADeviceInfo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TADeviceInfo](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DeviceType] [int] NOT NULL,
	[Serial] [nvarchar](50) NULL,
	[Communication] [int] NOT NULL,
	[IP] [nvarchar](50) NULL,
	[IPMask] [nvarchar](50) NULL,
	[Gateway] [nvarchar](50) NULL,
	[ControlPort] [int] NULL,
	[EventPort] [int] NULL,
	[Commport] [int] NULL,
	[Baud] [int] NULL,
	[Address] [int] NULL,
	[ForAttendance] [bit] NOT NULL,
	[GroupID] [nvarchar](50) NULL,
 CONSTRAINT [PK_TADeviceInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAStaffCategory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAStaffCategory](
	[ID] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TAStaffCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAStaffBioTemplate]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAStaffBioTemplate](
	[ID] [uniqueidentifier] NOT NULL,
	[StaffID] [int] NOT NULL,
	[BioSource] [int] NOT NULL,
	[Version] [nvarchar](50) NOT NULL,
	[Template] [nvarchar](4000) NOT NULL,
	[IsBiokey] [bit] NOT NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TAStaffBioTemplate] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAAbsentItem]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAAbsentItem](
	[ID] [uniqueidentifier] NOT NULL,
	[ResultID] [uniqueidentifier] NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[Duration] [decimal](10, 4) NOT NULL,
 CONSTRAINT [PK_TAAbsentItem] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntegerID]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[IntegerID](
	[Entity] [nvarchar](50) NOT NULL,
	[Value] [bigint] NOT NULL,
 CONSTRAINT [PK_IntegerID] PRIMARY KEY CLUSTERED 
(
	[Entity] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TAAttendanceLog]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TAAttendanceLog](
	[StaffID] [int] NOT NULL,
	[ReadDateTime] [datetime] NOT NULL,
	[StaffName] [varchar](50) NULL,
	[ReaderID] [nvarchar](50) NULL,
	[ReaderName] [varchar](50) NULL,
	[IsManual] [bit] NOT NULL,
	[Memo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TAAttendanceLog_1] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC,
	[ReadDateTime] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END

-----默认的操作员和角色
if not exists (select * from TAOperator where ID='admin')
insert into taoperator (ID,[Name],Password,RoleID) values('admin','系统管理员','123','SysAdmin')

if not exists (select * from TARole where ID='SysAdmin')
insert into TARole (ID,[Name],Permission,Memo) values('SysAdmin','系统管理员','all','系统管理员，有系统所有的权限.')
