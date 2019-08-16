/*insert into Diario1
(Nome,Materia,Nota1,Nota2,Nota3,Nota4,Nota5,Nota6)
values
('Felipe','Programacao',7,9,5,8,9,7)
go
select * from Diario1

select
		Nome,
		Materia,
		Nota1,
		Nota2,
		Nota3,
		Nota4,
		Nota5,
		Nota6,
		((Nota1 + Nota2 + Nota3 + Nota4 + Nota5 + Nota6)/6) as 'Media',
		IIF(((Nota1 + Nota2 + Nota3 + Nota4 + Nota5 + Nota6)/6) >= 5, 'Aprovado','Reprovado') as 'Status'
from Diario1;*/

-- Metodo que repete meus registros de uma tabela para outra ou para si mesma --
/*select count(*) from diario1;

INSERT INTO Diario1(Nome,Materia,Nota1,Nota2,Nota3,Nota4,Nota5,Nota6)
      SELECT Nome,Materia,Nota1,Nota2,Nota3,Nota4,Nota5,Nota6
      FROM Diario1
	  where id > 40

      go
	 select count(*) from diario1;*/ 
