
SELECT Y,M,COUNT(*) from (
	SELECT 
		substring(cast(DPRAJDTO as varchar(20)),1,4) As Y, 
		substring(cast(DPRAJDTO as varchar(20)),5,2) As M,
		Len(PNR) AS L
	FROM [DTPERSAJOURHIST] 
) as aaa
group by Y,M
order by Y,M

SELECT Y,M,COUNT(*) from (
	SELECT 
		substring(cast(DPRAJDTO as varchar(20)),1,4) As Y, 
		substring(cast(DPRAJDTO as varchar(20)),5,2) As M,
		Len(PNR) AS L
	FROM (SELECT PNR,Min(DPRAJDTO) AS DPRAJDTO FROM [DTPERSAJOURHIST] GROUP BY PNR)as ddd
) as aaa
group by Y,M
order by Y,M