CREATE TABLE [dbo].[Country]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[CommonName] NVARCHAR(500) NOT NULL,
    [officialName] NVARCHAR(500) NOT NULL,
    [IsIndependent] BIT NOT NULL,
    [Timezone] NVARCHAR(20) NOT NULL
)

GO