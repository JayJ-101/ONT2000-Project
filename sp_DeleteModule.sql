CREATE PROCEDURE [dbo].[sp_DeleteModule]
	-- Add the parameters for the stored procedure here
	@ModuleID int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM tblModule
	WHERE ModuleID=@ModuleID
END
GO