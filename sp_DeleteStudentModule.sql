CREATE PROCEDURE [dbo].[sp_DeleteStudentModule]
	-- Add the parameters for the stored procedure here
	@StudentModuleID int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM tblStudentModule
	WHERE StudentModuleID=@StudentModuleID
END
GO