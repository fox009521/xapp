USE [master]
GO
/****** Object:  Database [XappDB]    Script Date: 2015/4/13 13:08:53 ******/
CREATE DATABASE [XappDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WEBAPI', FILENAME = N'E:\DB\XappDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WEBAPI_log', FILENAME = N'E:\DB\XappDB_log.ldf' , SIZE = 20096KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [XappDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [XappDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [XappDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [XappDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [XappDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [XappDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [XappDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [XappDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [XappDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [XappDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [XappDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [XappDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [XappDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [XappDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [XappDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [XappDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [XappDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [XappDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [XappDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [XappDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [XappDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [XappDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [XappDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [XappDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [XappDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [XappDB] SET RECOVERY FULL 
GO
ALTER DATABASE [XappDB] SET  MULTI_USER 
GO
ALTER DATABASE [XappDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [XappDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [XappDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [XappDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'XappDB', N'ON'
GO
USE [XappDB]
GO
/****** Object:  UserDefinedFunction [dbo].[GetDoctorMID]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION  [dbo].[GetDoctorMID]
(
	
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE  @temp int;

	-- Add the T-SQL statements to compute the return value here
   
   select @temp=case ISNULL(MAX(DoctorID),'') when ''  then  0 else  MAX(DoctorID) end   from T_Doctor
   set  @temp=@temp+100000+1
	-- Return the result of the function
	RETURN @temp;

END



GO
/****** Object:  UserDefinedFunction [dbo].[GetDoctorTeamMID]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION  [dbo].[GetDoctorTeamMID]
(
	
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE  @temp int;

	-- Add the T-SQL statements to compute the return value here
   
   select @temp=case ISNULL(MAX(TeamID),'') when ''  then  0 else  MAX(TeamID) end   from dbo.T_DoctorTeam
   set  @temp=@temp+100000+1
	-- Return the result of the function
	RETURN @temp;

END



GO
/****** Object:  UserDefinedFunction [dbo].[GetPatientMID]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION  [dbo].[GetPatientMID]
(
	
)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE  @temp int;

	-- Add the T-SQL statements to compute the return value here
  
    select @temp=case ISNULL(MAX(PatientID),'') when ''  then  0 else  MAX(PatientID) end   from T_Patient
   set  @temp=@temp+100000+1
	-- Return the result of the function
	RETURN @temp;

END



GO
/****** Object:  Table [dbo].[T_Action]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Action](
	[ActionID] [int] IDENTITY(1,1) NOT NULL,
	[ActionGID] [nvarchar](128) NOT NULL,
	[ActionName] [nvarchar](128) NOT NULL,
	[ActionImages] [nvarchar](512) NULL,
	[ActionVideos] [nvarchar](512) NULL,
	[ActionMemo] [nvarchar](512) NULL,
	[ActionType] [int] NOT NULL,
	[StatisticalType] [int] NOT NULL,
	[CreateName] [nvarchar](128) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateName] [nvarchar](128) NULL,
	[UpdateTime] [datetime] NULL,
	[IsDel] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK__T_Action__FFE3F4B9C991549D] PRIMARY KEY CLUSTERED 
(
	[ActionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_AppUpgradeInfo]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_AppUpgradeInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VersionCode] [float] NOT NULL,
	[VersionName] [nvarchar](50) NULL,
	[VersionContent] [nvarchar](256) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[IsDel] [int] NOT NULL,
	[OSType] [int] NOT NULL,
	[VersionPublishDate] [datetime] NULL,
	[IsPublish] [bit] NOT NULL,
	[Status] [int] NOT NULL,
	[BuildCode] [nvarchar](128) NULL,
	[DownloadUrl] [nvarchar](256) NULL,
 CONSTRAINT [PK_T_AppUpgradeInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_City]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_City](
	[CityID] [int] NOT NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[CityName] [nvarchar](255) NULL,
	[ProvinceID] [int] NULL,
	[IsDel] [int] NULL,
 CONSTRAINT [PK_T_City] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Doctor]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Doctor](
	[DoctorID] [int] IDENTITY(1,1) NOT NULL,
	[DocotorMID] [nvarchar](64) NOT NULL,
	[DoctorGID] [nvarchar](128) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[Avatar] [nvarchar](255) NULL,
	[Phone] [nvarchar](50) NULL,
	[Password] [nvarchar](255) NULL,
	[IDNumber] [nvarchar](128) NULL,
	[Sex] [int] NULL,
	[Age] [int] NULL,
	[IsDel] [int] NULL,
	[LastLoginTime] [datetime] NULL,
	[DoctorName] [nvarchar](64) NULL,
	[ProvinceName] [nvarchar](50) NULL,
	[CityName] [nvarchar](50) NULL,
	[HospitalName] [nvarchar](255) NULL,
	[Introduce] [nvarchar](512) NULL,
	[Status] [int] NULL,
	[DoctorTitle] [nvarchar](100) NULL,
 CONSTRAINT [PK_T_Doctor] PRIMARY KEY CLUSTERED 
(
	[DoctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_DoctorTeam]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_DoctorTeam](
	[TeamID] [int] IDENTITY(1,1) NOT NULL,
	[TeamMID] [nvarchar](64) NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[UpdateTime] [datetime] NULL,
	[TeamGID] [nvarchar](128) NOT NULL,
	[TeamName] [nvarchar](256) NULL,
	[TeamLogo] [nvarchar](256) NULL,
	[ProvinceName] [nvarchar](50) NULL,
	[CityName] [nvarchar](50) NULL,
	[HospitalName] [nvarchar](256) NULL,
	[IsDel] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[TeamOwnerGID] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK__TuanduiD__6B23296581BEA18E] PRIMARY KEY CLUSTERED 
(
	[TeamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_DoctorTeamApply]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_DoctorTeamApply](
	[TeamApplyID] [int] IDENTITY(1,1) NOT NULL,
	[ApplyContent] [nvarchar](128) NOT NULL,
	[TeamGID] [nvarchar](128) NOT NULL,
	[ApplyResult] [int] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[UpdateTime] [datetime] NULL,
	[IsDel] [int] NULL,
	[Status] [int] NULL,
	[DoctorGID] [nvarchar](128) NULL,
 CONSTRAINT [PK_T_DoctorTeamApply] PRIMARY KEY CLUSTERED 
(
	[TeamApplyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_DoctorTeamMember]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_DoctorTeamMember](
	[TeamMemberID] [int] IDENTITY(1,1) NOT NULL,
	[DoctorGID] [nvarchar](128) NOT NULL,
	[DoctorMID] [nvarchar](64) NULL,
	[Status] [int] NOT NULL,
	[TeamGID] [nvarchar](128) NOT NULL,
	[TeamMID] [nvarchar](64) NULL,
	[CreateTime] [datetime] NOT NULL,
	[UpdateTime] [datetime] NULL,
	[IsDel] [int] NULL,
 CONSTRAINT [PK_T_DoctorMember] PRIMARY KEY CLUSTERED 
(
	[TeamMemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_ExercisesData]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_ExercisesData](
	[ExercisesDataID] [int] IDENTITY(1,1) NOT NULL,
	[ExercisesDataGID] [nvarchar](128) NOT NULL,
	[PatientGID] [nvarchar](128) NOT NULL,
	[ActionGID] [nvarchar](128) NOT NULL,
	[UploadTime] [datetime] NOT NULL,
	[DataValue] [nvarchar](512) NOT NULL,
	[Bak1] [nvarchar](512) NULL,
	[Bak2] [nvarchar](512) NULL,
	[Bak3] [nvarchar](512) NULL,
	[CreateName] [nvarchar](128) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateName] [nvarchar](128) NULL,
	[UpdateTime] [datetime] NULL,
	[IsDel] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK__T_ExercisesData__FFE3F4B9C991549D] PRIMARY KEY CLUSTERED 
(
	[ExercisesDataID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Hospital]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Hospital](
	[HospitalID] [int] NOT NULL,
	[HospitalGID] [nvarchar](128) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[HospitalName] [nvarchar](255) NULL,
	[CityName] [nvarchar](64) NULL,
	[IsDel] [int] NULL,
	[HospitalLevel] [nvarchar](64) NULL,
 CONSTRAINT [PK_T_Hospital] PRIMARY KEY CLUSTERED 
(
	[HospitalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_MedicalMember]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_MedicalMember](
	[MedicalMemberID] [int] IDENTITY(1,1) NOT NULL,
	[MedicalMemberGID] [nvarchar](128) NOT NULL,
	[PatientGID] [nvarchar](128) NOT NULL,
	[PatientMID] [nvarchar](64) NOT NULL,
	[Status] [int] NULL,
	[DoctorGID] [nvarchar](128) NOT NULL,
	[DoctorMID] [nvarchar](64) NOT NULL,
	[ChatGroupID] [nvarchar](128) NULL,
	[TeamID] [nvarchar](128) NULL,
	[BedNum] [nvarchar](128) NULL,
	[AdmissionTime] [datetime] NULL,
	[DiagnosisResult] [nvarchar](128) NULL,
	[RecoveryPlan] [nvarchar](128) NULL,
	[RecoveryPlanTime] [datetime] NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[IsDel] [int] NULL,
 CONSTRAINT [PK_T_MedicalMember] PRIMARY KEY CLUSTERED 
(
	[MedicalMemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Patient]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Patient](
	[PatientID] [int] IDENTITY(1,1) NOT NULL,
	[PatientMID] [nvarchar](64) NOT NULL,
	[PatientGID] [nvarchar](128) NOT NULL,
	[PatientName] [nvarchar](128) NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[UpdateTime] [datetime] NULL,
	[Avatar] [nvarchar](255) NULL,
	[Phone] [nvarchar](50) NULL,
	[Password] [nvarchar](255) NULL,
	[IDNumber] [nvarchar](128) NULL,
	[Sex] [int] NOT NULL,
	[Age] [int] NOT NULL,
	[Address] [nvarchar](255) NULL,
	[ODisease] [nvarchar](256) NULL,
	[TDisease] [nvarchar](256) NULL,
	[THDisease] [nvarchar](256) NULL,
	[ReservationPhone] [nvarchar](256) NULL,
	[FamilyName] [nvarchar](256) NULL,
	[FamilyTelephone] [nvarchar](256) NULL,
	[Height] [int] NOT NULL,
	[Weight] [int] NOT NULL,
	[DiseaseTime] [int] NULL,
	[DiagnosisTime] [int] NULL,
	[IsHighBloodPressure] [int] NOT NULL,
	[HighBloodPressureTime] [int] NULL,
	[IsDiabetes] [int] NOT NULL,
	[DiabetesTime] [int] NULL,
	[IsHeartDisease] [int] NOT NULL,
	[HeartDiseaseTime] [int] NULL,
	[CapacityForAction] [int] NOT NULL,
	[IsDel] [int] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK__HuanzheD__6B23296546D27B73] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Province]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Province](
	[ProvinceID] [int] IDENTITY(1,1) NOT NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[ProvinceName] [nvarchar](64) NULL,
	[IsDel] [int] NULL,
 CONSTRAINT [PK_T_Province] PRIMARY KEY CLUSTERED 
(
	[ProvinceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Report]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Report](
	[ReportID] [int] IDENTITY(1,1) NOT NULL,
	[ReportGID] [nvarchar](128) NOT NULL,
	[PatientID] [nvarchar](128) NOT NULL,
	[DoctorID] [nvarchar](128) NOT NULL,
	[TeamID] [nvarchar](128) NULL,
	[ReportResult] [int] NOT NULL,
	[CreateTime] [datetime] NOT NULL,
	[UpdateTime] [datetime] NULL,
	[IsDel] [int] NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_T_Report] PRIMARY KEY CLUSTERED 
(
	[ReportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_SmsValid]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_SmsValid](
	[SmsID] [int] IDENTITY(1,1) NOT NULL,
	[smsGID] [nvarchar](128) NULL,
	[Phone] [nvarchar](20) NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
	[ValidStatus] [int] NULL,
	[ValidCode] [nvarchar](20) NULL,
	[ValidType] [int] NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_T_SmsValid] PRIMARY KEY CLUSTERED 
(
	[SmsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Stage]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Stage](
	[StageID] [int] IDENTITY(1,1) NOT NULL,
	[StageGID] [nvarchar](128) NOT NULL,
	[FromDay] [int] NOT NULL,
	[StageIndex] [int] NOT NULL,
	[ToDay] [int] NOT NULL,
	[Value] [nvarchar](512) NOT NULL,
	[TargetGID] [nvarchar](128) NOT NULL,
	[CreateName] [nvarchar](128) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateName] [nvarchar](128) NULL,
	[UpdateTime] [datetime] NULL,
	[IsDel] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK__T_Stage__03EB7AF846044A21] PRIMARY KEY CLUSTERED 
(
	[StageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_Template]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Template](
	[TemplateID] [int] IDENTITY(1,1) NOT NULL,
	[TemplateGID] [nvarchar](128) NOT NULL,
	[TemplateName] [nvarchar](128) NOT NULL,
	[TemplateMemo] [nvarchar](512) NULL,
	[DocotorMID] [nvarchar](64) NOT NULL,
	[TeamMID] [nvarchar](64) NOT NULL,
	[TemplateType] [int] NOT NULL,
	[ApplicationType] [int] NOT NULL,
	[BAK1] [nvarchar](512) NULL,
	[BAK2] [nvarchar](512) NULL,
	[CreateName] [nvarchar](128) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateName] [nvarchar](128) NULL,
	[UpdateTime] [datetime] NULL,
	[IsDel] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK__T_Templa__F87ADD070910AC5D] PRIMARY KEY CLUSTERED 
(
	[TemplateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_TemplateDetail]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_TemplateDetail](
	[TemplateDetailID] [int] IDENTITY(1,1) NOT NULL,
	[TemplateDetailGID] [nvarchar](128) NOT NULL,
	[TemplateGID] [nvarchar](128) NOT NULL,
	[ActionType] [int] NOT NULL,
	[ActionGID] [nvarchar](128) NOT NULL,
	[ActionName] [nvarchar](128) NOT NULL,
	[StatisticalType] [int] NOT NULL,
	[CreateName] [nvarchar](128) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateName] [nvarchar](128) NULL,
	[UpdateTime] [datetime] NULL,
	[IsDel] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK__T_Templa__8A5C057D8D94883E] PRIMARY KEY CLUSTERED 
(
	[TemplateDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[T_UserToken]    Script Date: 2015/4/13 13:08:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_UserToken](
	[TokenID] [int] IDENTITY(1,1) NOT NULL,
	[TokenGID] [nvarchar](128) NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
	[CreateTime] [datetime] NULL,
	[Status] [int] NULL,
	[TokenContent] [nvarchar](128) NULL,
	[TokenType] [int] NULL,
	[TokenOwnerGID] [nvarchar](128) NULL,
 CONSTRAINT [PK_T_UserToken] PRIMARY KEY CLUSTERED 
(
	[TokenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[T_Action] ADD  CONSTRAINT [DF__T_Action__Action__6442E2C9]  DEFAULT (newid()) FOR [ActionGID]
GO
ALTER TABLE [dbo].[T_City] ADD  CONSTRAINT [DF_T_City_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[T_Doctor] ADD  CONSTRAINT [DF_T_Doctor_DocotorMID]  DEFAULT ([dbo].[GetDoctorMID]()) FOR [DocotorMID]
GO
ALTER TABLE [dbo].[T_Doctor] ADD  CONSTRAINT [DF_T_Doctor_DoctorGID]  DEFAULT (newid()) FOR [DoctorGID]
GO
ALTER TABLE [dbo].[T_Doctor] ADD  CONSTRAINT [DF_T_Doctor_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[T_Doctor] ADD  CONSTRAINT [DF_T_Doctor_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[T_DoctorTeam] ADD  CONSTRAINT [DF_T_DoctorTeam_TeamMID]  DEFAULT ([dbo].[GetDoctorTeamMID]()) FOR [TeamMID]
GO
ALTER TABLE [dbo].[T_ExercisesData] ADD  CONSTRAINT [DF_T_ExercisesData_ExercisesDataGID]  DEFAULT (newid()) FOR [ExercisesDataGID]
GO
ALTER TABLE [dbo].[T_MedicalMember] ADD  CONSTRAINT [DF_T_MedicalMember_MedicalMemberGID]  DEFAULT (newid()) FOR [MedicalMemberGID]
GO
ALTER TABLE [dbo].[T_Patient] ADD  CONSTRAINT [DF_T_Patient_PatientMID]  DEFAULT ([dbo].[GetPatientMID]()) FOR [PatientMID]
GO
ALTER TABLE [dbo].[T_Patient] ADD  CONSTRAINT [DF_T_Patient_PatientGID]  DEFAULT (newid()) FOR [PatientGID]
GO
ALTER TABLE [dbo].[T_Report] ADD  CONSTRAINT [DF_T_Report_ReportGID]  DEFAULT (newid()) FOR [ReportGID]
GO
ALTER TABLE [dbo].[T_SmsValid] ADD  CONSTRAINT [DF_T_SmsValid_smsGID]  DEFAULT (newid()) FOR [smsGID]
GO
ALTER TABLE [dbo].[T_SmsValid] ADD  CONSTRAINT [DF_T_SmsValid_CreateTime]  DEFAULT (getdate()) FOR [CreateTime]
GO
ALTER TABLE [dbo].[T_Stage] ADD  CONSTRAINT [DF__T_Stage__StageGI__6166761E]  DEFAULT (newid()) FOR [StageGID]
GO
ALTER TABLE [dbo].[T_Template] ADD  CONSTRAINT [DF__T_Templat__Templ__5BAD9CC8]  DEFAULT (newid()) FOR [TemplateGID]
GO
ALTER TABLE [dbo].[T_TemplateDetail] ADD  CONSTRAINT [DF__T_Templat__Templ__7D0E9093]  DEFAULT (newid()) FOR [TemplateDetailGID]
GO
ALTER TABLE [dbo].[T_UserToken] ADD  CONSTRAINT [DF_T_UserToken_TokenGID]  DEFAULT (newid()) FOR [TokenGID]
GO
ALTER TABLE [dbo].[T_UserToken] ADD  CONSTRAINT [DF_T_UserToken_TokenType]  DEFAULT ((1)) FOR [TokenType]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_City', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_City', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'市区名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_City', @level2type=N'COLUMN',@level2name=N'CityName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上级省ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_City', @level2type=N'COLUMN',@level2name=N'ProvinceID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_City', @level2type=N'COLUMN',@level2name=N'IsDel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'医生ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'DocotorMID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'医生系统内部编号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'DoctorGID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更新时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'头像' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'Avatar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'移动号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'年龄' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'Age'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否删除' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'IsDel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'上次登陆时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'LastLoginTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'医生名字' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'DoctorName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'省' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'ProvinceName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'市' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'CityName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'所在医院' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'HospitalName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'个人介绍' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'Introduce'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态 ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'医生职称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Doctor', @level2type=N'COLUMN',@level2name=N'DoctorTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'团队ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_DoctorTeam', @level2type=N'COLUMN',@level2name=N'TeamMID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'团队名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_DoctorTeam', @level2type=N'COLUMN',@level2name=N'TeamName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'团队图标' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_DoctorTeam', @level2type=N'COLUMN',@level2name=N'TeamLogo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'省' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_DoctorTeam', @level2type=N'COLUMN',@level2name=N'ProvinceName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'团队所有者的GID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_DoctorTeam', @level2type=N'COLUMN',@level2name=N'TeamOwnerGID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'申请内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_DoctorTeamApply', @level2type=N'COLUMN',@level2name=N'ApplyContent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'团队GID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_DoctorTeamApply', @level2type=N'COLUMN',@level2name=N'TeamGID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'申请结果' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_DoctorTeamApply', @level2type=N'COLUMN',@level2name=N'ApplyResult'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'医院名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Hospital', @level2type=N'COLUMN',@level2name=N'HospitalName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'医院等级' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Hospital', @level2type=N'COLUMN',@level2name=N'HospitalLevel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手机号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_SmsValid', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'短信有效开始时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_SmsValid', @level2type=N'COLUMN',@level2name=N'StartTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'短信有效结束时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_SmsValid', @level2type=N'COLUMN',@level2name=N'EndTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'验证状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_SmsValid', @level2type=N'COLUMN',@level2name=N'ValidStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'验证码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_SmsValid', @level2type=N'COLUMN',@level2name=N'ValidCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'验证类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_SmsValid', @level2type=N'COLUMN',@level2name=N'ValidType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'有效开始时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_UserToken', @level2type=N'COLUMN',@level2name=N'StartTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'有效结束时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_UserToken', @level2type=N'COLUMN',@level2name=N'EndTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'TOKEN内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_UserToken', @level2type=N'COLUMN',@level2name=N'TokenContent'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'TOKEN类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_UserToken', @level2type=N'COLUMN',@level2name=N'TokenType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'TOKEN所有者的GID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_UserToken', @level2type=N'COLUMN',@level2name=N'TokenOwnerGID'
GO
USE [master]
GO
ALTER DATABASE [XappDB] SET  READ_WRITE 
GO
