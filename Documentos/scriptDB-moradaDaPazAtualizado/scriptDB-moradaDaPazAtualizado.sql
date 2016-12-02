--create database morada_da_pazdb
--go
--use morada_da_pazdb
--create table especializacao_usuario (id int primary key identity not null,
--									 descricao text not null);

--create table unidade_residencial (id int primary key identity not null,
--								  numero_unidade varchar(8) not null, 
--								  descricao text);

--create table usuario (id int primary key identity not null,
--					  email varchar(30), 
--					  login_ varchar(30) not null, 
--					  senha varchar(500) not null, 
--					  nome_completo varchar(100) not null,
--					  id_unidade_residencial int references unidade_residencial(id) not null,
--					  id_especializacao int references especializacao_usuario(id) not null);

--create table advertencia (id int primary key identity not null, 
--						  descricao text not null);

--create table multa (id int primary key identity not null, 
--					descricao text, 
--					preco Float not null);

--create table ocorrencia (id int primary key identity not null, 
--						situacao varchar(30) default ('aberto'), 
--						numero_ocorrencia varchar(30) not null, 
--						descricao text not null,
--						tipoPublico int DEFAULT (0),
--						id_usuario int references usuario(id) not null,
--						id_unidade_residencial int references unidade_residencial(id));

--create table ocorrencia_advertencia (id_ocorrencia int references ocorrencia(id) not null,
--									 id_advertencia int references advertencia(id) not null
--									 primary key(id_ocorrencia, id_advertencia));

--create table ocorrencia_multa (id_ocorrencia int references ocorrencia(id) not null,
--							   id_multa int references advertencia(id) not null,
--							   valor_total Float not null,
--							   primary key(id_ocorrencia, id_multa));

--INSERT INTO unidade_residencial (numero_unidade, descricao) VALUES (123, 'alugado');

--INSERT INTO especializacao_usuario (descricao) VALUES ('admin');

--INSERT INTO usuario (login_,senha,nome_completo,id_unidade_residencial, id_especializacao ) 
--VALUES ('admin', 'admin', 'helio ferreira', 1, 1)

--select * from ocorrencia;

--SELECT * FROM usuario

--SELECT id, situacao, numero_ocorrencia, descricao, id_usuario, id_unidade_residencial FROM ocorrencia

--ALTER TABLE ocorrencia ADD tipoPublico int DEFAULT (0);

--UPDATE ocorrencia SET tipoPublico = 0;

--INSERT INTO ocorrencia (situacao,numero_ocorrencia ,descricao, id_usuario, id_unidade_residencial, tipoPublico)
-- VALUES (NULL, 1042512759, 'caguei na piscina', 1, 1, 1)
--use morada_da_pazdb
--select * from ocorrencia;

--INSERT INTO especializacao_usuario (descricao) VALUES ('Morador');
--select * from especializacao_usuario;
--update ocorrencia set id_usuario = 2 where id = 4

select * from multa;
