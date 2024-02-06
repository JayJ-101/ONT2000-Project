-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_AddStudentUser]
	-- Add the parameters for the stored procedure here
	@Name nvarchar(50),
	@Surname nvarchar(50),
	@Title nvarchar(50),
	@Position nvarchar(50),
	@Username nvarchar(50),
	@Password nvarchar(50),
	@UserStatus nvarchar(50)
AS
BEGIN
	DECLARE @ID int;
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblUser(Name, Surname, Title, Position, Username, Password, UserStatus)
	VALUES(@Name, @Surname, @Title, @Position, @Username, @Password, @UserStatus)

	SET @ID = SCOPE_IDENTITY();

                SET IDENTITY_INSERT tblLecturer ON


                INSERT INTO tblLecturer (UserID) values(@ID)

END
 
