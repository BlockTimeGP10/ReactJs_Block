create database BlockTimeTracking;

use BlockTimeTracking;

create table EMPRESAS(
idEmpresa int primary key not null,
nomeEmpresa varchar(200) not null
);

create table EQUIPAMENTOS(
idEquipamento int not null,
idEmpresa int not null,
ultimaAtt datetime,
lat varchar(30) not null,
lng varchar(30) not null,
primary key (idequipamento),
foreign key (idEmpresa) references EMPRESAS(idEmpresa),
nomeNotebook char(17) unique not null
);