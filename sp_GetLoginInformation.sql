USE [AssessmentDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_GetLoginInformation]    Script Date: 2020/12/08 6:41:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_GetLoginInformation]
	-- Add the parameters for the stored procedure here

	@Username nvarchar(50),
	@Password nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT UserID,Name, Surname, Position, Username, Password
	FROM tblUser
	WHERE Username=@Username AND Password=@Password
END
