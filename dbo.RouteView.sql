CREATE VIEW [dbo].[RouteView]
AS
(
	SELECT A.Id, A.Article, B.Name NameArticle , A.[Group], C.Name NameGroup
	FROM Route A
	LEFT JOIN dbo.Article B ON A.Article = B.Id
	LEFT JOIN dbo.[Group] C ON A.[Group] = C.Id
)
