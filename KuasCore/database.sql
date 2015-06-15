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
           ,'0123456789'
           ,'1993/10/12'
           ,N'有太陽般的笑容')
GO
