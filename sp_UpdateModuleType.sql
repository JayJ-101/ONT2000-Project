CREATE PROCEDURE [dbo].[sp_UpdateModuleType]
	-- Add the parameters for the stored procedure here
	@ModuleTypeID int,
	@ModuleTypeDescription nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblModuleType SET ModuleTypeDescription=@ModuleTypeDescription
	WHERE ModuleTypeID = @ModuleTypeID 
END
GO