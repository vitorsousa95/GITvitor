/*insert into AulaCsharp
(Aluno,Idade, Ativo, UsuInc, UsuAlt,DatInc, DatAlt)
values
('Vitor', 23, 1, 1, 1, GETDATE(), GETDATE())
go
select * from AulaCsharp*/

/*select
		Aluno,
		Idade,
		IIF(Ativo = 1, 'Ativo','inativo') as 'Status'
	from AulaCsharp
where Id in
		(select Id
			from AulaCsharp 
			where Idade > 20)
order by Id desc*/


update AulaCsharp
	set Aluno = 'Master'
	where Id = 1
	select * from AulaCsharp
