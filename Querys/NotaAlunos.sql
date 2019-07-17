/*insert into NotaAlunos (Nome,Materia,Nota)
		values ('Felipe','Matematica',5)*/
		
-- GROUP BY agrupa por indicadores comuns --
select 
		Nome,
		Materia,
		(SUM(Nota) / COUNT(*)) as 'Media',
		COUNT(Nota) as 'Provas'
	from NotaAlunos
	GROUP BY Nome,Materia
	order by Nome asc