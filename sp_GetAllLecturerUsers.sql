USE [AssessmentDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllLecturerUsers]    Script Date: 2021/01/11 12:03:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_GetAllLecturerUsers]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT UserID, [Name], Surname FROM tblUser WHERE [Position] = 'Lecturer'
END
