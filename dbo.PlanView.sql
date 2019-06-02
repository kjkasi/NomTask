CREATE VIEW [dbo].[PlanView]
AS
(
	SELECT A.Id, A.Article, B.[Name], A.[Day], A.[Count]
	FROM dbo.[Plan] A
	LEFT JOIN dbo.Article B ON A.Article = B.Id
)
