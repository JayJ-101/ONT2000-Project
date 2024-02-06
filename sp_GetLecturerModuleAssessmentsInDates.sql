CREATE PROCEDURE [dbo].[sp_GetLecturerModuleAssessmentsInDates]
	-- Add the parameters for the stored procedure here
	@UserID int,
	@LecturerModuleID nvarchar(50),
	@StartDate nvarchar(50),
	@EndDate nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Assessment.ModuleID, AssessmentID, ModuleName, AssessmentTypeDescription, DueDate, AssessmentTypeDescription, AssessmentStatus
	FROM tblLecturerModule LecturerModule, tblAssessment Assessment, tblAssessmentType AssessmentType, tblModule Module
	WHERE LecturerModule.LecturerModuleID = Assessment.ModuleID
	AND LecturerModule.ModuleID = Module.ModuleID
	AND Assessment.AssessmentTypeID = AssessmentType.AssessmentTypeID
	AND LecturerModule.UserID =  @UserID
	AND LecturerModule.LecturerModuleID = @LecturerModuleID
	AND Assessment.DueDate BETWEEN CONVERT(datetime,@StartDate) AND CONVERT(datetime, @EndDate)
	ORDER BY ModuleName ASC
END
GO