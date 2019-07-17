select
		Tipodog,
		TotalDeVendas,
		SUM(TotalDeVendas)  as 'VendasTotalMês',
		MONTH(DataVenda) as 'Mês'
		from FoodTruckDoZezinho
		group by Tipodog,TotalDeVendas,MONTH(DataVenda)
		order by TotalDeVendas asc