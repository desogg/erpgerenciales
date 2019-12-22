create database Proyecto_gerenciales;
drop database Proyecto_gerenciales;
use Proyecto_gerenciales;

CREATE TABLE cliente (
    codigo             INTEGER NOT NULL,
    nombre_entidad     VARCHAR(50),
    nombre_encargado   VARCHAR(50),
    telefono           INTEGER,
    direccion          VARCHAR(50),
    email              VARCHAR(50)
)



ALTER TABLE Cliente ADD constraint cliente_pk PRIMARY KEY CLUSTERED (Codigo)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 

CREATE TABLE compra (
    codigo_compra            INTEGER NOT NULL,
    costo                    FLOAT,
    descripcion              VARCHAR(50),
    fecha                    VARCHAR(50),
    mes                      INTEGER,
    cuentav1_codigo_cuenta   INTEGER NOT NULL
)



ALTER TABLE Compra ADD constraint compra_pk PRIMARY KEY CLUSTERED (Codigo_compra)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 

CREATE TABLE consulta (
    codigo_consulta   INTEGER NOT NULL,
    descripcion       VARCHAR(50),
    estado            INTEGER,
    cliente_codigo    INTEGER NOT NULL
)



ALTER TABLE Consulta ADD constraint consulta_pk PRIMARY KEY CLUSTERED (Codigo_consulta)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 

CREATE TABLE cuentav1 (
    codigo_cuenta   INTEGER NOT NULL,
    nombre          VARCHAR(50),
    descripcion     VARCHAR(50)
)



ALTER TABLE Cuentav1 ADD constraint cuentav1_pk PRIMARY KEY CLUSTERED (Codigo_cuenta)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 

CREATE TABLE tipo_venta (
    codigo_venta   INTEGER NOT NULL,
    descripcion    VARCHAR(50)
)



ALTER TABLE Tipo_venta ADD constraint tipo_venta_pk PRIMARY KEY CLUSTERED (Codigo_venta)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 

CREATE TABLE venta (
    codigo_venta              INTEGER NOT NULL,
    descripcion               VARCHAR(50),
    precio                    INTEGER,
    mes                       INTEGER,
    fecha                     VARCHAR(50),
    cliente_codigo            INTEGER NOT NULL,
    tipo_venta_codigo_venta   INTEGER NOT NULL
)



ALTER TABLE Venta ADD constraint venta_pk PRIMARY KEY CLUSTERED (Codigo_venta)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON )

ALTER TABLE Compra
    ADD CONSTRAINT compra_cuentav1_fk FOREIGN KEY ( cuentav1_codigo_cuenta )
        REFERENCES cuentav1 ( codigo_cuenta )
ON DELETE NO ACTION 
    ON UPDATE no action 

ALTER TABLE Consulta
    ADD CONSTRAINT consulta_cliente_fk FOREIGN KEY ( cliente_codigo )
        REFERENCES cliente ( codigo )
ON DELETE NO ACTION 
    ON UPDATE no action 

ALTER TABLE Venta
    ADD CONSTRAINT venta_cliente_fk FOREIGN KEY ( cliente_codigo )
        REFERENCES cliente ( codigo )
ON DELETE NO ACTION 
    ON UPDATE no action 

ALTER TABLE Venta
    ADD CONSTRAINT venta_tipo_venta_fk FOREIGN KEY ( tipo_venta_codigo_venta )
        REFERENCES tipo_venta ( codigo_venta )
ON DELETE NO ACTION 
    ON UPDATE no action 

