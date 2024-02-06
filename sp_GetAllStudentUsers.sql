CREATE PROCEDURE [dbo].[sp_GetAllStudentUsers]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT UserID, [Name], Surname FROM tblUser WHERE [Position] = 'Student'
END
GO