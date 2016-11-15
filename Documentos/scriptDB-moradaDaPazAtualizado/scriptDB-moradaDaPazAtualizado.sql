--CREATE DATABASE morada_da_pazdb
--GO
--USE morada_da_pazdb
--CREATE TABLE especializacao_usuario (id INT PRIMARY KEY IDENTITY NOT NULL,
--									 descricao TEXT NOT NULL);

--CREATE TABLE unidade_residencial (id INT PRIMARY KEY IDENTITY NOT NULL,
--								  numero_unidade VARCHAR(8) NOT NULL, 
--								  descricao TEXT);

--CREATE TABLE usuario (id INT PRIMARY KEY IDENTITY NOT NULL,
--					  email VARCHAR(30), 
--					  login_ VARCHAR(30) NOT NULL, 
--					  senha VARCHAR(500) NOT NULL, 
--					  nome_completo VARCHAR(100) NOT NULL,
--					  id_unidade_residencial REFERENCES unidade_residencial(id) NOT NULL,
--					  id_especializacao REFERENCES especializacao_usuario(id) NOT NULL);

--CREATE TABLE advertencia (id INT PRIMARY KEY IDENTITY NOT NULL, 
--						  descricao TEXT NOT NULL);

--CREATE TABLE multa (id INT PRIMARY KEY IDENTITY NOT NULL, 
--					descricao TEXT, 
--					preco DECIMAL(10,2) NOT NULL);

--CREATE TABLE ocorrencia (id INT PRIMARY KEY IDENTITY NOT NULL, 
--						situacao VARCHAR(30) DEFAULT ('aberto') NOT NULL, 
--						numero_ocorrencia VARCHAR(30) NOT NULL, 
--						descricao TEXT NOT NULL,
--						id_usuario INT REFERENCES usuario(id) NOT NULL,
--						id_unidade_residencial INT REFERENCES unidade_residencial(id) NOT NULL);

--CREATE TABLE ocorrencia_advertencia (id_ocorrencia INT REFERENCES ocorrencia(id) NOT NULL,
--									 id_advertencia INT REFERENCES advertencia(id) NOT NULL
--									 PRIMARY KEY(id_ocorrencia, id_advertencia));

--CREATE TABLE ocorrencia_multa (id_ocorrencia INT REFERENCES ocorrencia(id) NOT NULL,
--							   id_multa INT REFERENCES advertencia(id) NOT NULL,
--							   valor_total DECIMAL(8,2) NOT NULL,
--							   PRIMARY KEY(id_ocorrencia, id_multa));