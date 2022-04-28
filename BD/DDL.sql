CREATE DATABASE BLOCKTIME_TRACKING;

USE BLOCKTIME_TRACKING;

CREATE TABLE EMPRESA(
idEmpresa int primary key NOT NULL,
nomeEmpresa varchar(200) NOT NULL
);

CREATE TABLE EQUIPAMENTOS(
idEquipamento int primary key NOT NULL,
idEmpresa int foreign key references EMPRESA(idEmpresa),
ultimaAtt smalldatetime,
lat varchar(30) NOT NULL,
lng varchar(30) NOT NULL,
nomeNotebook char(17) UNIQUE NOT NULL,
);


