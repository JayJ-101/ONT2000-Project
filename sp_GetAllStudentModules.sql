CREATE PROCEDURE [dbo].[sp_GetAllStudentModules]
	-- Add the parameters for the stored procedure here
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT m.ModuleName, sm.LecturerModuleID
	FROM tblModule m, tblStudentModule sm, tblLecturerModule lm
	WHERE sm.LecturerModuleID = lm.LecturerModuleID
	AND lm.ModuleID = m.ModuleID
	AND sm.UserID = @UserID
END
GO