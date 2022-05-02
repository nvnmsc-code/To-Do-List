USE [ToDoList]
GO

/****** Object:  StoredProcedure [dbo].[Tasks_UpdateTask]    Script Date: 02-05-2022 08:12:03 ******/
DROP PROCEDURE [dbo].[Tasks_UpdateTask]
GO

/****** Object:  StoredProcedure [dbo].[Tasks_UpdateTask]    Script Date: 02-05-2022 08:12:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Tasks_UpdateTask] 
	-- Add the parameters for the stored procedure here
	@Id int,@Name varchar(30),@Description varchar(50), @Priority varchar(30),@DueDate Datetime, @IsCompleted bit
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Task set Name=@Name,Description=@Description,Priority=@Priority,DueDate=@DueDate,IsCompleted=@IsCompleted,modifiedDate =GETDATE() where Id=@Id
END
GO


