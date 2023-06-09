USE [master]
GO
/****** Object:  Database [vtalk-channel]    Script Date: 6/11/2023 6:57:16 PM ******/
CREATE DATABASE [vtalk-channel]

GO
ALTER DATABASE [vtalk-channel] SET COMPATIBILITY_LEVEL = 160

GO
ALTER DATABASE [vtalk-channel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [vtalk-channel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [vtalk-channel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [vtalk-channel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [vtalk-channel] SET ARITHABORT OFF 
GO
ALTER DATABASE [vtalk-channel] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [vtalk-channel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [vtalk-channel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [vtalk-channel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [vtalk-channel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [vtalk-channel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [vtalk-channel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [vtalk-channel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [vtalk-channel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [vtalk-channel] SET  ENABLE_BROKER 
GO
ALTER DATABASE [vtalk-channel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [vtalk-channel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [vtalk-channel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [vtalk-channel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [vtalk-channel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [vtalk-channel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [vtalk-channel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [vtalk-channel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [vtalk-channel] SET  MULTI_USER 
GO
ALTER DATABASE [vtalk-channel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [vtalk-channel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [vtalk-channel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [vtalk-channel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [vtalk-channel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [vtalk-channel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [vtalk-channel] SET QUERY_STORE = OFF
GO
USE [vtalk-channel]
GO
/****** Object:  Table [dbo].[Channel]    Script Date: 6/11/2023 6:57:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Channel](
	[Id] [uniqueidentifier] NOT NULL,
	[ChannelName] [varchar](255) NULL,
	[Avatar] [varchar](512) NULL,
	[InvitationCode] [char](36) NULL,
	[CreatedAt] [datetime] NULL,
	[CreatedBy] [char](36) NULL,
	[UpdatedAt] [datetime] NULL,
	[UpdatedBy] [char](36) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Channel] ([Id], [ChannelName], [Avatar], [InvitationCode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'64ba8f77-7125-4ff9-2e0b-08db642b5406', N'string', N'string', N'iCEnkmOkEHokdcg                     ', CAST(N'2023-06-03T12:09:05.833' AS DateTime), N'00000000-0000-0000-0000-000000000000', CAST(N'2023-06-03T12:09:05.833' AS DateTime), N'00000000-0000-0000-0000-000000000000')
INSERT [dbo].[Channel] ([Id], [ChannelName], [Avatar], [InvitationCode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'd958a0e8-6754-41f3-d81a-08db6454de90', N'string', N'string', N'WLVmdVzyNzavEvT                     ', CAST(N'2023-06-03T17:06:27.117' AS DateTime), N'00000000-0000-0000-0000-000000000000', CAST(N'2023-06-03T17:06:27.117' AS DateTime), N'00000000-0000-0000-0000-000000000000')
INSERT [dbo].[Channel] ([Id], [ChannelName], [Avatar], [InvitationCode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'a8d32dcb-7dcc-4ef4-7ea6-08db64565e5a', N'Vy''s Channel', N'vy.com', N'ZRUhsbMiBnAqrFs                     ', CAST(N'2023-06-03T17:17:07.957' AS DateTime), N'00000000-0000-0000-0000-000000000000', CAST(N'2023-06-03T17:17:07.957' AS DateTime), N'00000000-0000-0000-0000-000000000000')
INSERT [dbo].[Channel] ([Id], [ChannelName], [Avatar], [InvitationCode], [CreatedAt], [CreatedBy], [UpdatedAt], [UpdatedBy]) VALUES (N'6509ff14-d0ea-4979-6de8-08db69dfece0', N'ssss', N'ssss', N'WtczGokDIAQpPVw                     ', CAST(N'2023-06-10T18:24:25.243' AS DateTime), N'4b4df7d7-5018-436f-6763-08db69d90b3d', NULL, NULL)
GO
USE [master]
GO
ALTER DATABASE [vtalk-channel] SET  READ_WRITE 
GO
