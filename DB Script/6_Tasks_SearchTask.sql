USE [ToDoList]
GO

/****** Object:  StoredProcedure [dbo].[Tasks_SearchTask]    Script Date: 02-05-2022 08:11:15 ******/
DROP PROCEDURE [dbo].[Tasks_SearchTask]
GO

/****** Object:  StoredProcedure [dbo].[Tasks_SearchTask]    Script Date: 02-05-2022 08:11:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Tasks_SearchTask] 
	-- Add the parameters for the stored procedure here
	@Name varchar(30)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Task where Name=@Name
END
GO


