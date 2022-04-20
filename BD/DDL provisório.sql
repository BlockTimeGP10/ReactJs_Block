CREATE DATABASE BLOCKTIME_TRACKING;

USE BLOCKTIME_TRACKING;

CREATE TABLE EMPRESA(
idEmpresa int primary key NOT NULL,
nomeEmpresa varchar(200)
);
CREATE TABLE EQUIPAMENTOS(
idEquipamentos int identity primary key NOT NULL,
lat varchar(30),
lng varchar(30),
mac varchar(15),
idEmpresa int foreign key references EMPRESA(idEmpresa)
);
