USE [iCycle]
GO
/****** Object:  Table [dbo].[WeeklyZoneSummary]    Script Date: 08/12/2008 13:25:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WeeklyZoneSummary](
	[DurationLightZone] [varchar](50) NULL,
	[DurationModerateZone] [varchar](50) NULL,
	[DurationHardZone] [varchar](50) NULL,
	[Id] [int] NOT NULL,
	[WeekStartDate] [datetime] NOT NULL,
 CONSTRAINT [PK_WeeklyZoneSummary] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF