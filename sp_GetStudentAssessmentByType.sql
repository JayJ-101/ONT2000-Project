CREATE PROCEDURE [dbo].[sp_GetStudentAssessmentByType]
	-- Add the parameters for the stored procedure here
	@AssessmentTypeID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT AssessmentID, AssessmentTypeDescription, AssessmentDate, AssessmentStatus
	FROM tblStudentAssessment StudentAssessment,tblAssessmentType AssessmentType
	WHERE StudentAssessment.AssessmentID=AssessmentType.AssessmentTypeID
	AND AssessmentTypeID=@AssessmentTypeID
END
GO