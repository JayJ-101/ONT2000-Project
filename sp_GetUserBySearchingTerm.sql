CREATE PROCEDURE [dbo].[sp_GetUserBySearchingTerm]
	-- Add the parameters for the stored procedure here
	@SearchTerm nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM tblUser WHERE UserStatus = 'Active' AND (UserID LIKE '%' + @SearchTerm + '%' OR Name LIKE '%' + @SearchTerm + '%' OR Surname LIKE '%' + @SearchTerm + '%' OR Position LIKE '%' + @SearchTerm + '%')
	ORDER BY Surname ASC
END
GO