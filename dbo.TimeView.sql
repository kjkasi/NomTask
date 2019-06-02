CREATE VIEW [dbo].[TimeView]
AS
(
	SELECT A.Id, A.Article, B.Name NameArticle, A.[Group], C.Name NameGroup, A.ProcessTime, A.ProduceTime
	FROM dbo.Time A
	LEFT JOIN dbo.Article B ON A.Article = B.Id
	LEFT JOIN dbo.[Group] C ON A.[Group] = C.Id
)
