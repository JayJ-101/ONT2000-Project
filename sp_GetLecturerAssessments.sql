CREATE PROCEDURE [dbo].[sp_GetLecturerAssessments]
	-- Add the parameters for the stored procedure here
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Assessment.AssessmentTypeID, AssessmentID, ModuleName, AssessmentTypeDescription, DueDate, AssessmentTypeDescription, AssessmentStatus
	FROM tblLecturerModule LecturerModule, tblAssessment Assessment, tblAssessmentType AssessmentType, tblModule Module
	WHERE LecturerModule.LecturerModuleID = Assessment.AssessmentID
	AND Assessment.AssessmentTypeID = AssessmentType.AssessmentTypeID
	AND LecturerModule.ModuleID = Module.ModuleID
	AND LecturerModule.UserID =  @UserID
	ORDER BY ModuleName ASC, DueDate ASC
END
GO