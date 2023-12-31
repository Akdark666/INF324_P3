USE [master]
GO
/****** Object:  Database [academico]    Script Date: 13/12/2023 10:58:37 ******/
CREATE DATABASE [academico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'academico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\academico.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'academico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\academico_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [academico] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [academico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [academico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [academico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [academico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [academico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [academico] SET ARITHABORT OFF 
GO
ALTER DATABASE [academico] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [academico] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [academico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [academico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [academico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [academico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [academico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [academico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [academico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [academico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [academico] SET  DISABLE_BROKER 
GO
ALTER DATABASE [academico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [academico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [academico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [academico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [academico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [academico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [academico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [academico] SET RECOVERY FULL 
GO
ALTER DATABASE [academico] SET  MULTI_USER 
GO
ALTER DATABASE [academico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [academico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [academico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [academico] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [academico]
GO
/****** Object:  User [inf324]    Script Date: 13/12/2023 10:58:37 ******/
CREATE USER [inf324] FOR LOGIN [inf324] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[alumno]    Script Date: 13/12/2023 10:58:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[alumno](
	[ci] [varchar](10) NOT NULL,
	[nombre] [varchar](25) NULL,
	[paterno] [varchar](25) NULL,
	[depto] [varchar](2) NULL,
	[promedio] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ci] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [academico] SET  READ_WRITE 
GO
