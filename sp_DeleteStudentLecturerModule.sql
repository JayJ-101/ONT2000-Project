CREATE PROCEDURE [dbo].[sp_DeleteStudentLecturerModule]
	-- Add the parameters for the stored procedure here
	@LecturerModuleID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM tblLecturerModule
	WHERE LecturerModuleID=@LecturerModuleID
END
GO