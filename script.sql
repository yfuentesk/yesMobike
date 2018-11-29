USE master

CREATE DATABASE "MoBike"

USE MoBike

CREATE TABLE bicicleta (
    id_bici    NVARCHAR(15) NOT NULL,
    location   NVARCHAR(300) NOT NULL,
    estado     NVARCHAR(15) NOT NULL,
    id_estF    INT NOT NULL
);

ALTER TABLE bicicleta ADD CONSTRAINT bici_pk PRIMARY KEY ( id_bici );

CREATE TABLE comuna (
    id_comu       INT NOT NULL,
    nombre_comu   NVARCHAR(50) NOT NULL
);

ALTER TABLE comuna ADD CONSTRAINT comu_pk PRIMARY KEY ( id_comu );

CREATE TABLE estacionamiento (
    id_est      INT NOT NULL,
    nombre      NVARCHAR(50) NOT NULL,
    direccion   NVARCHAR(100) NOT NULL,
    capacidad   INT NOT NULL,
    id_comuF    INT NOT NULL
);

ALTER TABLE estacionamiento ADD CONSTRAINT est_pk PRIMARY KEY ( id_est );


CREATE TABLE recorrido (
    id_recorrido       INT IDENTITY(1,1),
    kilometros         FLOAT NOT NULL,
    inicio_recorrido   DATE NOT NULL,
    fin_recorrido      DATE NOT NULL,
    tiempo_estimado    FLOAT NOT NULL,
    cobro              FLOAT NOT NULL,
    id_personaF        NVARCHAR(20) NOT NULL,
    correoF NVARCHAR(50) NOT NULL,
    id_biciF           NVARCHAR(15) NOT NULL
);

ALTER TABLE recorrido ADD CONSTRAINT reco_pk PRIMARY KEY ( id_recorrido );

CREATE TABLE usuario (
	id_persona   NVARCHAR(20) NOT NULL,
    password     NVARCHAR(20) NOT NULL,
    nombre       NVARCHAR(20) NOT NULL,
    direccion    NVARCHAR(100) NOT NULL,
    tarjeta      BIGINT NOT NULL,
    saldo        FLOAT NOT NULL,
    correo NVARCHAR(50) NOT NULL
);

CREATE TABLE administrador (
	id_adm NVARCHAR(20) NOT NULL,
	password NVARCHAR(20) NOT NULL,
	nombre NVARCHAR(20) NOT NULL,
	rol NVARCHAR(20) NOT NULL
);

ALTER TABLE administrador ADD CONSTRAINT adm_pk PRIMARY KEY ( id_adm );

ALTER TABLE usuario ADD CONSTRAINT user_pk PRIMARY KEY ( id_persona );

CREATE TABLE boleta(
	id_boleta INT IDENTITY(1,1),
	fecha Date NOT NULL,
	id_personaF NVARCHAR(20) NOT NULL,
	id_biciF NVARCHAR(15) NOT NULL,
	id_recorridoF INT NOT NULL
);

ALTER TABLE boleta ADD CONSTRAINT boleta_pk PRIMARY KEY (id_boleta);

ALTER TABLE boleta
	ADD CONSTRAINT boleta_per_fk FOREIGN KEY ( id_personaF )
		REFERENCES usuario ( id_persona);

ALTER TABLE boleta
	ADD CONSTRAINT boleta_bici_fk FOREIGN KEY ( id_biciF )
		REFERENCES bicicleta ( id_bici );

ALTER TABLE boleta
	ADD CONSTRAINT boleta_reco_fk FOREIGN KEY ( id_recorridoF)
		REFERENCES recorrido (id_recorrido);


ALTER TABLE bicicleta
    ADD CONSTRAINT bici_est_fk FOREIGN KEY ( id_estF )
        REFERENCES estacionamiento ( id_est );

ALTER TABLE estacionamiento
    ADD CONSTRAINT est_comu_fk FOREIGN KEY ( id_comuF )
        REFERENCES comuna ( id_comu );

ALTER TABLE recorrido
    ADD CONSTRAINT reco_bici_fk FOREIGN KEY ( id_biciF )
        REFERENCES bicicleta ( id_bici );

ALTER TABLE recorrido
    ADD CONSTRAINT reco_per_fk FOREIGN KEY ( id_personaF )
        REFERENCES usuario ( id_persona );

--Comuna(s)
INSERT INTO comuna VALUES(1,'La Reina');
--Estacionamientos
INSERT INTO estacionamiento VALUES(1,'estacionamiento1','direccion#001',90,1)
INSERT INTO estacionamiento VALUES(2,'estacionamiento2','direccion#002',90,1)
INSERT INTO estacionamiento VALUES(3,'estacionamiento3','direccion#003',90,1)
INSERT INTO estacionamiento VALUES(4,'estacionamiento4','direccion#004',90,1)
--Bicicletas
--1
INSERT INTO bicicleta VALUES('T8KY','lugar#001','Disponible',1)
INSERT INTO bicicleta VALUES('714D','lugar#002','Disponible',1)
INSERT INTO bicicleta VALUES('G0QA','lugar#003','Disponible',1)
INSERT INTO bicicleta VALUES('RJDO','lugar#004','Disponible',1)
--2
INSERT INTO bicicleta VALUES('J4XJ','lugar#001','Disponible',2)
INSERT INTO bicicleta VALUES('3T5Q','lugar#002','Disponible',2)
INSERT INTO bicicleta VALUES('VAMQ','lugar#003','Disponible',2)
INSERT INTO bicicleta VALUES('28GV','lugar#004','Disponible',2)
--3
INSERT INTO bicicleta VALUES('N27Y','lugar#001','Disponible',3)
INSERT INTO bicicleta VALUES('3HTQ','lugar#002','Disponible',3)
INSERT INTO bicicleta VALUES('75UQ','lugar#003','Disponible',3)
INSERT INTO bicicleta VALUES('E2O5','lugar#004','Disponible',3)
--4
INSERT INTO bicicleta VALUES('8AEB','lugar#001','Disponible',4)
INSERT INTO bicicleta VALUES('9NGN','lugar#002','Disponible',4)
INSERT INTO bicicleta VALUES('EHHZ','lugar#003','Disponible',4)
INSERT INTO bicicleta VALUES('M61I','lugar#004','Disponible',4)

SELECT * FROM estacionamiento;
SELECT * FROM bicicleta;

