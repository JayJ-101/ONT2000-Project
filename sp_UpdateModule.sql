CREATE PROCEDURE [dbo].[sp_UpdateModule]
	-- Add the parameters for the stored procedure here
	@ModuleID int,
	@ModuleName nvarchar(50) = null,
	@ModuleDuration nvarchar(50) = null,
	@ModuleTypeID int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblModule SET 
	ModuleName =  @ModuleName, 
	ModuleDuration = @ModuleDuration, 
	ModuleTypeID = @ModuleTypeID 
	WHERE ModuleID = @ModuleID
END
GO