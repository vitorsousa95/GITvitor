select
		AL.Aluno,
		AL.Turma,
		(NT.Nota1 + NT.Nota2 + NT.Nota3 + NT.Nota4)/4 as 'Media',

		IIF (((NT.Nota1 + NT.Nota2 + NT.Nota3 + NT.Nota4)/4 >= 7 and ), 'Aprovado','Reprovado') as 'Status'

	from Alunos AL
	inner join Notas NT on AL.Id = NT.Aluno
	inner join Frequencias FQ on AL.Id = FQ.Aluno

	