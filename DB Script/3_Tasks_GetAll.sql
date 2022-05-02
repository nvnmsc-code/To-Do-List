USE [ToDoList]
GO

/****** Object:  StoredProcedure [dbo].[Tasks_GetAll]    Script Date: 02-05-2022 08:08:45 ******/
DROP PROCEDURE [dbo].[Tasks_GetAll]
GO

/****** Object:  StoredProcedure [dbo].[Tasks_GetAll]    Script Date: 02-05-2022 08:08:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Tasks_GetAll]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Task
END
GO


