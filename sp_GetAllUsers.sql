CREATE PROCEDURE [dbo].[sp_GetAllUsers]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tblUser 
	WHERE UserStatus='Active'
	ORDER BY Surname ASC
END
GO