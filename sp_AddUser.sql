USE [AssessmentDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddUser]    Script Date: 2020/12/10 2:06:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_AddUser] 
	-- Add the parameters for the stored procedure here
	@UserID int,
	@Name 	nvarchar(50),
	@Surname 	nvarchar(50),
	@Title 		nchar	(10),
	@Position 		nvarchar(50),
	@Username 	nvarchar(50),
	@Password	nvarchar(50),
	@UserStatus nvarchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblUser (UserID, Name, Surname, Title, Position, Username, Password, UserStatus)
	VALUES (@UserID, @Name, @Surname, @Title, @Position, @Username, @Password, @UserStatus)

END
