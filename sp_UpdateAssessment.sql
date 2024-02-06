CREATE PROCEDURE [dbo].[sp_UpdateAssessment] 
	-- Add the parameters for the stored procedure here
	@AssessmentID int,
	@DueDate nvarchar(50),
	@AssessmentTypeID int

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblAssessment SET AssessmentTypeID=@AssessmentTypeID, DueDate=@DueDate
	WHERE AssessmentID=@AssessmentID
END
GO