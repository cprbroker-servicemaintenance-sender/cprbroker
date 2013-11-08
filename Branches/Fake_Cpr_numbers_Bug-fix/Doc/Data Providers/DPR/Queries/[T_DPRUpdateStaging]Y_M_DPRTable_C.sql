
/****** Script for SelectTopNRows command from SSMS  ******/
select Y,M,DPRTable,COUNT(*) FROM(
SELECT [DPRTable],
      datepart(Year,CreateTS) AS Y,
      datepart(Month,CreateTS) AS M
  FROM [DPR].[dbo].[T_DPRUpdateStaging]
  ) AS SSS
  GROUP BY Y,M,DPRTable
  ORDER BY Y,M,DPRTable
  
  