insert into tipo_venta values(1,'Aplicaciones');
insert into tipo_venta values(2,'Aplicacion Primium');
insert into tipo_venta values(3,'Mantenimiento Aplicacion ');
insert into tipo_venta values(4,' Ventas al estado');


select * from cliente;

insert into cliente values(1,'Gobierno','Mario Castillo',12345678,'Guatemala','gobierno.go@gmail.com');
insert into cliente values(2,'Emetra','Jose Gonzales',23465756,'Villa Nueva','gobierno.go@gmail.com');
insert into cliente values(3,'Mayans Cargo','Edwar Merida',918374756,'Chimaltenago','gobierno.go@gmail.com');
insert into cliente values(4,'Transjosa','Daniel Garcia',24564545,'San Marcos','gobierno.go@gmail.com');
insert into cliente values(5,'Tacsa','Estuardo Perez',54789766,'Peten','gobierno.go@gmail.com');
insert into cliente values(6,'Servitransportes','Francisco Gonzales',45456789,'Guatemala','gobierno.go@gmail.com');
insert into cliente values(7,'Logistica Global','Pedro Juarez',67676789,'Villa Nueva','gobierno.go@gmail.com');
insert into cliente values(8,'Cargo SA','Mario Salazar',66775456,'Guatemala','gobierno.go@gmail.com');


select * from venta;

insert into venta values(1,'Venta de aplicacion',1540.50,12,'21/12/2019',1,1);
insert into venta values(2,'Venta de aplicacion primium',1540.50,12,'21/12/2019',2,2);
insert into venta values(3,'Venta de aplicacion primium',1540.50,12,'21/12/2019',2,2);
insert into venta values(4,'Mantenimiento de aplicacion',1540.50,12,'21/12/2019',3,3);
insert into venta values(5,'Mantenimiento de aplicacion',1540.50,12,'21/12/2019',3,4);
insert into venta values(6,'Venta de aplicacion primium',1540.50,12,'21/12/2019',5,2);
insert into venta values(7,'Ventas al estado',1540.50,12,'21/12/2019',6,4);
insert into venta values(8,'Venta de aplicacion',1540.50,12,'21/12/2019',6,1);




select * from Cuentav1;

insert into Cuentav1 values (1,'Equipo de computacion','Compra en toda la teconologia')
insert into Cuentav1 values (2,'Insumos de oficina','Utilizados para el consumo de oficina')
insert into Cuentav1 values (3,'Viaticos','Utilizado para cubrir gasto de vendedores y demas')
insert into Cuentav1 values (4,'Mobiliario y equipo','Utilizado para la compras de muebles')
select * from compra;

insert into compra values(1,2000.10,'Compra de licencias de antivirus','21/12/2019',12,1);
insert into compra values(2,10000,'Compra de Servidores','21/12/2019',12,1);
insert into compra values(3,120,'Compra de papel','21/10/2019',10,2);
insert into compra values(4,100,'Compra de engrapadoras','21/12/2019',8,2);
insert into compra values(5,400,'Compra de teclados','21/12/2019',7,1);
insert into compra values(6,50,'Compra desayuno','21/12/2019',12,3);
insert into compra values(7,100,'Pago de gasolina','21/12/2019',12,3);
insert into compra values(8,250,'Compra de monitores','21/12/2019',10,2);
insert into compra values(9,600,'Compra de escritorio','21/12/2019',10,4);
insert into compra values(10,500,'Compra de escritorio','21/12/2019',11,4);