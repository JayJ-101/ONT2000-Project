CREATE PROCEDURE [dbo].[sp_UpdateLecturerModule]
	-- Add the parameters for the stored procedure here
	@LecturerModuleID int,
	@ModuleID int,
	@UserID int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblLecturerModule SET
	UserID = @UserID,
	ModuleID=@ModuleID
	
	
	WHERE LecturerModuleID = @LecturerModuleID
END
GO