CREATE PROCEDURE [dbo].[ResultProc]
	@ShiftCount int = 1
AS
BEGIN
	--	SELECT @param1, @param2
	--RETURN 0
	SELECT *
	FROM dbo.Plan
	ORDER BY DAY
END