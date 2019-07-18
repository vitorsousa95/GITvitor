/*select 
		LV.Id,
		LV.Nome,
		IIF(LV.Alocado = 1, 'Sim', 'Não') as 'Alocado',        --Chama se o livro esta alocado ou não e
		BL.Nome as 'Nome da Biblioteca'									em qual biblioteca--
	from Biblioteca BL
	inner join Livros LV on BL.Id = LV.Biblioteca*/

	

	/*select
			BL.Nome,
			Count(LV.Id) as 'QuantidadeDeLivros'		--Chama quantos livros tem em cada biblioteca--
	from Biblioteca BL
	inner join Livros LV on BL.Id = LV.Biblioteca
	group by BL.Nome*/

/*select
		BL.Nome,
		Count(LV.Id) as 'QuantLivros',                 --Metodo que correlaciona o usuario com 
		US.Nome as 'UserName'                            a tabela de livros para saber quem iseriu 
	from Biblioteca BL                                   o livro no sistema--
	inner join Livros LV on BL.Id = LV.Biblioteca
	inner join Usuario US on LV.UsuInc = US.Id
	group by BL.Nome, US.Nome*/