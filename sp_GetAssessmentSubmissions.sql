CREATE PROCEDURE [dbo].[sp_GetAssessmentSubmissions]
	-- Add the parameters for the stored procedure here
	@AssessmentID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT u.UserID, u.Name, u.Surname, asb.AssessmentID, Module.ModuleName, Assessment.AssessmentStatus, Assessment.DueDate, asb.DateRescheduled, AssessmentType.AssessmentTypeDescription, asb.SubmissionStatus
	FROM tblStudentModule StudentModule, tblAssessmentSubmission asb, tblLecturerModule LecturerModule, tblAssessment Assessment, tblAssessmentType AssessmentType, tblModule Module, tblUser u
	WHERE LecturerModule.LecturerModuleID =StudentModule.LecturerModuleID
	AND u.UserID = StudentModule.UserID
	AND Assessment.AssessmentID = asb.AssessmentID
	AND StudentModule.LecturerModuleID = LecturerModule.LecturerModuleID
	AND StudentModule.StudentModuleID = asb.StudentModuleID
	AND lecturerModule.ModuleID = Module.ModuleID
	AND Assessment.AssessmentTypeID = AssessmentType.AssessmentTypeID
	AND asb.AssessmentID = @AssessmentID
	ORDER BY DueDate DESC
END
GO