/***************************************************************************************************************************************************************
 * Japanese Cities' Names
 * Query the names of all the Japanese cities in the CITY table. The COUNTRYCODE for Japan is JPN .
 ***************************************************************************************************************************************************************/
SELECT
	[NAME]
FROM [dbo].[CITY]
WHERE
	[COUNTRYCODE] IN ('JPN')
	
SELECT
	[NAME]
FROM [dbo].[CITY]
WHERE
	[COUNTRYCODE] = 'JPN'