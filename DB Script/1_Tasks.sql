USE [ToDoList]
GO

/****** Object:  Table [dbo].[Task]    Script Date: 02-05-2022 08:06:30 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Task]') AND type in (N'U'))
DROP TABLE [dbo].[Task]
GO

/****** Object:  Table [dbo].[Task]    Script Date: 02-05-2022 08:06:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Task](
	[Name] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
	[DueDate] [datetime] NULL,
	[Priority] [varchar](50) NULL,
	[IsCompleted] [bit] NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[modifiedDate] [datetime] NULL
) ON [PRIMARY]
GO


