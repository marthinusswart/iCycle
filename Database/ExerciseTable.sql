USE [iCycle]
GO
/****** Object:  Table [dbo].[Exercise]    Script Date: 08/12/2008 13:25:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Exercise](
	[Id] [int] NOT NULL,
	[ExerciseDate] [datetime] NULL,
	[AverageSpeed] [decimal](18, 2) NOT NULL,
	[TopSpeed] [decimal](18, 2) NULL,
	[Distance] [decimal](18, 2) NULL,
	[Duration] [varchar](50) NULL,
	[Calories] [int] NULL,
	[AverageHeartRate] [int] NULL,
	[MaximumHeartRate] [int] NULL,
	[DurationInZone] [varchar](50) NULL,
	[FatBurned] [int] NULL,
	[RouteId] [int] NULL,
	[ZoneUpper] [int] NULL,
	[ZoneLower] [int] NULL,
 CONSTRAINT [PK_Excersize] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Exercise]  WITH NOCHECK ADD  CONSTRAINT [FK_Excersize_Route] FOREIGN KEY([RouteId])
REFERENCES [dbo].[Route] ([Id])
NOT FOR REPLICATION 
GO
ALTER TABLE [dbo].[Exercise] NOCHECK CONSTRAINT [FK_Excersize_Route]