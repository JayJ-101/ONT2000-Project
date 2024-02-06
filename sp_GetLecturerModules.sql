CREATE PROCEDURE [dbo].[sp_GetLecturerModules]
	-- Add the parameters for the stored procedure here
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT LecturerModuleID, Module.ModuleID, Module.ModuleName
	FROM tblLecturerModule LectuerModule, tblModule Module
	WHERE LectuerModule.ModuleID = Module.ModuleID 
	AND LectuerModule.UserID = @UserID
END
GO