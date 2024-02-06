CREATE PROCEDURE [dbo].[sp_AddStudentModule]
	-- Add the parameters for the stored procedure here
	@StudentModuleID int,
	@LecturerModuleID nvarchar(50),
	@UserID int,
	@Date nvarchar(50),
	@StudentModStatus nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblStudentModule(StudentModuleID,LecturerModuleID,UserID,Date,StudModStatus)
	VALUES (@StudentModuleID,@LecturerModuleID,@UserID,@Date,@StudentModStatus)
END
GO