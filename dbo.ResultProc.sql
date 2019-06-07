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
									WHERE FACT > [PLAN]
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
									WHERE FACT > [PLAN]
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