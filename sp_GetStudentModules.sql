CREATE PROCEDURE [dbo].[sp_GetStudentModules]
	-- Add the parameters for the stored procedure here
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Module.ModuleName, StudentModule.LecturerModuleID
	FROM tblModule Module, tblStudentModule StudentModule, tblLecturerModule LecturerModule
	WHERE StudentModule.LecturerModuleID = LecturerModule.LecturerModuleID
	AND LecturerModule.ModuleID = Module.ModuleID
	AND StudentModule.UserID = @UserID

END
GO