USE [master]
GO
/****** Object:  Database [ecommerce_test]    Script Date: 4/25/2024 2:51:39 PM ******/
CREATE DATABASE [ecommerce_test]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ecommerce_test', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MYSQLEXPRESS\MSSQL\DATA\ecommerce_test.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ecommerce_test_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MYSQLEXPRESS\MSSQL\DATA\ecommerce_test_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ecommerce_test] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ecommerce_test].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ecommerce_test] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ecommerce_test] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ecommerce_test] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ecommerce_test] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ecommerce_test] SET ARITHABORT OFF 
GO
ALTER DATABASE [ecommerce_test] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ecommerce_test] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ecommerce_test] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ecommerce_test] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ecommerce_test] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ecommerce_test] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ecommerce_test] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ecommerce_test] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ecommerce_test] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ecommerce_test] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ecommerce_test] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ecommerce_test] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ecommerce_test] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ecommerce_test] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ecommerce_test] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ecommerce_test] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ecommerce_test] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ecommerce_test] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ecommerce_test] SET  MULTI_USER 
GO
ALTER DATABASE [ecommerce_test] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ecommerce_test] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ecommerce_test] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ecommerce_test] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ecommerce_test] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ecommerce_test] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ecommerce_test] SET QUERY_STORE = ON
GO
ALTER DATABASE [ecommerce_test] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ecommerce_test]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 4/25/2024 2:51:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[logininfos]    Script Date: 4/25/2024 2:51:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[logininfos](
	[FirstName] [nvarchar](450) NOT NULL,
	[LastName] [nvarchar](450) NOT NULL,
	[Password] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_logininfos] PRIMARY KEY CLUSTERED 
(
	[FirstName] ASC,
	[LastName] ASC,
	[Password] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 4/25/2024 2:51:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[id] [int] NOT NULL,
	[Name] [varchar](255) NULL,
	[price] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[storeitems]    Script Date: 4/25/2024 2:51:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[storeitems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [int] NOT NULL,
 CONSTRAINT [PK_storeitems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 4/25/2024 2:51:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [ecommerce_test] SET  READ_WRITE 
GO
