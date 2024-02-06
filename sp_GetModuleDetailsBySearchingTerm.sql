CREATE PROCEDURE [dbo].[sp_GetModuleDetailsBySearchingTerm]
	-- Add the parameters for the stored procedure here
	@SearchTerm nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT u.Surname, u.[Name], Module.ModuleName, ModuleType.ModuleTypeDescription, COUNT(StudentModule.StudentModuleID) AS [Number of Students]
	FROM tblModule Module, tblModuleType ModuleType, tblLecturerModule LecturerModule, tblStudentModule StudentModule, tblUser u
	WHERE u.UserID = LecturerModule.UserID
	AND Module.ModuleID = LecturerModule.ModuleID
	AND LecturerModule.LecturerModuleID = StudentModule.LecturerModuleID 
	AND Module.ModuleTypeID = ModuleType.ModuleTypeID
	AND Module.ModuleName LIKE '%' + @SearchTerm + '%'
	GROUP BY u.Surname, u.Name, Module.ModuleName, ModuleType.ModuleTypeDescription
END
GO