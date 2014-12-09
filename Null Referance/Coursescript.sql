USE [master]
GO
/****** Object:  Database [StudentCourse]    Script Date: 18/10/2014 1:42:15 PM ******/
CREATE DATABASE [StudentCourse]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StudentCourse', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\StudentCourse.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'StudentCourse_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\StudentCourse_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [StudentCourse] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StudentCourse].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StudentCourse] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StudentCourse] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StudentCourse] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StudentCourse] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StudentCourse] SET ARITHABORT OFF 
GO
ALTER DATABASE [StudentCourse] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StudentCourse] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [StudentCourse] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StudentCourse] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StudentCourse] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StudentCourse] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StudentCourse] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StudentCourse] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StudentCourse] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StudentCourse] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StudentCourse] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StudentCourse] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StudentCourse] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StudentCourse] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StudentCourse] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StudentCourse] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StudentCourse] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StudentCourse] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StudentCourse] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StudentCourse] SET  MULTI_USER 
GO
ALTER DATABASE [StudentCourse] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StudentCourse] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StudentCourse] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StudentCourse] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [StudentCourse]
GO
/****** Object:  Table [dbo].[t_Course]    Script Date: 18/10/2014 1:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_Course](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [varchar](50) NOT NULL,
	[EnrollDate] [date] NOT NULL,
	[Score] [int] NOT NULL,
	[PubluishDate] [date] NOT NULL,
 CONSTRAINT [PK_t_Course] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[t_Student]    Script Date: 18/10/2014 1:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[t_Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[regNo] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_t_Student] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [StudentCourse] SET  READ_WRITE 
GO
