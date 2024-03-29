USE [NomTask]
GO
/****** Object:  Table [dbo].[Machine]    Script Date: 23.06.2019 19:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Machine](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 23.06.2019 19:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Group](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MachineByGroup]    Script Date: 23.06.2019 19:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MachineByGroup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Machine] [int] NULL,
	[Group] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[MachineByGroupView]    Script Date: 23.06.2019 19:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[MachineByGroupView]
AS
(
	SELECT A.Id, A.Machine, B.Name NameMachine, A.[Group], C.Name NameGroup 
	FROM dbo.MachineByGroup A
	LEFT JOIN dbo.Machine B ON A.Machine = B.Id
	LEFT JOIN dbo.[Group] C ON A.[Group] = C.Id
)
GO
/****** Object:  Table [dbo].[Article]    Script Date: 23.06.2019 19:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Article](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Route]    Script Date: 23.06.2019 19:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Route](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Article] [int] NULL,
	[Group] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[RouteView]    Script Date: 23.06.2019 19:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[RouteView]
AS
(
	SELECT A.Id, A.Article, B.Name NameArticle , A.[Group], C.Name NameGroup
	FROM Route A
	LEFT JOIN dbo.Article B ON A.Article = B.Id
	LEFT JOIN dbo.[Group] C ON A.[Group] = C.Id
)
GO
/****** Object:  Table [dbo].[Time]    Script Date: 23.06.2019 19:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Time](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Article] [int] NULL,
	[Group] [int] NULL,
	[ProcessTime] [float] NULL,
	[ProduceTime] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[TimeView]    Script Date: 23.06.2019 19:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[TimeView]
AS
(
	SELECT A.Id, A.Article, B.Name NameArticle, A.[Group], C.Name NameGroup, A.ProcessTime, A.ProduceTime
	FROM dbo.Time A
	LEFT JOIN dbo.Article B ON A.Article = B.Id
	LEFT JOIN dbo.[Group] C ON A.[Group] = C.Id
)
GO
/****** Object:  Table [dbo].[Plan]    Script Date: 23.06.2019 19:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Article] [int] NULL,
	[Day] [int] NULL,
	[Count] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[PlanView]    Script Date: 23.06.2019 19:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[PlanView]
AS
(
	SELECT A.Id, A.Article, B.[Name], A.[Day], A.[Count]
	FROM dbo.[Plan] A
	LEFT JOIN dbo.Article B ON A.Article = B.Id
)
GO
ALTER TABLE [dbo].[MachineByGroup]  WITH CHECK ADD  CONSTRAINT [FK_MachineByGroup_Machine] FOREIGN KEY([Machine])
REFERENCES [dbo].[Machine] ([Id])
GO
ALTER TABLE [dbo].[MachineByGroup] CHECK CONSTRAINT [FK_MachineByGroup_Machine]
GO
ALTER TABLE [dbo].[MachineByGroup]  WITH CHECK ADD  CONSTRAINT [FK_MachineByGroup_ToGroup] FOREIGN KEY([Group])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[MachineByGroup] CHECK CONSTRAINT [FK_MachineByGroup_ToGroup]
GO
ALTER TABLE [dbo].[Plan]  WITH CHECK ADD  CONSTRAINT [FK_Plan_ToArticle] FOREIGN KEY([Article])
REFERENCES [dbo].[Article] ([Id])
GO
ALTER TABLE [dbo].[Plan] CHECK CONSTRAINT [FK_Plan_ToArticle]
GO
ALTER TABLE [dbo].[Route]  WITH CHECK ADD  CONSTRAINT [FK_Route_ToArticle] FOREIGN KEY([Article])
REFERENCES [dbo].[Article] ([Id])
GO
ALTER TABLE [dbo].[Route] CHECK CONSTRAINT [FK_Route_ToArticle]
GO
ALTER TABLE [dbo].[Route]  WITH CHECK ADD  CONSTRAINT [FK_Route_ToGroup] FOREIGN KEY([Group])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[Route] CHECK CONSTRAINT [FK_Route_ToGroup]
GO
ALTER TABLE [dbo].[Time]  WITH CHECK ADD  CONSTRAINT [FK_Time_ToArticle] FOREIGN KEY([Article])
REFERENCES [dbo].[Article] ([Id])
GO
ALTER TABLE [dbo].[Time] CHECK CONSTRAINT [FK_Time_ToArticle]
GO
ALTER TABLE [dbo].[Time]  WITH CHECK ADD  CONSTRAINT [FK_Time_ToGroup] FOREIGN KEY([Group])
REFERENCES [dbo].[Group] ([Id])
GO
ALTER TABLE [dbo].[Time] CHECK CONSTRAINT [FK_Time_ToGroup]
GO
/****** Object:  StoredProcedure [dbo].[Result]    Script Date: 23.06.2019 19:08:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Result]
	@ShiftCount int = 1
AS
BEGIN
	DECLARE @TASK_TABLE TABLE(Article INT, [Group] INT, [SUM] INT, [DAY] INT, LAG# INT, ROW# INT)

	INSERT INTO @TASK_TABLE
	SELECT	D.*,
			ISNULL(LAG([SUM]) OVER(ORDER BY D.[Day]), 0) LAG#,
			ROW_NUMBER() OVER(ORDER BY D.[Day]) ROW#
	FROM	(
				SELECT	C.Article, C.[Group], 
						CASE @ShiftCount 
							WHEN 1 THEN ROUND(C.[SUM] / 8, 0)
							WHEN 2 THEN ROUND(C.[SUM] / 16, 0)
							WHEN 3 THEN ROUND(C.[SUM] / 24, 0)
						END [SUM],
						P.[Day]
				FROM	(
							SELECT A.Article, A.[Group], SUM(A.ProcessTime * B.[Count] + A.ProduceTime) AS [SUM]
							FROM dbo.[Time] A
							LEFT JOIN dbo.[Plan] B ON A.Article = B.Article
							GROUP BY A.Article, A.[Group]
						) C
				LEFT JOIN dbo.[Plan] P ON C.Article = P.Article
			) D
	ORDER BY D.[Day]

	DECLARE @COMPARE TABLE (ARTICLE INT, [PLAN] INT, FACT INT)

	INSERT	INTO @COMPARE
	SELECT	A.Article, A.[DAY], [FACT]
	FROM	(
				SELECT	*,
						(
							SELECT SUM(LAG#) + 1
							FROM @TASK_TABLE LG
							WHERE LG.ROW# <= TT.ROW#
						) FACT
				FROM @TASK_TABLE TT
			) A
	ORDER BY A.[DAY]

	DECLARE @COMPARE_RESULT TABLE (ARTICLE INT, [PLAN] INT, FACT INT)

	INSERT INTO @COMPARE_RESULT
	SELECT A.ARTICLE, A.[PLAN], B.FACT
	FROM 
	(
		SELECT ARTICLE, [PLAN]
		FROM @COMPARE
		GROUP BY ARTICLE, [PLAN]
	)  A

	LEFT JOIN	(
					SELECT ARTICLE, MAX(FACT) FACT
					FROM @COMPARE
					GROUP BY ARTICLE
				) B ON B.ARTICLE = A.ARTICLE

	DECLARE @ABM_RESULT TABLE (ARTICLE INT, [GROUP] INT, MACHINE INT)
	
	INSERT INTO @ABM_RESULT
	SELECT R.Article, R.[Group], M.Machine
	FROM [Route] R
	LEFT JOIN MachineByGroup M ON R.[Group] = M.[Group]
	WHERE R.Article IN	(
									SELECT ARTICLE
									FROM @COMPARE_RESULT
									WHERE FACT >= [PLAN]
						)

	DECLARE @ABM_RESULT2 TABLE (ARTICLE INT, [GROUP] INT, MACHINE INT, CNT INT) 
	
	INSERT INTO @ABM_RESULT2
	SELECT	A.*,
			ROUND(P.COUNT / (
				SELECT COUNT([GROUP])
				FROM @ABM_RESULT B
				WHERE B.[GROUP] = A.[GROUP]
				GROUP BY B.[GROUP]
			), 0) CNT
	FROM @ABM_RESULT A
	LEFT JOIN [Plan] P ON P.Article = A.ARTICLE

	DECLARE @NEW_PLAN TABLE (ID INT,ARTICLE INT, [DAY] INT, [COUNT] INT)

	INSERT INTO @NEW_PLAN
	SELECT *
	FROM [Plan]

	UPDATE @NEW_PLAN
	SET [COUNT] =	(
						SELECT TOP 1 AR.CNT
						FROM @ABM_RESULT2 AR
						WHERE AR.ARTICLE = NP.ARTICLE
					)
	FROM @NEW_PLAN NP
	WHERE NP.Article IN	(
									SELECT ARTICLE
									FROM @COMPARE_RESULT
									WHERE FACT >= [PLAN]
						)

	DELETE FROM @TASK_TABLE

	INSERT INTO @TASK_TABLE
	SELECT	D.*,
			ISNULL(LAG([SUM]) OVER(ORDER BY D.[Day]), 0) LAG#,
			ROW_NUMBER() OVER(ORDER BY D.[Day]) ROW#
	FROM	(
				SELECT	C.Article, C.[Group], 
						CASE @ShiftCount 
							WHEN 1 THEN ROUND(C.[SUM] / 8, 0)
							WHEN 2 THEN ROUND(C.[SUM] / 16, 0)
							WHEN 3 THEN ROUND(C.[SUM] / 24, 0)
						END [SUM],
						P.[Day]
				FROM	(
							SELECT A.Article, A.[Group], SUM(A.ProcessTime * B.[Count] + A.ProduceTime) AS [SUM]
							FROM dbo.[Time] A
							LEFT JOIN @NEW_PLAN B ON A.Article = B.Article
							GROUP BY A.Article, A.[Group]
						) C
				LEFT JOIN dbo.[Plan] P ON C.Article = P.Article
			) D
	ORDER BY D.[Day]

	SELECT	*,
			(
				SELECT SUM(LAG#) + 1
				FROM @TASK_TABLE LG
				WHERE LG.ROW# <= TT.ROW#
			) FACT
	FROM @TASK_TABLE TT
END
GO
