CREATE PROCEDURE [dbo].[GetCountryInfo_1.0.0]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT ID, CommonName, officialName, IsIndependent, Timezone FROM [COUNTRY] WITH (NOLOCK)
END
GO