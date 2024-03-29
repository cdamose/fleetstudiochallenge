USE [master]
GO
/****** Object:  Database [movie_db]    Script Date: 23-07-2019 20:24:15 ******/
CREATE DATABASE [movie_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'movie_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\movie_db.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'movie_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\movie_db_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [movie_db] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [movie_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [movie_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [movie_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [movie_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [movie_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [movie_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [movie_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [movie_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [movie_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [movie_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [movie_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [movie_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [movie_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [movie_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [movie_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [movie_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [movie_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [movie_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [movie_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [movie_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [movie_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [movie_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [movie_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [movie_db] SET RECOVERY FULL 
GO
ALTER DATABASE [movie_db] SET  MULTI_USER 
GO
ALTER DATABASE [movie_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [movie_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [movie_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [movie_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [movie_db] SET DELAYED_DURABILITY = DISABLED 
GO
USE [movie_db]
GO
/****** Object:  Table [dbo].[movie_generics]    Script Date: 23-07-2019 20:24:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movie_generics](
	[id] [nvarchar](50) NOT NULL,
	[movie_generics] [numeric](18, 0) NULL,
	[created_date] [date] NULL,
 CONSTRAINT [PK_movie_generics] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[movie_list]    Script Date: 23-07-2019 20:24:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[movie_list](
	[id] [nvarchar](50) NOT NULL,
	[movie_name] [nvarchar](max) NULL,
	[released_date] [date] NULL,
	[actor_name] [nvarchar](50) NULL,
	[actres_name] [nvarchar](50) NULL,
	[genric_type] [nvarchar](50) NULL,
 CONSTRAINT [PK_movie_list] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_intrested_generics]    Script Date: 23-07-2019 20:24:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_intrested_generics](
	[id] [nvarchar](50) NOT NULL,
	[user_id] [nvarchar](50) NOT NULL,
	[user_intrest_id] [nvarchar](50) NOT NULL,
	[created_date] [date] NOT NULL,
 CONSTRAINT [PK_user_intrested_generics] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 23-07-2019 20:24:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [nvarchar](50) NOT NULL,
	[name] [nchar](100) NULL,
	[mobile] [nchar](10) NULL,
	[email] [nvarchar](100) NULL,
	[isVerified] [bit] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[movie_list]  WITH CHECK ADD  CONSTRAINT [FK_movie_list_movie_generics1] FOREIGN KEY([genric_type])
REFERENCES [dbo].[movie_generics] ([id])
GO
ALTER TABLE [dbo].[movie_list] CHECK CONSTRAINT [FK_movie_list_movie_generics1]
GO
ALTER TABLE [dbo].[user_intrested_generics]  WITH CHECK ADD  CONSTRAINT [FK_user_intrested_generics_users] FOREIGN KEY([user_intrest_id])
REFERENCES [dbo].[movie_generics] ([id])
GO
ALTER TABLE [dbo].[user_intrested_generics] CHECK CONSTRAINT [FK_user_intrested_generics_users]
GO
USE [master]
GO
ALTER DATABASE [movie_db] SET  READ_WRITE 
GO
