SET LANGUAGE Português
select
		Tipodog,
		DATENAME(MONTH, DataVenda) as 'Mes',
		SUM(TotalDeVendas) as 'Total de vendas'
		from FoodTruckDoZezinho
	Group by Tipodog,DATENAME(MONTH, DataVenda)
	order by 'Total de vendas' desc