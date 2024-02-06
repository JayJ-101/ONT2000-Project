CREATE PROCEDURE [dbo].[sp_AddStudentAssessment]
	-- Add the parameters for the stored procedure here
	@StudentAssessmentID int,
	@UserID int,
	@AssessmentID int,
	@AssessmentDate nvarchar(50),
	@AssessmentStatus nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO tblStudentAssessment(StudentAssessmentID, UserID,AssessmentID,AssessmentDate,AssessmentStatus)
	VALUES(@StudentAssessmentID, @UserID,@AssessmentID,@AssessmentDate,@AssessmentStatus)
END
GO