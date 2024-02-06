CREATE PROCEDURE [dbo].[sp_GetUserByPosition]
	-- Add the parameters for the stored procedure here
	@Position nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tblUser WHERE UserStatus = 'Active' AND Position = @Position
	ORDER BY Surname ASC
END
GO