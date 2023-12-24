CREATE TABLE [dbo].[Provider1036BetDetail]
(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TransferCode] [nvarchar](100) NOT NULL,
	[TransactionId] [nvarchar](600) NULL,
	[ProviderId] [int] NOT NULL,
	[WebId] [int] NOT NULL,
	[GamePeriodId] [nvarchar](100) NULL,
	[GameRoundId] [nvarchar](100) NULL,
	[GameId] [int] NULL,
	[Stake] [decimal](19, 6) NOT NULL,
	[Winlost] [decimal](19, 6) NOT NULL,
	[Status] [int] NOT NULL,
	[OrderDetail] [nvarchar](4000) NULL,
	[GameResult] [nvarchar](4000) NULL,
	[CustomerId] [int] NOT NULL,
	[Currency] [nvarchar](4) NOT NULL,
	[OrderedOn] [datetime] NOT NULL,
	[OrderedBy] [nvarchar](50) NOT NULL,
	[ModifiedOn] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](50) NOT NULL,
	[Remark] [nvarchar](4000) NULL,
	[IsResettle] [bit] Default 0,
	PRIMARY KEY CLUSTERED ([Id] ASC)
	WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 95) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_Provider1036BetDetail_TransferCode] ON [dbo].[Provider1036BetDetail] ([TransferCode],[WebId],[CustomerId])
GO
CREATE NONCLUSTERED INDEX [IX_Provider1036BetDetail_TransactionId] ON [dbo].[Provider1036BetDetail] ([TransactionId])
GO
CREATE NONCLUSTERED INDEX [IX_Provider1036BetDetail_GameRoundId] ON [dbo].[Provider1036BetDetail] ([GameRoundId])
GO
CREATE NONCLUSTERED INDEX [IX_Provider1036BetDetail_ModifiedOn] ON [dbo].[Provider1036BetDetail] ([ModifiedOn])
GO