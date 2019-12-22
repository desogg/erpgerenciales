insert into tipo_venta values('Aplicaciones');
insert into tipo_venta values('Aplicacion Primium');
insert into tipo_venta values('Mantenimiento Aplicacion ');
insert into tipo_venta values(' Ventas al estado');


select * from cliente;

insert into cliente values('Gobierno','Mario Castillo',12345678,'Guatemala','gobierno.go@gmail.com');
insert into cliente values('Emetra','Jose Gonzales',23465756,'Villa Nueva','gobierno.go@gmail.com');
insert into cliente values('Mayans Cargo','Edwar Merida',918374756,'Chimaltenago','gobierno.go@gmail.com');
insert into cliente values('Transjosa','Daniel Garcia',24564545,'San Marcos','gobierno.go@gmail.com');
insert into cliente values('Tacsa','Estuardo Perez',54789766,'Peten','gobierno.go@gmail.com');
insert into cliente values('Servitransportes','Francisco Gonzales',45456789,'Guatemala','gobierno.go@gmail.com');
insert into cliente values('Logistica Global','Pedro Juarez',67676789,'Villa Nueva','gobierno.go@gmail.com');
insert into cliente values('Cargo SA','Mario Salazar',66775456,'Guatemala','gobierno.go@gmail.com');


select * from venta;

insert into venta values('Venta de aplicacion',1540.50,12,'21/12/2019',1,1);
insert into venta values('Venta de aplicacion primium',1540.50,12,'21/12/2019',2,2);
insert into venta values('Venta de aplicacion primium',1540.50,12,'21/12/2019',2,2);
insert into venta values('Mantenimiento de aplicacion',1540.50,12,'21/12/2019',3,3);
insert into venta values('Mantenimiento de aplicacion',1540.50,12,'21/12/2019',3,4);
insert into venta values('Venta de aplicacion primium',1540.50,12,'21/12/2019',5,2);
insert into venta values('Ventas al estado',1540.50,12,'21/12/2019',6,4);
insert into venta values('Venta de aplicacion',1540.50,12,'21/12/2019',6,1);




select * from Cuentav1;

insert into Cuentav1 values ('Equipo de computacion','Compra en toda la teconologia')
insert into Cuentav1 values ('Insumos de oficina','Utilizados para el consumo de oficina')
insert into Cuentav1 values ('Viaticos','Utilizado para cubrir gasto de vendedores y demas')
insert into Cuentav1 values ('Mobiliario y equipo','Utilizado para la compras de muebles')
select * from compra;

insert into compra values(2000.10,'Compra de licencias de antivirus','21/12/2019',12,1);
insert into compra values(10000,'Compra de Servidores','21/12/2019',12,1);
insert into compra values(120,'Compra de papel','21/10/2019',10,2);
insert into compra values(100,'Compra de engrapadoras','21/12/2019',8,2);
insert into compra values(400,'Compra de teclados','21/12/2019',7,1);
insert into compra values(50,'Compra desayuno','21/12/2019',12,3);
insert into compra values(100,'Pago de gasolina','21/12/2019',12,3);
insert into compra values(250,'Compra de monitores','21/12/2019',10,2);
insert into compra values(600,'Compra de escritorio','21/12/2019',10,4);
insert into compra values(500,'Compra de escritorio','21/12/2019',11,4);