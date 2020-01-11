USE [dbi428024]
GO
/****** Object:  Table [dbo].[Calendar]    Script Date: 12/22/2019 12:10:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calendar](
	[Id] [int] NOT NULL,
	[Monday] [nvarchar](25) NOT NULL,
	[Tuesday] [nvarchar](25) NOT NULL,
	[Wednesday] [nvarchar](25) NOT NULL,
	[Thursday] [nvarchar](25) NOT NULL,
	[Friday] [nvarchar](25) NOT NULL,
	[Saturday] [nvarchar](25) NOT NULL,
	[Sunday] [nvarchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Calendar]  WITH CHECK ADD FOREIGN KEY([Id])
REFERENCES [dbo].[Account] ([Id])
GO
