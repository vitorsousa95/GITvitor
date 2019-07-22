-- Metodo que mostra o carro, a quantidade e o mes que foi alocado.
/*select
		CA.Nome as 'Carros',
		Count(L.DataAloc) as 'Quantidade Alocado',
		MONTH(L.DataAloc) as 'Mês'
	from Locacoes L
		inner join Carros CA on L.Carro = CA.Id
		Group by CA.Nome,L.DataAloc
	order by L.DataAloc asc*/

--Metodo que carrega quantas vezes o carro foi alocado no ano de 2018
/*select 
		CA.Nome as 'Carros',
		Count(L.DataAloc) as 'Vezes alocado no Ano'
	from Carros CA
		inner join Locacoes L on L.Carro = CA.Id
		Group by CA.Nome*/