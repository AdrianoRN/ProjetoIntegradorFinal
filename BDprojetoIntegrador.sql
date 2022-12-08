create database projeto_integrador;

use projeto_integrador;

create table colaborador (
  n_idColab int not null auto_increment,
  c_cpfColb varchar(20),
  c_nomeColab varchar(100),
  c_cargoTutor bool,
  c_cargoProfessor bool,
  primary key (n_idColab));
  
-- desc comclien;


create table Aluno (
  n_matricula int not null ,
  c_cpfAluno varchar(20),
  c_nomeAluno varchar(100),
  d_dataNasc date,
  c_foneAluno varchar(20),
  primary key(n_matricula));
  
  -- desc comforne;
  
create table Disciplina(
  n_codDisci int not null,
  c_nomeDisci varchar(100),
  c_horasDisci varchar(10),
  primary key(n_codDisci));
  
-- desc comvende;
create table Avaliacao(
  c_nomeDisci VARCHAR(100),
  n_notaAvalia int,
  c_comentario text,
  foreign key(n_nomeDisci));
  
-- desc comprodu;
delimiter //
create procedure popula_colaborador(in idColb int , in cpfColb varchar(100) , in nomeColab  text , in cargoTutor int , in cargoProfessor int)
begin
	insert into colaborador ( n_idColab , c_cpfColb , c_nomeColab , c_cargoTutor , c_cargoProfessor )
	values (idColb , cpfColb , nomeColab , cargoProfessor , cargoTutor);
end //
delimiter ;
call popula_colaborador (01 , '023.333.444-55' , 'chewbacca' , 1 , 0 ) ;

select * from colaborador;


