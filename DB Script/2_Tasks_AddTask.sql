USE [ToDoList]
GO

/****** Object:  StoredProcedure [dbo].[Tasks_AddTask]    Script Date: 02-05-2022 08:07:49 ******/
DROP PROCEDURE [dbo].[Tasks_AddTask]
GO

/****** Object:  StoredProcedure [dbo].[Tasks_AddTask]    Script Date: 02-05-2022 08:07:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Tasks_AddTask]
	-- Add the parameters for the stored procedure here
	@Name varchar(30),@Description varchar(50), @Priority varchar(30),@DueDate Datetime, @IsCompleted bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Task(Name,Description,Priority,DueDate,IsCompleted,modifiedDate) values (@Name,@Description,@Priority,@DueDate,@IsCompleted,GETDATE())
END
GO


