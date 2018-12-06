

CREATE TABLE IF NOT EXISTS professor(
	id SERIAL NOT NULL PRIMARY KEY,
	nome char(40),	email char(50),
	senha char(20)

);

CREATE TABLE IF NOT EXISTS questoes(
	id SERIAL NOT NULL PRIMARY KEY,
	fk_professor int,
	tipo char (34),
	enunciado char (500),
	resposta char (400),
	 titulo char(40),	
	CONSTRAINT fk_professor FOREIGN KEY (fk_professor)
	REFERENCES professor(id)
	ON DELETE CASCADE
	
	
);	

CREATE TABLE IF NOT EXISTS materia(
	id SERIAL NOT NULL PRIMARY KEY,
	nome char (40)
);

CREATE TABLE IF NOT EXISTS nivelEnsino(
	id SERIAL NOT NULL PRIMARY KEY,
	nome char (40)
);
create table conjuncao(
	id serial primary key,
	fk_questao int,
	fk_materia int,
	fk_nivelensino int,
	fk_professor int,
	
	foreign key (fk_questao) references questoes(id)
	ON DELETE CASCADE,

	foreign key (fk_materia) references materia(id)
	ON DELETE CASCADE,

	foreign key (fk_nivelensino) references nivelensino(id)
	ON DELETE CASCADE,

	foreign key (fk_professor) references professor(id)
	ON DELETE CASCADE

);

--------------------- INSERTS ----------------------------
INSERT INTO professor( nome, email, senha) VALUES 
('LUAN MICHEL','luan.michel7@gmail.com','luanzinhomichel0102'),
('GUSTAVO RAMIRES','guramires2000@gmail.com','32571553'),
('CARLOS EDUARDO','markjones@gmail.com','toddynho123')
;

INSERT INTO materia(nome) VALUES 
('Física'),
('Química'),
('Matêmatica'),
('Educação Física'),
('Portuês'),
('Biologia');

INSERT INTO nivelEnsino(nome) VALUES 
('Ensino Medio'),
('Ensino Fundamental'),
('Ensino Superior')
;

INSERT INTO questoes( fk_professor, tipo, enunciado, resposta,titulo) VALUES 
(1,'dissertativa' , '1+1', '2', '1+1'),
(2,'dissertativa' , '1+2', '3', '1+2'),
(3,'dissertativa' , '1+3', '4', '1+3'),
(1,'dissertativa' , '1+4', '5', '1+4'),
(2,'dissertativa' , '1+5', '6', '1+5');

INSERT INTO conjuncao(  fk_professor, fk_materia, fk_nivelEnsino) VALUES 
(1,1,1),
(1,2,1),
(1,3,1),
(2,1,1),
(2,2,1),
(2,3,1),
(3,1,1),
(3,2,1),
(3,3,1)
;

CREATE TABLE questao_materia_nivelensino (
id serial not null primary key,
fk_questao int,
FOREIGN KEY (fk_questao) references questoes(id),
fk_materia int,
FOREIGN KEY (fk_materia) references materia(id),
fk_nivelensino int,
FOREIGN KEY (fk_nivelensino) references nivelensino(id)
)

INSERT INTO questao_materia_nivelensino (fk_questao, fk_materia, fk_nivelensino)
values(1, 3, 2), (2, 3, 2), (3, 3, 2), (4, 3, 2), (5, 3, 2);