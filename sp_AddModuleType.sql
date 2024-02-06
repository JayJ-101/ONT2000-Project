CREATE PROCEDURE [dbo].[sp_AddModuleType]
	-- Add the parameters for the stored procedure here
	@ModuleTypeID int,
	@ModuleTypeDescription nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblModuleType(ModuleTypeID,ModuleTypeDescription)
	VALUES (@ModuleTypeID,@ModuleTypeDescription)
END
GO