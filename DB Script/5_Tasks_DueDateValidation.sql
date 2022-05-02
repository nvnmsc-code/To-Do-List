USE [ToDoList]
GO

/****** Object:  StoredProcedure [dbo].[Tasks_DueDateValidation]    Script Date: 02-05-2022 08:10:33 ******/
DROP PROCEDURE [dbo].[Tasks_DueDateValidation]
GO

/****** Object:  StoredProcedure [dbo].[Tasks_DueDateValidation]    Script Date: 02-05-2022 08:10:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Tasks_DueDateValidation]
	-- Add the parameters for the stored procedure here
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Task
    set IsCompleted = (case when ( DueDate < (SELECT DATEADD(dd, 0, DATEDIFF(dd, 0, GETDATE()))) and IsCompleted = 0 ) then 1 else 0 end),modifiedDate=GETDATE()
	where IsCompleted =0
END
GO


