--Adiciona uma nova Key a tabela para inserir dados a presença
--de maneira que não se repita a mesma data,
--ou seja uma chave unica.
--Assim na comparação do Diarios com Presencas as informações
--deverão ser iguais para que as iformações sejam mostradas.

CREATE UNIQUE INDEX UC_Presencas_insert
ON Presencas(Diario,Aluno);

--Inseri valores de turma e aluno na tabela TurmasAlunos

INSERT INTO TurmasAlunos
(Turma,Aluno)
VALUES
(1,1);
INSERT INTO TurmasAlunos
(Turma,Aluno)
VALUES
(1,2);

--Select com a função de chamar o nome da turma e o nome do aluno.

SELECT	tr.Nome as 'Turma',
		a.Aluno
	FROM Turmas tr
		inner join TurmasAlunos ta on tr.Id = ta.Turma
		inner join Alunos a on ta.Aluno = ta.Turma
		inner join Diarios d on tr.Id = d.Turma

--Select com a função de chamar o Aluno, a Nota e a Presença 

SELECT 
		d.[Data],
		tr.Aluno,
		ISNULL(n.Nota,0) as 'Notas',
		IIF(ISNULL(p.Id,0) >0, 'Presente', 'Ausente') as 'Presenças'
	FROM Diarios d 
		inner join TurmasAlunos tr on d.Turma = tr.Turma
		left join Presencas p on d.Id = p.Diario and tr.Aluno = p.Aluno
		left join Notas n on tr.Aluno = n.Aluno and d.Id = n.Diario

--Select com função de chamar os alunos, somar as notas e mostrar a media de acordo com o Diario.

SELECT 
		a.Aluno,
		SUM(n.Nota) / COUNT(d.[Data]) as 'Média'
	FROM Alunos a
		inner join TurmasAlunos tr on a.Id = tr.Aluno
		inner join Diarios d on tr.Turma = d.Turma
		left  join Notas n on d.Id = n.Diario and a.Id = n.Aluno
WHERE tr.Turma = 2
GROUP BY a.Aluno