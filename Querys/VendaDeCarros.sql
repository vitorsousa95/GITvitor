select 'Carros' as 'Carros',
		SUM(Temp.[Media de Vendas]) as 'Vendas',
		Temp.[Vendas no Ano]
from(select 
		ModeloDoCarro,
		Ano,
		(SUM(NumeroDeVendas)/ COUNT(*)) as 'Media de Vendas',
		YEAR(DataDaVenda) as 'Vendas no Ano'
		from TabelaDeCarros
	GROUP BY ModeloDoCarro,Ano, YEAR(DataDaVenda)) Temp
group by Temp.[Vendas no Ano]
	