CREATE PROCEDURE [dbo].[sp_GetAllLecturerModules]
	-- Add the parameters for the stored procedure here
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT LecturerModuleID, m.ModuleID, m.ModuleName
	FROM tblLecturerModule lm, tblModule m
	WHERE lm.ModuleID = m.ModuleID 
	AND lm.UserID = @UserID
	AND lm.ModLecturerStatus='Active'
END
GO