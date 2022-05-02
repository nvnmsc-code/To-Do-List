USE [ToDoList]
GO

/****** Object:  StoredProcedure [dbo].[Tasks_deleteTask]    Script Date: 02-05-2022 08:09:26 ******/
DROP PROCEDURE [dbo].[Tasks_deleteTask]
GO

/****** Object:  StoredProcedure [dbo].[Tasks_deleteTask]    Script Date: 02-05-2022 08:09:26 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Tasks_deleteTask] 
	-- Add the parameters for the stored procedure here
	@Id int
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from Task where Id=@id
END
GO


