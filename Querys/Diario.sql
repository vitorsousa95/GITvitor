/*insert into Diario
(Nome,Materia,Nota1,Nota2,Nota3)
values
('Vitor','Paint3D',5,8,6)
go
select * from Diario;*/

/*select 
		Nome,
		Materia,
		((Nota1 + Nota2 + Nota3)/3) as 'Media',
		IIF((Nota1 + Nota2 + Nota3)/(3) >= 7, 'Aprovado', 'Reprovado' as 'Status'
from Diario*/