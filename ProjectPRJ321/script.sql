USE [master]
GO
/****** Object:  Database [animalss]    Script Date: 01/04/02021 2:44:33 PM ******/
CREATE DATABASE [animalss]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'animalss', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.TIENANH\MSSQL\DATA\animalss.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'animalss_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.TIENANH\MSSQL\DATA\animalss_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [animalss] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [animalss].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [animalss] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [animalss] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [animalss] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [animalss] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [animalss] SET ARITHABORT OFF 
GO
ALTER DATABASE [animalss] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [animalss] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [animalss] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [animalss] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [animalss] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [animalss] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [animalss] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [animalss] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [animalss] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [animalss] SET  ENABLE_BROKER 
GO
ALTER DATABASE [animalss] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [animalss] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [animalss] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [animalss] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [animalss] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [animalss] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [animalss] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [animalss] SET RECOVERY FULL 
GO
ALTER DATABASE [animalss] SET  MULTI_USER 
GO
ALTER DATABASE [animalss] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [animalss] SET DB_CHAINING OFF 
GO
ALTER DATABASE [animalss] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [animalss] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [animalss] SET DELAYED_DURABILITY = DISABLED 
GO
USE [animalss]
GO
/****** Object:  Table [dbo].[account]    Script Date: 01/04/02021 2:44:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adminController]    Script Date: 01/04/02021 2:44:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adminController](
	[adminAccount] [nvarchar](50) NOT NULL,
	[adminPass] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[adminAccount] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[bill]    Script Date: 01/04/02021 2:44:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bill](
	[username] [nvarchar](50) NOT NULL,
	[total] [int] NOT NULL,
	[dateofpayment] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[contact]    Script Date: 01/04/02021 2:44:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contact](
	[name] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](50) NOT NULL,
	[contents] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_contact] PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[email]    Script Date: 01/04/02021 2:44:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[email](
	[username] [nvarchar](50) NOT NULL,
	[mail] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[information]    Script Date: 01/04/02021 2:44:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[information](
	[id] [int] NOT NULL,
	[name] [nvarchar](max) NOT NULL,
	[origin] [nvarchar](max) NOT NULL,
	[price] [int] NOT NULL,
	[description] [nvarchar](max) NOT NULL,
	[image] [nvarchar](max) NOT NULL,
	[amount] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[bill]  WITH CHECK ADD FOREIGN KEY([username])
REFERENCES [dbo].[account] ([username])
GO
ALTER TABLE [dbo].[bill]  WITH CHECK ADD FOREIGN KEY([username])
REFERENCES [dbo].[account] ([username])
GO
ALTER TABLE [dbo].[email]  WITH CHECK ADD FOREIGN KEY([username])
REFERENCES [dbo].[account] ([username])
GO
ALTER TABLE [dbo].[email]  WITH CHECK ADD FOREIGN KEY([username])
REFERENCES [dbo].[account] ([username])
GO
USE [master]
GO
ALTER DATABASE [animalss] SET  READ_WRITE 
GO
