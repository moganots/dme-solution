/*********************************************************]******************************************************************************************************
 * Symmetric Pairs
 * You are given a table, Functions, containing two columns: X and Y. * Two pairs (X , Y ) and (X , Y ) are said to be symmetric pairs if X = Y and X = Y .
 * Write a query to output all such symmetric pairs in ascending order by the value of X.
 ***************************************************************************************************************************************************************/
DECLARE @Functions TABLE ([X][int], [Y][int]);

;WITH [cte] AS (
	SELECT 20 [x], 20 [Y] UNION
	SELECT 20 [x], 20 [Y] UNION
	SELECT 20 [x], 21 [Y] UNION
	SELECT 23 [x], 22 [Y] UNION
	SELECT 22 [x], 23 [Y] UNION
	SELECT 21 [x], 20 [Y]
)
INSERT INTO @Functions
SELECT [X], [Y] FROM [cte];

SELECT
	[X]
	,[Y]
FROM (
	SELECT
		[X]
		,[Y]
	FROM @Functions
	WHERE
		([X] = [Y])
	GROUP BY
		[X]
		,[Y]
	HAVING COUNT(*) = 2

	UNION

	SELECT
		[f1].[X]
		,[f1].[Y]
	FROM @Functions [f1], @Functions [f2] 
	WHERE
		([f1].[X] < [f1].[Y])
		AND ([f1].[X] = [f2].[Y])
		AND ([f2].[X] = [f1].[Y])
) AS [result]
ORDER BY
	[X]
	,[Y];