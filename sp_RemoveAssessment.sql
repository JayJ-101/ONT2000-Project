CREATE PROCEDURE [dbo].[sp_RemoveAssessent]
	-- Add the parameters for the stored procedure here
	@AssessmentID int 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE tblAssessment SET AssessmentStatus='Inactive'
	WHERE AssessmentID=@AssessmentID
END
GO