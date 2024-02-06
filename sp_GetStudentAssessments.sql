CREATE PROCEDURE [dbo].[sp_GetStudentAssessments]
	-- Add the parameters for the stored procedure here
	@UserID int,
	@LecturerModuleID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT asn.AssessmentSubmissionID, asn.AssessmentID, m.ModuleName, a.AssessmentStatus, a.DueDate, asn.DateRescheduled, ast.AssessmentTypeDescription, asn.SubmissionStatus
	FROM tblStudentModule sm, tblAssessmentSubmission asn, tblLecturerModule lm, tblAssessment a, tblAssessmentType ast, tblModule m
	WHERE lm.LecturerModuleID = sm.LecturerModuleID
	AND a.AssessmentID = asn.AssessmentID
	AND sm.LecturerModuleID = lm.LecturerModuleID
	AND sm.StudentModuleID = asn.StudentModuleID
	AND lm.ModuleID = m.ModuleID
	AND a.AssessmentTypeID = ast.AssessmentTypeID
	AND sm.UserID = @UserID
	AND lm.LecturerModuleID = @LecturerModuleID	
	ORDER BY DueDate ASC
END
GO
