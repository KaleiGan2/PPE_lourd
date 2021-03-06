USE [master]
GO
/****** Object:  Database [PPE]    Script Date: 21/09/2021 21:49:09 ******/
CREATE DATABASE [PPE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PPE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PPE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PPE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PPE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PPE] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PPE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PPE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PPE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PPE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PPE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PPE] SET ARITHABORT OFF 
GO
ALTER DATABASE [PPE] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PPE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PPE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PPE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PPE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PPE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PPE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PPE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PPE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PPE] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PPE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PPE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PPE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PPE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PPE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PPE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PPE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PPE] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PPE] SET  MULTI_USER 
GO
ALTER DATABASE [PPE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PPE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PPE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PPE] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PPE] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PPE] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [PPE] SET QUERY_STORE = OFF
GO
USE [PPE]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 21/09/2021 21:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID_client] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NULL,
	[Adresse] [varchar](250) NULL,
	[Telephone] [varchar](50) NULL,
	[Ville] [varchar](50) NULL,
	[Code_Postal] [varchar](50) NULL,
 CONSTRAINT [Client_PK] PRIMARY KEY CLUSTERED 
(
	[ID_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Intervenant]    Script Date: 21/09/2021 21:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Intervenant](
	[ID_intervenant] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NULL,
	[Prenom] [varchar](50) NULL,
	[Adresse] [varchar](50) NULL,
	[Ville] [varchar](50) NULL,
	[Date_anciennete] [datetime] NULL,
	[LOGIN] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Verification] [int] NULL,
	[Administrateur] [int] NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [Intervenant_PK] PRIMARY KEY CLUSTERED 
(
	[ID_intervenant] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Intervention]    Script Date: 21/09/2021 21:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Intervention](
	[ID_itv] [int] IDENTITY(1,1) NOT NULL,
	[Statut] [varchar](50) NULL,
	[Date_itv] [datetime] NOT NULL,
	[Commentaires] [text] NULL,
	[ID_intervenant] [int] NULL,
	[ID_mat] [int] NOT NULL,
	[ID_client] [int] NULL,
	[Validation] [int] NULL,
 CONSTRAINT [Intervention_PK] PRIMARY KEY CLUSTERED 
(
	[ID_itv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materiel]    Script Date: 21/09/2021 21:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materiel](
	[ID_mat] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NOT NULL,
 CONSTRAINT [Materiel_PK] PRIMARY KEY CLUSTERED 
(
	[ID_mat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Site]    Script Date: 21/09/2021 21:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Site](
	[ID_site] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NOT NULL,
	[Ville] [varchar](50) NOT NULL,
	[Code_postal] [int] NOT NULL,
 CONSTRAINT [Site_PK] PRIMARY KEY CLUSTERED 
(
	[ID_site] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statut]    Script Date: 21/09/2021 21:49:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statut](
	[ID_stats] [int] IDENTITY(0,1) NOT NULL,
	[Nom_statut] [nchar](25) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([ID_client], [Nom], [Adresse], [Telephone], [Ville], [Code_Postal]) VALUES (2, N'Microsoft', N'14 boulevard de l''oise', N'01 54 78 65 95', N'Evry', N'91000')
INSERT [dbo].[Client] ([ID_client], [Nom], [Adresse], [Telephone], [Ville], [Code_Postal]) VALUES (3, N'Apple', N'4 avenue des champs elysées', N'01 34 51 74 65', N'Paris', N'75016')
INSERT [dbo].[Client] ([ID_client], [Nom], [Adresse], [Telephone], [Ville], [Code_Postal]) VALUES (10, N'Logitech', N'28 rue de la Grande Armée', N'0675848578', N'Paris', N'75000')
INSERT [dbo].[Client] ([ID_client], [Nom], [Adresse], [Telephone], [Ville], [Code_Postal]) VALUES (11, N'Nintendo', N'Avenue Mario Bros', N'0675275203', N'Vernon', N'27200')
INSERT [dbo].[Client] ([ID_client], [Nom], [Adresse], [Telephone], [Ville], [Code_Postal]) VALUES (14, N'd', N'5 avenue des champs élysées', N'01 30 25 95 48', N'Ville', N'75001')
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Intervenant] ON 

INSERT [dbo].[Intervenant] ([ID_intervenant], [Nom], [Prenom], [Adresse], [Ville], [Date_anciennete], [LOGIN], [Password], [Verification], [Administrateur], [Email]) VALUES (1, N'Sagna', N'Ibrahima', N'25 rue du poulet', N'Cergy', CAST(N'2021-02-20T00:00:00.000' AS DateTime), N'moi', N'toi', 1, 2, NULL)
INSERT [dbo].[Intervenant] ([ID_intervenant], [Nom], [Prenom], [Adresse], [Ville], [Date_anciennete], [LOGIN], [Password], [Verification], [Administrateur], [Email]) VALUES (2, N'Thamboo', N'Prasath', N'14 avenue bol', N'Paris', CAST(N'2021-02-20T00:00:00.000' AS DateTime), N'toi', N'moi', 1, 1, NULL)
INSERT [dbo].[Intervenant] ([ID_intervenant], [Nom], [Prenom], [Adresse], [Ville], [Date_anciennete], [LOGIN], [Password], [Verification], [Administrateur], [Email]) VALUES (10, N'Test', N'Test', N'Test', N'Test', CAST(N'2021-06-16T00:00:00.000' AS DateTime), N'Test', N'Test', 1, 0, NULL)
INSERT [dbo].[Intervenant] ([ID_intervenant], [Nom], [Prenom], [Adresse], [Ville], [Date_anciennete], [LOGIN], [Password], [Verification], [Administrateur], [Email]) VALUES (11, N'Test', N'Test', N'Test', N'Test', CAST(N'2021-06-16T00:00:00.000' AS DateTime), N'Test2', N'Test', 0, 0, N'Test@test.com')
INSERT [dbo].[Intervenant] ([ID_intervenant], [Nom], [Prenom], [Adresse], [Ville], [Date_anciennete], [LOGIN], [Password], [Verification], [Administrateur], [Email]) VALUES (12, N'Test3', N'Test3', N'Test', N'Test3', CAST(N'2021-06-16T00:00:00.000' AS DateTime), N'Test3', N'test', 1, 0, N'test3@test.com')
SET IDENTITY_INSERT [dbo].[Intervenant] OFF
GO
SET IDENTITY_INSERT [dbo].[Intervention] ON 

INSERT [dbo].[Intervention] ([ID_itv], [Statut], [Date_itv], [Commentaires], [ID_intervenant], [ID_mat], [ID_client], [Validation]) VALUES (8, N'Urgent', CAST(N'2021-03-21T00:00:00.000' AS DateTime), NULL, 1, 3, 10, 1)
INSERT [dbo].[Intervention] ([ID_itv], [Statut], [Date_itv], [Commentaires], [ID_intervenant], [ID_mat], [ID_client], [Validation]) VALUES (9, N'Facile', CAST(N'2021-03-26T00:00:00.000' AS DateTime), NULL, 1, 4, NULL, 1)
INSERT [dbo].[Intervention] ([ID_itv], [Statut], [Date_itv], [Commentaires], [ID_intervenant], [ID_mat], [ID_client], [Validation]) VALUES (10, N'Urgente', CAST(N'2021-03-08T14:39:12.000' AS DateTime), NULL, NULL, 3, NULL, 0)
INSERT [dbo].[Intervention] ([ID_itv], [Statut], [Date_itv], [Commentaires], [ID_intervenant], [ID_mat], [ID_client], [Validation]) VALUES (11, N'Urgente', CAST(N'2021-03-11T14:39:23.000' AS DateTime), NULL, NULL, 3, NULL, 0)
INSERT [dbo].[Intervention] ([ID_itv], [Statut], [Date_itv], [Commentaires], [ID_intervenant], [ID_mat], [ID_client], [Validation]) VALUES (12, N'Urgente', CAST(N'2021-03-27T14:39:40.000' AS DateTime), NULL, NULL, 4, NULL, 0)
INSERT [dbo].[Intervention] ([ID_itv], [Statut], [Date_itv], [Commentaires], [ID_intervenant], [ID_mat], [ID_client], [Validation]) VALUES (13, N'Normal', CAST(N'2021-03-08T14:40:43.000' AS DateTime), NULL, NULL, 3, NULL, 0)
INSERT [dbo].[Intervention] ([ID_itv], [Statut], [Date_itv], [Commentaires], [ID_intervenant], [ID_mat], [ID_client], [Validation]) VALUES (51, N'Normal', CAST(N'2021-05-29T16:04:56.000' AS DateTime), NULL, NULL, 5, 10, 0)
INSERT [dbo].[Intervention] ([ID_itv], [Statut], [Date_itv], [Commentaires], [ID_intervenant], [ID_mat], [ID_client], [Validation]) VALUES (53, N'Urgente', CAST(N'2021-06-13T17:18:02.000' AS DateTime), NULL, NULL, 7, 11, 0)
INSERT [dbo].[Intervention] ([ID_itv], [Statut], [Date_itv], [Commentaires], [ID_intervenant], [ID_mat], [ID_client], [Validation]) VALUES (54, N'Normal', CAST(N'2021-06-13T17:29:08.000' AS DateTime), NULL, NULL, 5, 11, 0)
INSERT [dbo].[Intervention] ([ID_itv], [Statut], [Date_itv], [Commentaires], [ID_intervenant], [ID_mat], [ID_client], [Validation]) VALUES (55, N'Urgente', CAST(N'2021-06-11T17:33:02.000' AS DateTime), NULL, NULL, 7, 11, 0)
INSERT [dbo].[Intervention] ([ID_itv], [Statut], [Date_itv], [Commentaires], [ID_intervenant], [ID_mat], [ID_client], [Validation]) VALUES (56, N'Normal', CAST(N'2021-06-11T18:15:59.000' AS DateTime), NULL, 2, 3, 11, 0)
INSERT [dbo].[Intervention] ([ID_itv], [Statut], [Date_itv], [Commentaires], [ID_intervenant], [ID_mat], [ID_client], [Validation]) VALUES (1053, N'Normal', CAST(N'2021-06-15T17:23:17.000' AS DateTime), NULL, 2, 6, 11, 1)
INSERT [dbo].[Intervention] ([ID_itv], [Statut], [Date_itv], [Commentaires], [ID_intervenant], [ID_mat], [ID_client], [Validation]) VALUES (1054, N'Normal', CAST(N'2021-06-17T18:23:30.000' AS DateTime), NULL, 1, 6, 10, 1)
SET IDENTITY_INSERT [dbo].[Intervention] OFF
GO
SET IDENTITY_INSERT [dbo].[Materiel] ON 

INSERT [dbo].[Materiel] ([ID_mat], [Nom]) VALUES (3, N'Ordinateur')
INSERT [dbo].[Materiel] ([ID_mat], [Nom]) VALUES (4, N'Souris')
INSERT [dbo].[Materiel] ([ID_mat], [Nom]) VALUES (5, N'PC')
INSERT [dbo].[Materiel] ([ID_mat], [Nom]) VALUES (6, N'Moi')
INSERT [dbo].[Materiel] ([ID_mat], [Nom]) VALUES (7, N'Clavier')
INSERT [dbo].[Materiel] ([ID_mat], [Nom]) VALUES (1005, N'Téléphone')
INSERT [dbo].[Materiel] ([ID_mat], [Nom]) VALUES (1006, N'Carte Graphique')
INSERT [dbo].[Materiel] ([ID_mat], [Nom]) VALUES (1007, N'Touche')
INSERT [dbo].[Materiel] ([ID_mat], [Nom]) VALUES (1008, N'dddd')
SET IDENTITY_INSERT [dbo].[Materiel] OFF
GO
SET IDENTITY_INSERT [dbo].[Site] ON 

INSERT [dbo].[Site] ([ID_site], [Nom], [Ville], [Code_postal]) VALUES (1, N'Sony', N'Paris', 75000)
INSERT [dbo].[Site] ([ID_site], [Nom], [Ville], [Code_postal]) VALUES (2, N'Poissy', N'Poissy', 78300)
SET IDENTITY_INSERT [dbo].[Site] OFF
GO
SET IDENTITY_INSERT [dbo].[Statut] ON 

INSERT [dbo].[Statut] ([ID_stats], [Nom_statut]) VALUES (0, N'Intervenant              ')
INSERT [dbo].[Statut] ([ID_stats], [Nom_statut]) VALUES (1, N'Administrateur           ')
INSERT [dbo].[Statut] ([ID_stats], [Nom_statut]) VALUES (2, N'Créateur                 ')
SET IDENTITY_INSERT [dbo].[Statut] OFF
GO
ALTER TABLE [dbo].[Intervenant] ADD  CONSTRAINT [DF_Intervenant_Verification]  DEFAULT ((0)) FOR [Verification]
GO
ALTER TABLE [dbo].[Intervenant] ADD  CONSTRAINT [DF_Intervenant_Administrateur]  DEFAULT ((0)) FOR [Administrateur]
GO
ALTER TABLE [dbo].[Intervention] ADD  CONSTRAINT [DF_Intervention_Validation]  DEFAULT ((0)) FOR [Validation]
GO
ALTER TABLE [dbo].[Intervention]  WITH CHECK ADD  CONSTRAINT [Intervention_Intervenant_FK] FOREIGN KEY([ID_intervenant])
REFERENCES [dbo].[Intervenant] ([ID_intervenant])
GO
ALTER TABLE [dbo].[Intervention] CHECK CONSTRAINT [Intervention_Intervenant_FK]
GO
ALTER TABLE [dbo].[Intervention]  WITH CHECK ADD  CONSTRAINT [Intervention_Materiel0_FK] FOREIGN KEY([ID_mat])
REFERENCES [dbo].[Materiel] ([ID_mat])
GO
ALTER TABLE [dbo].[Intervention] CHECK CONSTRAINT [Intervention_Materiel0_FK]
GO
USE [master]
GO
ALTER DATABASE [PPE] SET  READ_WRITE 
GO
