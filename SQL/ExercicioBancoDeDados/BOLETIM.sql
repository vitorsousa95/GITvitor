--CREATE DATABASE
CREATE DATABASE ExercicioBoletim;

GO

USE ExercicioBoletim;

GO
 --CREATE TABLE
 CREATE TABLE [dbo].[Alunos] (
    [Id]    INT           IDENTITY (1, 1) NOT NULL,
    [Aluno] VARCHAR (100) NOT NULL,
    [Turma] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

go

CREATE TABLE [dbo].[Notas] (
    [Aluno] INT NOT NULL,
    [Nota1] INT NOT NULL,
    [Nota2] INT NOT NULL,
    [Nota3] INT NOT NULL,
    [Nota4] INT NOT NULL,
    CONSTRAINT [FK_Table_Notas] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);

go

CREATE TABLE [dbo].[Frequencias] (
    [Aluno] INT NOT NULL,
    [Dia1]  INT NOT NULL,
    [Dia2]  INT NOT NULL,
    [Dia3]  INT NOT NULL,
    [Dia4]  INT NOT NULL,
    CONSTRAINT [FK_Table_Frequencias] FOREIGN KEY ([Aluno]) REFERENCES [dbo].[Alunos] ([Id])
);

go
--INSERT 
SET IDENTITY_INSERT [dbo].[Alunos] ON
INSERT INTO [dbo].[Alunos] ([Id], [Aluno], [Turma]) VALUES (1, N'Zezinho', 1)
INSERT INTO [dbo].[Alunos] ([Id], [Aluno], [Turma]) VALUES (2, N'Joazinho', 1)
INSERT INTO [dbo].[Alunos] ([Id], [Aluno], [Turma]) VALUES (3, N'Dattebayo', 1)
INSERT INTO [dbo].[Alunos] ([Id], [Aluno], [Turma]) VALUES (4, N'Baraka', 1)
INSERT INTO [dbo].[Alunos] ([Id], [Aluno], [Turma]) VALUES (5, N'Teobastino', 1)
SET IDENTITY_INSERT [dbo].[Alunos] OFF

go

INSERT INTO [dbo].[Frequencias] ([Aluno], [Dia1], [Dia2], [Dia3], [Dia4]) VALUES (1, 1, 1, 1, 1)
INSERT INTO [dbo].[Frequencias] ([Aluno], [Dia1], [Dia2], [Dia3], [Dia4]) VALUES (2, 1, 1, 1, 1)
INSERT INTO [dbo].[Frequencias] ([Aluno], [Dia1], [Dia2], [Dia3], [Dia4]) VALUES (3, 1, 0, 0, 0)
INSERT INTO [dbo].[Frequencias] ([Aluno], [Dia1], [Dia2], [Dia3], [Dia4]) VALUES (4, 1, 1, 1, 1)
INSERT INTO [dbo].[Frequencias] ([Aluno], [Dia1], [Dia2], [Dia3], [Dia4]) VALUES (5, 1, 1, 1, 1)

go

INSERT INTO [dbo].[Notas] ([Aluno], [Nota1], [Nota2], [Nota3], [Nota4]) VALUES (1, 5, 6, 8, 8)
INSERT INTO [dbo].[Notas] ([Aluno], [Nota1], [Nota2], [Nota3], [Nota4]) VALUES (2, 7, 8, 9, 9)
INSERT INTO [dbo].[Notas] ([Aluno], [Nota1], [Nota2], [Nota3], [Nota4]) VALUES (3, 1, 1, 1, 1)
INSERT INTO [dbo].[Notas] ([Aluno], [Nota1], [Nota2], [Nota3], [Nota4]) VALUES (4, 10, 10, 9, 9)
INSERT INTO [dbo].[Notas] ([Aluno], [Nota1], [Nota2], [Nota3], [Nota4]) VALUES (5, 10, 10, 10, 10)

go

select
		AL.Aluno,
		AL.Turma,
		NT.Nota1,
		NT.Nota2,
		NT.Nota3,
		NT.Nota4,
		(NT.Nota1 + NT.Nota2 + NT.Nota3 + NT.Nota4)/4 as 'Media',
		CONCAT((FQ.Dia1 + FQ.Dia2 + FQ.Dia3 + FQ.Dia4)*100/4,'%') as 'Frequencia',
		IIF(((NT.Nota1 + NT.Nota2 + NT.Nota3 + NT.Nota4)/4 >= 7)
		and (FQ.Dia1 + FQ.Dia2 + FQ.Dia3 + FQ.Dia4)*100/4 >= 75, 'Aprovado','Reprovado') as 'Status'
	from Alunos AL
	inner join Notas NT on AL.Id = NT.Aluno
	inner join Frequencias FQ on AL.Id = FQ.Aluno
