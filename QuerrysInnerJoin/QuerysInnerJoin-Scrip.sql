--Marcas cadastradas por Felipe
select
		Nome
	from Marcas
	where UsuInc = 1;

--Marcas cadastradas por Giomar
select
		Nome
	from Marcas
	where UsuInc = 2 ;

--Quantidade de marcas cadastradas por Felipe
select
		Count(UsuInc) as 'Quantidade de Marcas Cadastradas'
	from Marcas
	where UsuInc = 1
	Group by UsuInc
	order by UsuInc desc;

--Quantidade de marcas cadastradas por Giomar
select
		Count(UsuInc) as 'Quantidade de Marcas Cadastradas'
	from Marcas
	where UsuInc = 2
	Group by UsuInc
	order by UsuInc desc;

--Quantidade de marcas cadastradas por Felipe e Giomar
select
		Count(UsuInc) as 'Quantidade de Marcas Cadastradas'
	from Marcas
	where UsuInc BETWEEN 1 and 2

--Carros Cadastrados por Felipe
select
		Modelo
	from Carros
	where UsuInc = 1;

--Carros Cadastrados por Giomar
select
		Modelo
	from Carros
	where UsuInc = 2;

--Quantidade de carros cadastrados por Felipe
select
		Count(UsuInc) as 'Quantidade de Carros Cadastrados'
	from Carros
	where UsuInc = 1
	Group by UsuInc
	order by UsuInc desc;

--Quantidade de carros cadastrados por Giomar
select
		Count(UsuInc) as 'Quantidade de Carros Cadastrados'
	from Carros
	where UsuInc = 2
	Group by UsuInc
	order by UsuInc desc;

--Quantidade de carros cadastrados por Felipe e Giomar
select
		Count(UsuInc) as 'Quantidade de Carros Cadastrados'
	from Carros
	where UsuInc BETWEEN 1 and 2;

--Carros das marcas cadastradas por Felipe
select 
		C.Modelo
	from Carros C
	inner join Marcas M on C.Marca = M.Id
	where M.UsuInc = 1;

--Carros das marcas cadastradas por Giomar
select 
		C.Modelo
	from Carros C
	inner join Marcas M on C.Marca = M.Id
	where M.UsuInc = 2;

--Quantidade de carros das marcas cadastradas por Felipe
select 
		Count(C.Modelo) as 'Quantidade Cadastrada'
	from Carros C
	inner join Marcas M on C.Marca = M.Id
	where M.UsuInc = 1
	Group by M.UsuInc
	order by M.UsuInc desc;

--Quantidade de carros das marcas cadastradas por Giomar
select 
		Count(C.Modelo) as 'Quantidade Cadastrada'
	from Carros C
	inner join Marcas M on C.Marca = M.Id
	where M.UsuInc = 2
	Group by M.UsuInc
	order by M.UsuInc desc;

--Valor total de vendas 2019
select
		SUM(Valor * Quantidade) as 'Valor Total'
	from Vendas
	where YEAR(DatInc) = 2019;

--Quantidade total de vendas 2019
select
		SUM(Quantidade) as 'Quantidade Total'
	from Vendas
	where YEAR(DatInc) = 2019;

--Valor total de vendas por ano
select
		SUM(Valor * Quantidade) as 'Valor Total',
		YEAR(DatInc)
	from Vendas
	Group by YEAR(DatInc)
	order by SUM(Valor) desc;

--Quantidade total de vendas por ano
select
		SUM(Quantidade) as 'Quantidade Total'
	from Vendas
	Group by YEAR(DatInc)
	order by SUM(Quantidade) desc;

--Mês de cada ano que retornou a maior quantidade de vendas
select
		SUM(Quantidade) as 'Quantidade Vendas',
		MONTH(DatInc) as 'Mês',
		YEAR(DatInc) as 'Ano'
	from Vendas
	Group by MONTH(DatInc),YEAR(DatInc)
	order by [Quantidade Vendas] desc;

--Mês de cada ano que retornou o maior valor de vendas
select
		SUM(Quantidade * Valor) as 'Valor Vendas',
		MONTH(DatInc) as 'Mês',
		YEAR(DatInc) as 'Ano'
	from Vendas
	Group by MONTH(DatInc),YEAR(DatInc)
	order by [Valor Vendas] desc;

--Valor total de vendas realizadas por Felipe
select
		SUM(Quantidade * Valor) as 'Valor Total de Vendas'
	from Vendas
	where UsuInc = 1;

--Valor total de vendas realizadas por Giomar
select
		SUM(Quantidade * Valor) as 'Valor Total de Vendas'
	from Vendas
	where UsuInc = 2;

--Quantidade total de vendas realizadas por Felipe
select
		SUM(Quantidade) as 'Quantidade Total de Vendas'
	from Vendas
	where UsuInc = 1;

--Quantidade total de vendas realizadas por Giomar
select
		SUM(Quantidade) as 'Quantidade Total de Vendas'
	from Vendas
	where UsuInc = 2;

--Quantidade total de vendas realizadas por Felipe e Giomar
select
		Sum(Quantidade) as 'Quantidade Tota de Vendas'
	from Vendas
	where UsuInc BETWEEN 1 and 2;

--Quantidade total de vendas realizadas por Felipe e Giomar
select
		Sum(Quantidade * Valor) as 'Valor Tota de Vendas'
	from Vendas
	where UsuInc BETWEEN 1 and 2;

--Quantidade de marca mais vendida de todos os anos
select 
		M.Nome,
		SUM(V.Quantidade) as 'Quantidade Total Vendida'
	from Marcas M
	inner join Carros C on C.Marca = M.Id
	inner join Vendas V on V.Carro = C.Id
	group by M.Nome
	order by [Quantidade Total Vendida] desc;

--Valor de marca mais vendida de todos os anos
select 
		M.Nome,
		SUM(V.Quantidade * V.Valor) as 'Valor Total Vendida'
	from Marcas M
	inner join Carros C on C.Marca = M.Id
	inner join Vendas V on V.Carro = C.Id
	group by M.Nome
	order by [Valor Total Vendida] desc;

--Quantidade do carro mais vendido de todos os anos
select 
		C.Modelo,
		SUM(V.Quantidade) as 'Quantidade Total Vendida'
	from Carros C
	inner join Vendas V on V.Carro = C.Id
	group by C.Modelo
	order by [Quantidade Total Vendida] desc;

--Valor do carro mais vendido de todos os anos
select 
		C.Modelo,
		SUM(V.Quantidade * V.Valor) as 'Valor Total Vendida'
	from Carros C
	inner join Vendas V on V.Carro = C.Id
	group by C.Modelo
	order by [Valor Total Vendida] desc;