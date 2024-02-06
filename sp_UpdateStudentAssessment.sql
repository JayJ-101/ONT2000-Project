CREATE PROCEDURE [dbo].[sp_UpdateStudentAssessment]
	-- Add the parameters for the stored procedure here
	@AssessmentID int,
	@AssessmentDueDate nvarchar(50),
	@AssessmentStatus nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblStudentAssessment SET @AssessmentDueDate= @AssessmentDueDate,
	AssessmentStatus = @AssessmentStatus
	WHERE AssessmentID=@AssessmentID
END
GO