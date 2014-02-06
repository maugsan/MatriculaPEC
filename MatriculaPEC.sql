
IF ( OBJECT_ID('MatriculaPEC') IS NOT NULL ) 
   drop database MatriculaPEC
GO


create database MatriculaPEC

use MatriculaPEC


create table periodos (

	 cod_periodo int IDENTITY(1,1) primary key,
	 nombre nvarchar(50) NOT NULL

)

create table profesores (

	 cod_profesor int IDENTITY(1,1) primary key,
	 cedula bigint unique NOT NULL,
	 nombre nvarchar(50) NOT NULL,
	 apellido1 nvarchar(50),
	 apellido2 nvarchar(50),
	 telefono int  NOT NULL,
	 correo nvarchar(50)

)

create table cursos (
	
	 cod_curso int IDENTITY(1,1) primary key,
	 nombre nvarchar(50) NOT NULL,
	 duracion int,
	 descripcion ntext,
	 costo money  NOT NULL
	
)


create table grupos (

	 cod_grupo int IDENTITY(1,1) primary key,
	 cod_curso int  NOT NULL,
	 numero int  NOT NULL,
	 cod_periodo int  NOT NULL,
	 cod_profesor int,
	 foreign key (cod_profesor) references profesores(cod_profesor),
	 foreign key (cod_curso) references cursos(cod_curso),
	 foreign key (cod_periodo) references periodos(cod_periodo)
	 

)

create table horarios (

	 cod_horario int IDENTITY(1,1) primary key,
	 dia nvarchar(2)  NOT NULL,
	 horaInicio int  NOT NULL,
	 minutosInicio int  NOT NULL,
	 	 horaSalida int  NOT NULL,
	 minutosSalida int  NOT NULL

)

create table horario_en_grupo (

	 cod_horarioengrupo int IDENTITY(1,1) primary key,
	 cod_horario int  NOT NULL,
	 cod_grupo int  NOT NULL,
	 foreign key (cod_horario) references horarios(cod_horario),
	 foreign key (cod_grupo) references grupos(cod_grupo)
	
	 

)

create table alumnos (

	 cod_alumno int IDENTITY(1,1) primary key,
	 cedula bigint unique NOT NULL,
	 nombre nvarchar(50)  NOT NULL,
	 apellido1 nvarchar(50),
	 apellido2 nvarchar(50),
	 responsable nvarchar(50),
	 telefono_responsable int,
	 telefono int  NOT NULL,
	 email nvarchar(50),
	
)

create table descuentos (
	cod_descuento int  IDENTITY(1,1) primary key,
	nombre nvarchar(50)  NOT NULL,
	porcentaje int  NOT NULL


)
create table usuarios (

	 cod_usuario int IDENTITY(1,1) primary key,
	 nombre_usuario nvarchar(50),
	 nombre nvarchar(50),
	 apellido nvarchar(50),
     clave nvarchar(50),
     rol int

)


create table matriculas (

		cod_matricula int IDENTITY(1,1) primary key,
		cod_grupo int  NOT NULL,
		cod_alumno int  NOT NULL,
		fecha date,
		cod_usuario int ,
		foreign key (cod_usuario) references usuarios(cod_usuario),
		foreign key (cod_grupo) references grupos(cod_grupo),
		foreign key (cod_alumno) references alumnos(cod_alumno)

)

create table medios_de_pago (

	 cod_mediopago int IDENTITY(1,1) primary key,
	 nombre nvarchar(50)  NOT NULL

)

create table formas_de_pago (

	 cod_formapago int IDENTITY(1,1) primary key,
	 nombre nvarchar(50)  NOT NULL
	
)

create table facturas (

	 cod_factura int IDENTITY(1,1) primary key,
	 cod_alumno int,
	 cod_matricula int,
	 sub_total money,
	 cod_descuento int,
	 total money,
	 saldo_pendiente money,
	 cod_formapago int,
	 foreign key (cod_alumno) references alumnos(cod_alumno),
	 foreign key ( cod_matricula ) references matriculas ( cod_matricula),
	 foreign key ( cod_formapago ) references formas_de_pago(cod_formapago),
	 foreign key ( cod_descuento ) references descuentos(cod_descuento)

)


create table pagos (

	 cod_pagos int  IDENTITY(1,1) primary key,
	 cod_factura int,
	 numero_recibo bigint,
	 fecha date,
	 monto money  NOT NULL,
	 cod_mediopago int ,
	 cod_usuario int ,
	 foreign key (cod_usuario) references usuarios(cod_usuario),
	 foreign key (cod_factura) references facturas(cod_factura),
	 foreign key (cod_mediopago) references medios_de_pago(cod_mediopago)

)


create table alumnos_en_grupos (

	 cod_alumnoengrupo int IDENTITY(1,1) primary key,
	 cod_grupo int,
     cod_alumno int,
     nota int,
     estado nvarchar,
	 foreign key (cod_grupo) references grupos(cod_grupo),
	 foreign key (cod_alumno) references alumnos(cod_alumno)
	 

)

select * from cursos




