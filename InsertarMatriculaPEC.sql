use MatriculaPEC
-- Insertar Alumno ---------------------------------------------------------------
IF ( OBJECT_ID('insertar_alumno') IS NOT NULL ) 
DROP PROCEDURE insertar_alumno
GO

CREATE PROCEDURE insertar_alumno
@cedula                    bigint           , 
@nombre                    nvarchar(50)    , 
@apellido1                 nvarchar (50)   , 
@apellido2                 nvarchar(50)    , 
@responsable               nvarchar(50)    , 
@telefono_responsable      INT , 
@telefono                  INT ,
@email  nvarchar(100)

AS 
BEGIN 
SET NOCOUNT ON 

INSERT INTO alumnos
( 
cedula                  ,
nombre                  ,
apellido1               ,
apellido2               ,
responsable             ,
telefono_responsable    ,
telefono ,
email                  
) 
VALUES 
( 

@cedula                  ,
@nombre                  ,
@apellido1               ,
@apellido2               ,
@responsable             ,
@telefono_responsable    ,
@telefono ,
@email                  
) 

END 











-- Insertar Curso ---------------------------------------------------------------


IF ( OBJECT_ID('insertar_curso') IS NOT NULL ) 
DROP PROCEDURE insertar_curso
GO

CREATE PROCEDURE insertar_curso
@nombre nvarchar(50),
@duracion int,
@descripcion ntext,
@costo money

AS 

BEGIN 
SET NOCOUNT ON 

INSERT INTO cursos
( 
nombre    ,
duracion     ,
descripcion  ,
costo               

) 
VALUES 
( 

@nombre ,
@duracion ,
@descripcion ,
@costo           
) 

END 




-- Insertar Periodo ---------------------------------------------------------------


IF ( OBJECT_ID('insertar_periodo') IS NOT NULL ) 
DROP PROCEDURE insertar_periodo
GO

CREATE PROCEDURE insertar_periodo
@nombre nvarchar(50)

AS 

BEGIN 
SET NOCOUNT ON 

INSERT INTO periodos
( 
nombre         

) 
VALUES 
( 

@nombre      
) 

END 



-- Insertar Descuentos ---------------------------------------------------------------


IF ( OBJECT_ID('insertar_descuento') IS NOT NULL ) 
DROP PROCEDURE insertar_descuento
GO

CREATE PROCEDURE insertar_descuento
@nombre nvarchar(50),
@porcentaje int

AS 

BEGIN 
SET NOCOUNT ON 

INSERT INTO descuentos
( 
nombre,
porcentaje             
) 
VALUES 
( 
@nombre,
@porcentaje     
) 

END 

-- Insertar usuarios ---------------------------------------------------------------


IF ( OBJECT_ID('insertar_usuario') IS NOT NULL ) 
DROP PROCEDURE insertar_usuario
GO

CREATE PROCEDURE insertar_usuario
@nombre_usuario nvarchar(50),
@nombre nvarchar(50),
@apellido nvarchar(50),
@clave nvarchar(50),
@rol int

AS 

BEGIN 
SET NOCOUNT ON 

INSERT INTO usuarios
( 
nombre_usuario ,
nombre ,
apellido,
clave ,
rol    
  
) 
VALUES 
( 
@nombre_usuario,
@nombre,
@apellido,
@clave,
@rol 
) 

END 




-- Insertar Forma de pago ---------------------------------------------------------------


IF ( OBJECT_ID('insertar_formadepago') IS NOT NULL ) 
DROP PROCEDURE insertar_formadepago
GO

CREATE PROCEDURE insertar_formadepago
@nombre nvarchar(50)

AS 

BEGIN 
SET NOCOUNT ON 

INSERT INTO formas_de_pago
( 
nombre         

) 
VALUES 
( 

@nombre      
) 

END 


-- Insertar Medio de pago ---------------------------------------------------------------


IF ( OBJECT_ID('insertar_mediodepago') IS NOT NULL ) 
DROP PROCEDURE insertar_mediodepago
GO

CREATE PROCEDURE insertar_mediodepago
@nombre nvarchar(50)

AS 

BEGIN 
SET NOCOUNT ON 

INSERT INTO medios_de_pago
( 
nombre         

) 
VALUES 
( 

@nombre      
) 

END 







-- Insertar Profesor ---------------------------------------------------------------

IF ( OBJECT_ID('insertar_profesor') IS NOT NULL ) 
DROP PROCEDURE insertar_profesor
GO

CREATE PROCEDURE insertar_profesor
@cedula bigint,
@nombre nvarchar(50),
@apellido1 nvarchar(50),
@apellido2 nvarchar(50),
@telefono int,
@correo nvarchar(50)

AS 

BEGIN 
SET NOCOUNT ON 

INSERT INTO profesores
( 
cedula,
nombre,
apellido1 ,
apellido2 ,
telefono ,
correo 
)      


VALUES 
( 
@cedula,
@nombre,
@apellido1 ,
@apellido2 ,
@telefono ,
@correo      
) 

END 


-- Insertar Grupo ---------------------------------------------------------------


IF ( OBJECT_ID('insertar_grupo') IS NOT NULL ) 
DROP PROCEDURE insertar_grupo
GO

CREATE PROCEDURE insertar_grupo
@cod_curso int,
@numero int,
@cod_periodo int,
@cod_profesor int


AS 

BEGIN 
SET NOCOUNT ON 

INSERT INTO grupos
( 
cod_curso ,
numero ,
cod_periodo,
cod_profesor
)      


VALUES 
( 
@cod_curso ,
@numero ,
@cod_periodo,
@cod_profesor
) 

END 


-- Insertar Horarios ---------------------------------------------------------------


IF ( OBJECT_ID('insertar_horarios') IS NOT NULL ) 
DROP PROCEDURE insertar_horarios
GO

CREATE PROCEDURE insertar_horarios
@dia nvarchar(2),
@horaInicio int,
@minutosInicio int,
@horaSalida int,
@minutosSalida int

AS 

BEGIN 
SET NOCOUNT ON 

INSERT INTO horarios
( 
horaInicio ,
minutosInicio ,
horaSalida ,
minutosSalida 
)      


VALUES (
@horaInicio ,
@minutosInicio ,
@horaSalida,
@minutosSalida 
) 

END 









-- Insertar Horario en grupo ---------------------------------------------------------------

IF ( OBJECT_ID('insertar_horario_en_grupo') IS NOT NULL ) 
DROP PROCEDURE insertar_horario_en_grupo
GO

CREATE PROCEDURE insertar_horario_en_grupo
@cod_horario int,
@cod_grupo int



AS 

BEGIN 
SET NOCOUNT ON 

INSERT INTO horario_en_grupo
( 
cod_horario ,
cod_grupo
)      


VALUES 
( 
@cod_horario ,
@cod_grupo
) 

END 









-- Insertar Matricula ---------------------------------------------------------------


IF ( OBJECT_ID('insertar_matricula') IS NOT NULL ) 
DROP PROCEDURE insertar_matricula
GO

CREATE PROCEDURE insertar_matricula
@cod_grupo int,
@cod_alumno int,
@cod_usuario int


AS 

BEGIN 
SET NOCOUNT ON 

INSERT INTO matriculas
( 
cod_grupo ,
fecha,
cod_alumno,
cod_usuario 
)      


VALUES 
( 
@cod_grupo ,
GETDATE(),
@cod_alumno,
@cod_usuario 


) 

INSERT INTO alumnos_en_grupos
( 
cod_grupo,
cod_alumno 
)      


VALUES 
( 
@cod_grupo ,
@cod_alumno 

) 



END 









-- Insertar Factura ---------------------------------------------------------------


IF ( OBJECT_ID('insertar_factura') IS NOT NULL ) 
DROP PROCEDURE insertar_factura
GO

CREATE PROCEDURE insertar_factura
@cod_alumno int,
@cod_matricula int,
@cod_descuento int,
@cod_formapago int,
@total int,
@sub_total int ,
@saldo_pendiente int

AS 

BEGIN 
SET NOCOUNT ON 

INSERT INTO facturas
( 
cod_alumno ,
cod_matricula ,
sub_total,
cod_descuento,
total,
saldo_pendiente,
cod_formapago

)      



VALUES 
( 
@cod_alumno ,
@cod_matricula ,
@sub_total,
@cod_descuento,
@total,
@saldo_pendiente,
@cod_formapago

) 
END 



-- Insertar Pago ---------------------------------------------------------------


IF ( OBJECT_ID('insertar_pago') IS NOT NULL ) 
DROP PROCEDURE insertar_pago
GO

CREATE PROCEDURE insertar_pago
@cod_factura int,
@monto money,
@cod_mediopago int,
@cod_usuario int  




AS 


BEGIN 
SET NOCOUNT ON 

INSERT INTO pagos
( 
cod_factura ,
fecha,
monto ,
cod_mediopago ,
cod_usuario

)                    
VALUES 
( 
@cod_factura ,
GETDATE(),
@monto ,
@cod_mediopago ,
@cod_usuario


) 

UPDATE Facturas SET saldo_pendiente = saldo_pendiente - @monto WHERE cod_factura = @cod_factura
END 



















-------------------------------------------------------------------------------
--INSERTAR 
-------------------------------------------------------------------------------

EXEC insertar_alumno 206850055, 'Mauricio', 'Sanchez', 'Ureña', null, null, 27632628, 'maugsan@gmail.com'

EXEC insertar_curso 'Ingles 1', 40, 'Es un curso muy basico' , 50000

EXEC insertar_periodo 'I-2014'

EXEC insertar_profesor 'Juanito', 'Salazar', 'Rojas', 27100000, 'juanito@gmail.com'

EXEC insertar_grupo 1, 1, 1, 1

EXEC insertar_formadepago '2 Pagos'

EXEC insertar_mediodepago 'Contado'

EXEC insertar_matricula 1, 1

EXEC insertar_descuento 'viernes negro', 30

EXEC insertar_factura 1, 2, 252054, 1, 1

EXEC insertar_pago 2, 5000, 1




-------------------------------------------------------------------------------
-- BUSCAR 
-------------------------------------------------------------------------------


select nombre from matriculas m 
inner join grupos g on m.cod_grupo = g.cod_grupo 
inner join cursos c on g.cod_curso = c.cod_curso where m.cod_alumno = 1

select nombre from grupos g 
inner join cursos c on g.cod_curso = c.cod_curso

select * from alumnos

select * from cursos

select * from periodos

select * from profesores

select * from grupos

select * from matriculas

select * from descuentos

delete from descuentos where cod_descuento = 2

select * from facturas

select * from medios_de_pago

select * from pagos

select * from alumnos_en_grupos