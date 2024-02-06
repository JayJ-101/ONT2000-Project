CREATE PROCEDURE [dbo].[sp_GetModuleTypes]
	-- Add the parameters for the stored procedure here
	@ModuleType int,
	@ModuleTypeDescription nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tblModuleType 
	WHERE ModuleTypeDescription=@ModuleTypeDescription
END
GO