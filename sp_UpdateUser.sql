CREATE PROCEDURE [dbo].[sp_UpdateUser]
	-- Add the parameters for the stored procedure here
	@UserID int,
	@Name nvarchar (50)=null,
	@Surname nvarchar(50)=null,
	@Title nchar(10)=null,
	@Position nvarchar(50)=null,
	@Username nvarchar(50)=null,
	@Password nvarchar(50)=null,
	@UserStatus nvarchar(50)=null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblUser SET 
	Name = @Name,
	Surname = @Surname,
	Title = @Title,
	Position = @Position,
    Username = @Username,
	Password = @Password
	WHERE UserID = @UserID;
END
GO