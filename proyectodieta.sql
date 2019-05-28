create database proyectodieta;
use proyectodieta;

create table Usuarios(
correo varchar(50) not null,
psw blob not null,
rol char not null,
nombre_completo tinytext not null,
telefono varchar(10),
anio_nacimiento smallint not null,
direccion tinytext not null,
sexo char not null,
peso float(5,2) not null,
altura float(3,2) not null,
alergias tinytext,
pregunta tinytext not null,
respuesta varchar(30) not null,
primary key(correo)
);

insert into Usuarios values(
	'emanuel@gmail.com',
    aes_encrypt('sysadmin', 'Cual fue la marca de tu primer celularpegaso'),
	'A',
    'Emanuel Ramirez Munoz',
    '7774462087',
    1994,
    'tu corazon',
    'M',
    80.50,
    1.85,
    'ninguna',
	'Cual fue la marca de tu primer celular',
    'pegaso'
);

create table Comidas(
id_comida int auto_increment,
categoria varchar(20) not null,
nombre varchar(30) not null,
primary key(id_comida)
);


create table Dietas(
correo  varchar(50),
dia varchar(10) not null,
id_comida int
);

alter table Dietas add constraint fk_correo foreign key (correo) references
										 Usuarios(correo) on delete cascade;
alter table Dietas add constraint fk_id_comida foreign key (id_comida) references
										 Comidas(id_comida) on delete cascade;
                                         
                                         
INSERT INTO `comidas` VALUES (1,'frutas','pera'),(2,'frutas','piÃ±a'),(3,'leguminosas','pollo'),(4,'cereales','linaza'),(5,'frutas','durazno'),(6,'frutas','fresa'),(7,'frutas','limon'),(8,'frutas','mandarina'),(9,'frutas','mango'),(10,'frutas','melon'),(11,'frutas','platano'),(12,'frutas','papaya'),(13,'frutas','pepino'),(14,'frutas','guayaba'),(15,'frutas','zanahoria'),(16,'frutas','brocoli'),(17,'frutas','jitomate'),(18,'frutas','rabano'),(19,'leguminosas','garbanzos'),(20,'frutas','habas'),(21,'leguminosas','lentejas'),(23,'leguminosas','pescado'),(25,'leguminosas','salmon'),(26,'leguminosas','huevo'),(27,'leguminosas','res'),(28,'cereales','arroz'),(29,'cereales','trigo'),(30,'cereales','avena'),(31,'cereales','quinoa'),(32,'cereales','amaranto');

INSERT INTO `Usuarios` VALUES ('adrian@gmail.com',_binary '\ôK®-\'\Ð:°+™³=ûa','A','AdrianSanchezCortina','7771234567',1995,'plan de aayala','F',70.00,2.00,'ninguna','Cual fue la marca de tu primer celular','nokia'),('diego@gmail.com',_binary 'Z¦.ÿ\ì*\íüJ›º;Z]','P','Diego CartujanoPerez','1234567777',1990,'Jojutla','M',70.00,1.30,'lidocaina y penicilina','Nombre de tu mascota actual','diego'),('juana@gmail.com',_binary 'Vý\È\';\n¹\ï¶/^§','P','Juana Ramirez','7772961255',1968,'Jiutepec','F',80.00,1.65,'ninguna','Nombre de tu mascota actual','spike');