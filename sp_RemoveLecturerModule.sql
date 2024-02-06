CREATE PROCEDURE [dbo].[sp_RemoveLecturerModule]
	-- Add the parameters for the stored procedure here
	@LecturerModuleID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblLecturerModule SET ModLecturerStatus='Inactive'
	WHERE LecturerModuleID=@LecturerModuleID
END
GO