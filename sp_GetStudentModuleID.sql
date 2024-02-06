CREATE PROCEDURE [dbo].[sp_GetStudentModuleID]
	-- Add the parameters for the stored procedure here
	@UserID int,
	@LecturerModuleID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT StudentModuleID 
	FROM tblStudentModule
	WHERE UserID = @UserID AND LecturerModuleID = @LecturerModuleID
END
GO