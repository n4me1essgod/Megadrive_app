USE [master]
GO
/****** Object:  Database [_Subota_bd]    Script Date: 25.03.2023 13:05:38 ******/
CREATE DATABASE [_Subota_bd]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'_Subota_bd', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\_Subota_bd.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'_Subota_bd_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\_Subota_bd_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [_Subota_bd] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [_Subota_bd].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [_Subota_bd] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [_Subota_bd] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [_Subota_bd] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [_Subota_bd] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [_Subota_bd] SET ARITHABORT OFF 
GO
ALTER DATABASE [_Subota_bd] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [_Subota_bd] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [_Subota_bd] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [_Subota_bd] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [_Subota_bd] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [_Subota_bd] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [_Subota_bd] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [_Subota_bd] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [_Subota_bd] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [_Subota_bd] SET  DISABLE_BROKER 
GO
ALTER DATABASE [_Subota_bd] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [_Subota_bd] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [_Subota_bd] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [_Subota_bd] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [_Subota_bd] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [_Subota_bd] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [_Subota_bd] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [_Subota_bd] SET RECOVERY FULL 
GO
ALTER DATABASE [_Subota_bd] SET  MULTI_USER 
GO
ALTER DATABASE [_Subota_bd] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [_Subota_bd] SET DB_CHAINING OFF 
GO
ALTER DATABASE [_Subota_bd] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [_Subota_bd] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [_Subota_bd] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'_Subota_bd', N'ON'
GO
ALTER DATABASE [_Subota_bd] SET QUERY_STORE = OFF
GO
USE [_Subota_bd]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [_Subota_bd]
GO
/****** Object:  Table [dbo].[transport_type]    Script Date: 25.03.2023 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transport_type](
	[transport_type_id] [int] NOT NULL,
	[transport_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_transport_type] PRIMARY KEY CLUSTERED 
(
	[transport_type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[transport]    Script Date: 25.03.2023 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[transport](
	[transport_id] [int] NOT NULL,
	[transport_type_id] [int] NULL,
	[transport_color] [varchar](50) NULL,
	[transport_model] [varchar](50) NULL,
	[transport_number] [varchar](10) NULL,
	[transport_manufacture_date] [date] NULL,
	[transport_enabled] [bit] NULL,
	[current_point_location_number] [int] NULL,
	[current_point_location_address] [varchar](50) NULL,
	[price] [money] NULL,
 CONSTRAINT [PK_transport] PRIMARY KEY CLUSTERED 
(
	[transport_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Transport_view]    Script Date: 25.03.2023 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Transport_view]
AS
SELECT        dbo.transport.transport_id, dbo.transport_type.transport_name, dbo.transport.transport_color, dbo.transport.transport_model, dbo.transport.transport_number, dbo.transport.transport_manufacture_date, 
                         dbo.transport.transport_enabled, dbo.transport.current_point_location_number, dbo.transport.current_point_location_address, dbo.transport.price
FROM            dbo.transport INNER JOIN
                         dbo.transport_type ON dbo.transport.transport_type_id = dbo.transport_type.transport_type_id
GO
/****** Object:  View [dbo].[Transport_view_cuted]    Script Date: 25.03.2023 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Transport_view_cuted]
AS
SELECT        dbo.transport_type.transport_name, dbo.transport.transport_color, dbo.transport.transport_model, dbo.transport.transport_number, dbo.transport.transport_enabled
FROM            dbo.transport INNER JOIN
                         dbo.transport_type ON dbo.transport.transport_type_id = dbo.transport_type.transport_type_id
GO
/****** Object:  Table [dbo].[clients]    Script Date: 25.03.2023 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clients](
	[client_id] [int] NOT NULL,
	[name] [varchar](50) NULL,
	[surname] [varchar](50) NULL,
	[patronymic] [varchar](50) NULL,
	[phone_number] [varchar](50) NULL,
 CONSTRAINT [PK_clients] PRIMARY KEY CLUSTERED 
(
	[client_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clients_transports]    Script Date: 25.03.2023 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clients_transports](
	[client_id] [int] NOT NULL,
	[transport_id] [int] NOT NULL,
	[date_begin] [datetime] NULL,
	[date_end] [datetime] NULL,
	[begin_point] [varchar](50) NULL,
	[end_point] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 25.03.2023 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[role_id] [int] NOT NULL,
	[role_name] [varchar](50) NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 25.03.2023 13:05:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[login] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[role_id] [int] NULL,
	[client_id] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (1, N'Геннадий', N'Морозов', N'Валерьевич', N'9963433')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (2, N'Илья', N'Седаков', N'Васильевич', N'1243953')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (3, N'Филипп', N'Киркоров', N'Бедросович', N'2853912')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (4, N'Дмитрий', N'Комаров', N'Николаевич', N'8866003')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (5, N'Арина', N'Мартынович', N'Михайловна', N'1234567')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (6, N'Исаак', N'Израилев', N'Моисеевич', N'5031232')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (7, N'Борис', N'Сергеев', N'Николаевич', N'9531230')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (8, N'Алиса', N'Климова', N'Александровна', N'4542341')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (9, N'Владислав', N'Куликов', N'Даниилович', N'8663312')
INSERT [dbo].[clients] ([client_id], [name], [surname], [patronymic], [phone_number]) VALUES (10, N'Олег', N'Коротков', N'Матвеевич', N'9257843')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (8, 5, CAST(N'2023-03-01T00:00:00.000' AS DateTime), CAST(N'2023-05-01T00:00:00.000' AS DateTime), N'1', N'1')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (8, 4, CAST(N'2023-03-02T00:00:00.000' AS DateTime), CAST(N'2023-03-10T00:00:00.000' AS DateTime), N'1', N'1')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (8, 4, CAST(N'2023-03-15T00:00:00.000' AS DateTime), CAST(N'2023-03-30T00:00:00.000' AS DateTime), N'2', NULL)
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (9, 5, CAST(N'2022-12-12T00:00:00.000' AS DateTime), CAST(N'2023-01-11T00:00:00.000' AS DateTime), N'3', N'3')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (1, 10, CAST(N'2023-02-01T00:00:00.000' AS DateTime), CAST(N'2023-04-15T00:00:00.000' AS DateTime), N'4', NULL)
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (7, 6, CAST(N'2023-03-20T00:00:00.000' AS DateTime), CAST(N'2023-03-30T00:00:00.000' AS DateTime), N'2', NULL)
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (9, 8, CAST(N'2021-12-14T00:00:00.000' AS DateTime), CAST(N'2022-05-14T00:00:00.000' AS DateTime), N'1', N'3')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (1, 7, CAST(N'2023-01-01T00:00:00.000' AS DateTime), CAST(N'2023-04-01T00:00:00.000' AS DateTime), N'2', NULL)
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (7, 3, CAST(N'2022-05-01T00:00:00.000' AS DateTime), CAST(N'2022-05-15T00:00:00.000' AS DateTime), N'3', N'3')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (7, 3, CAST(N'2022-06-01T00:00:00.000' AS DateTime), CAST(N'2022-07-01T00:00:00.000' AS DateTime), N'2', N'2')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (9, 9, CAST(N'2019-08-07T00:00:00.000' AS DateTime), CAST(N'2019-08-08T00:00:00.000' AS DateTime), N'1', N'4')
INSERT [dbo].[clients_transports] ([client_id], [transport_id], [date_begin], [date_end], [begin_point], [end_point]) VALUES (8, 8, CAST(N'2020-09-19T00:00:00.000' AS DateTime), CAST(N'2020-10-19T00:00:00.000' AS DateTime), N'4', N'2')
INSERT [dbo].[roles] ([role_id], [role_name]) VALUES (1, N'Администратор')
INSERT [dbo].[roles] ([role_id], [role_name]) VALUES (2, N'Менеджер')
INSERT [dbo].[roles] ([role_id], [role_name]) VALUES (3, N'Клиент')
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_color], [transport_model], [transport_number], [transport_manufacture_date], [transport_enabled], [current_point_location_number], [current_point_location_address], [price]) VALUES (1, 4, N'Синий', N'MERIDA KALAHARI-500', N'XR430Z', CAST(N'2010-01-01' AS Date), 1, 1, N'ул. Мира 14', 500.0000)
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_color], [transport_model], [transport_number], [transport_manufacture_date], [transport_enabled], [current_point_location_number], [current_point_location_address], [price]) VALUES (2, 2, N'Синий', N'Suzuki RG200', N'АБ201В', CAST(N'2015-10-05' AS Date), 1, 2, N'ул. Победы 20', 1000.0000)
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_color], [transport_model], [transport_number], [transport_manufacture_date], [transport_enabled], [current_point_location_number], [current_point_location_address], [price]) VALUES (3, 4, N'Красный', N'STELS 730', N'ГГ311В', CAST(N'2020-12-17' AS Date), 1, 2, N'ул. Победы 20', 400.0000)
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_color], [transport_model], [transport_number], [transport_manufacture_date], [transport_enabled], [current_point_location_number], [current_point_location_address], [price]) VALUES (4, 1, N'Желтый', N'LADA VESTA', N'К341ТО', CAST(N'2014-12-06' AS Date), 0, NULL, NULL, 2000.0000)
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_color], [transport_model], [transport_number], [transport_manufacture_date], [transport_enabled], [current_point_location_number], [current_point_location_address], [price]) VALUES (5, 1, N'Белый', N'LADA VESTA', N'У312ТН', CAST(N'2016-06-21' AS Date), 1, 3, N'п. Ленина 16', 2000.0000)
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_color], [transport_model], [transport_number], [transport_manufacture_date], [transport_enabled], [current_point_location_number], [current_point_location_address], [price]) VALUES (6, 1, N'Белый', N'Kia Rio', N'К312ОО', CAST(N'2022-07-01' AS Date), 0, NULL, NULL, 3000.0000)
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_color], [transport_model], [transport_number], [transport_manufacture_date], [transport_enabled], [current_point_location_number], [current_point_location_address], [price]) VALUES (7, 4, N'Чёрный', N'MERIDA KALAHARI-500', N'ZC182V', CAST(N'2005-01-01' AS Date), 0, NULL, NULL, 500.0000)
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_color], [transport_model], [transport_number], [transport_manufacture_date], [transport_enabled], [current_point_location_number], [current_point_location_address], [price]) VALUES (8, 3, N'Красный', N'Alpha RX-11', N'Г352ВС', CAST(N'2021-05-05' AS Date), 1, 2, N'ул. Победы 20', 900.0000)
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_color], [transport_model], [transport_number], [transport_manufacture_date], [transport_enabled], [current_point_location_number], [current_point_location_address], [price]) VALUES (9, 3, N'Красный', N'Alpha RX-15', N'А513ВВ', CAST(N'2019-04-16' AS Date), 1, 4, N'ул. Труда 8', 900.0000)
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_color], [transport_model], [transport_number], [transport_manufacture_date], [transport_enabled], [current_point_location_number], [current_point_location_address], [price]) VALUES (10, 2, N'Коричневый', N'Yamaha G800', N'У666СР', CAST(N'2011-05-02' AS Date), 0, NULL, NULL, 1000.0000)
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_color], [transport_model], [transport_number], [transport_manufacture_date], [transport_enabled], [current_point_location_number], [current_point_location_address], [price]) VALUES (11, 1, N'Фиолетовый', N'Renault Sandero-II', N'C999ЕН', CAST(N'2012-11-10' AS Date), 1, 4, N'ул. Труда 8', 2500.0000)
INSERT [dbo].[transport] ([transport_id], [transport_type_id], [transport_color], [transport_model], [transport_number], [transport_manufacture_date], [transport_enabled], [current_point_location_number], [current_point_location_address], [price]) VALUES (12, 4, N'Белый', N'GT-50', N'XW121V', CAST(N'2017-09-11' AS Date), 1, 1, N'ул. Мира 14', 550.0000)
INSERT [dbo].[transport_type] ([transport_type_id], [transport_name]) VALUES (1, N'Автомобиль')
INSERT [dbo].[transport_type] ([transport_type_id], [transport_name]) VALUES (2, N'Мотоцикл')
INSERT [dbo].[transport_type] ([transport_type_id], [transport_name]) VALUES (3, N'Мопед')
INSERT [dbo].[transport_type] ([transport_type_id], [transport_name]) VALUES (4, N'Велосипед')
INSERT [dbo].[users] ([login], [password], [role_id], [client_id]) VALUES (N'7efwqtub80i5@outlook.com', N'54zxr3', 3, 1)
INSERT [dbo].[users] ([login], [password], [role_id], [client_id]) VALUES (N'v718fhbjuq0p@mail.com', N'4d23as', 2, 2)
INSERT [dbo].[users] ([login], [password], [role_id], [client_id]) VALUES (N'7vnrat4hmcz6@yahoo.com', N'zzz323', 1, 3)
INSERT [dbo].[users] ([login], [password], [role_id], [client_id]) VALUES (N'v4mlcsi1bgnk@tutanota.com', N'6664ee', 1, 4)
INSERT [dbo].[users] ([login], [password], [role_id], [client_id]) VALUES (N'2yx3tbqv4ndi@outlook.com', N'85fd4', 2, 5)
INSERT [dbo].[users] ([login], [password], [role_id], [client_id]) VALUES (N'5bf1xdiq6zup@tutanota.com', N'99663w', 2, 6)
INSERT [dbo].[users] ([login], [password], [role_id], [client_id]) VALUES (N'p7rviz42j6bh@outlook.com', N'hryus33', 3, 7)
INSERT [dbo].[users] ([login], [password], [role_id], [client_id]) VALUES (N'g5nrmh1axwfl@outlook.com', N'watw2ain', 3, 8)
INSERT [dbo].[users] ([login], [password], [role_id], [client_id]) VALUES (N'5knb4drlf2hj@tutanota.com', N'ZsdSDr', 3, 9)
INSERT [dbo].[users] ([login], [password], [role_id], [client_id]) VALUES (N'pk90ratym8bo@yahoo.com', N'ZZZds2', 3, 10)
ALTER TABLE [dbo].[clients_transports]  WITH CHECK ADD  CONSTRAINT [FK_clients_transports_clients] FOREIGN KEY([client_id])
REFERENCES [dbo].[clients] ([client_id])
GO
ALTER TABLE [dbo].[clients_transports] CHECK CONSTRAINT [FK_clients_transports_clients]
GO
ALTER TABLE [dbo].[clients_transports]  WITH CHECK ADD  CONSTRAINT [FK_clients_transports_transport] FOREIGN KEY([transport_id])
REFERENCES [dbo].[transport] ([transport_id])
GO
ALTER TABLE [dbo].[clients_transports] CHECK CONSTRAINT [FK_clients_transports_transport]
GO
ALTER TABLE [dbo].[transport]  WITH CHECK ADD  CONSTRAINT [FK_transport_transport_type] FOREIGN KEY([transport_type_id])
REFERENCES [dbo].[transport_type] ([transport_type_id])
GO
ALTER TABLE [dbo].[transport] CHECK CONSTRAINT [FK_transport_transport_type]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_clients] FOREIGN KEY([client_id])
REFERENCES [dbo].[clients] ([client_id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_clients]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[roles] ([role_id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_roles]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "transport"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 304
               Right = 293
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "transport_type"
            Begin Extent = 
               Top = 6
               Left = 331
               Bottom = 102
               Right = 511
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Transport_view'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Transport_view'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "transport"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 258
               Right = 293
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "transport_type"
            Begin Extent = 
               Top = 6
               Left = 331
               Bottom = 102
               Right = 511
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Transport_view_cuted'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Transport_view_cuted'
GO
USE [master]
GO
ALTER DATABASE [_Subota_bd] SET  READ_WRITE 
GO
