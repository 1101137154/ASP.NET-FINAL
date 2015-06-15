CREATE DATABASE [ASP_NET_FINAL]
GO

USE [ASP_NET_FINAL]
GO

CREATE TABLE [dbo].[Students](
	[id]   	 [int] IDENTITY(1,1),
	[stu_id] [nvarchar](50) NOT NULL,
	[stu_name] [nvarchar](50) NOT NULL,
	[stu_phone] [nvarchar](50) NOT NULL,
	[stu_birth] [date] NOT NULL,
	[stu_info] [nvarchar](1000) NULL
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO [dbo].[Students]
           ([stu_id]
           ,[stu_name]
           ,[stu_phone]
           ,[stu_birth]
           ,[stu_info])
     VALUES
           (N's1101137114'
           , N'晨曦'
           ,'0966666666'
           ,'1993/10/12'
           ,N''),
		   (N's1101137154'
           , N'黃勇強'
           ,'0912345678'
           ,'1993/10/12'
           ,N''),
		   (N's1101137213'
           , N'黃偉綸'
           ,'0987654321'
           ,'1993/11/06'
           ,N'★美妙的古典樂世界~~★Prokofieff Piano Concerto No1')
GO
