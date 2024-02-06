CREATE PROCEDURE [dbo].[sp_UpdateStudentModule]
	-- Add the parameters for the stored procedure here
	@StudentModuleID int,
	@LecturerModuleID int = null
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblStudentModule SET LecturerModuleID=@LecturerModuleID
	WHERE StudentModuleID=@StudentModuleID
END
GO