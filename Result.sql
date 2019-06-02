	SELECT *
	FROM dbo.[Plan]
	ORDER BY DAY

	SELECT *
	FROM dbo.Time
	ORDER BY Article

	SELECT A.Article, SUM(A.ProcessTime * B.[Count] + A.ProduceTime) AS [SUM]
	FROM dbo.Time A
	LEFT JOIN dbo.[Plan] B ON A.Article = B.Article
	GROUP BY A.Article

	SELECT C.*
	FROM	(
				SELECT A.Article, SUM(A.ProcessTime * B.[Count] + A.ProduceTime) AS [SUM]
				FROM dbo.Time A
				LEFT JOIN dbo.[Plan] B ON A.Article = B.Article
				GROUP BY A.Article
			) C

	DECLARE @ShiftCount INT = 3

	SELECT	C.Article, C.[Group], 
			CASE @ShiftCount 
				WHEN 1 THEN ROUND(C.[SUM] / 8, 0)
				WHEN 2 THEN ROUND(C.[SUM] / 16, 0)
				WHEN 3 THEN ROUND(C.[SUM] / 24, 0)
			END [SUM]
	FROM	(
				SELECT A.Article, A.[Group], SUM(A.ProcessTime * B.[Count] + A.ProduceTime) AS [SUM]
				FROM dbo.Time A
				LEFT JOIN dbo.[Plan] B ON A.Article = B.Article
				GROUP BY A.Article, A.[Group]
			) C
	ORDER BY Article

	DECLARE @ShiftCount INT = 3

	SELECT	C.Article, C.[Group], 
			CASE @ShiftCount 
				WHEN 1 THEN ROUND(C.[SUM] / 8, 0)
				WHEN 2 THEN ROUND(C.[SUM] / 16, 0)
				WHEN 3 THEN ROUND(C.[SUM] / 24, 0)
			END [SUM],
			ROW_NUMBER() OVER(PARTITION BY C.[Article] ORDER BY C.Article ASC) AS [Row#],
			ROW_NUMBER() OVER(ORDER BY C.Article ASC)
	FROM	(
				SELECT A.Article, A.[Group], SUM(A.ProcessTime * B.[Count] + A.ProduceTime) AS [SUM]
				FROM dbo.Time A
				LEFT JOIN dbo.[Plan] B ON A.Article = B.Article
				GROUP BY A.Article, A.[Group]
			) C
	ORDER BY Article, [Group]



