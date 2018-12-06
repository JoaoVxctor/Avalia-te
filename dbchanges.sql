drop table conjuncao;
drop table questao_materia_nivelensino;

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
	ON DELETE CASCADE,

);