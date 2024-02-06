CREATE PROCEDURE [dbo].[sp_RemoveUser] 
	-- Add the parameters for the stored procedure here
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblUser 
	SET UserStatus='Inactive' 
	WHERE UserID=@UserID
END
GO