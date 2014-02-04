

-- Insertar Alumno ---------------------------------------------------------------
IF ( OBJECT_ID('insertar_alumno') IS NOT NULL ) 
   DROP PROCEDURE insertar_alumno
GO

CREATE PROCEDURE insertar_alumno
       @cedula                    INT           , 
       @nombre                    nchar(100)    , 
       @apellido1                 nchar(100)    , 
       @apellido2                 nchar(100)    , 
       @responsable               nchar(100)    , 
       @telefono_responsable      INT   = NULL  , 
       @telefono                  INT   = NULL  ,
       @email nchar(100)
                       
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
     @nombre nchar(100),
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
     @nombre nchar(100)
	
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
     @nombre nchar(100),
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



-- Insertar Forma de pago ---------------------------------------------------------------


IF ( OBJECT_ID('insertar_formadepago') IS NOT NULL ) 
   DROP PROCEDURE insertar_formadepago
GO

CREATE PROCEDURE insertar_formadepago
     @nombre nchar(100)
	
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
     @nombre nchar(100)
	
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
     @nombre nchar(100),
	 @apellido1 nchar(100),
	 @apellido2 nchar(100),
	 @telefono int,
	 @correo nchar(100)
	
AS 
	
BEGIN 
     SET NOCOUNT ON 

     INSERT INTO profesores
     ( 
		 nombre,
		 apellido1 ,
		 apellido2 ,
		 telefono ,
		 correo 
	 )      
                
          
     VALUES 
          ( 
           
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


-- Insertar Matricula ---------------------------------------------------------------


IF ( OBJECT_ID('insertar_matricula') IS NOT NULL ) 
   DROP PROCEDURE insertar_matricula
GO

CREATE PROCEDURE insertar_matricula
 @cod_grupo int,
 @cod_alumno int
	 
	
AS 
	
BEGIN 
     SET NOCOUNT ON 

     INSERT INTO matriculas
        ( 
		 cod_grupo ,
		 fecha,
	     cod_alumno 
	 )      
                
          
     VALUES 
          ( 
         @cod_grupo ,
         GETDATE(),
	     @cod_alumno 
	 
			
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
	 @numero_recibo int,
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
	 numero_recibo ,
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
	 @numero_recibo ,
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
	 @cod_mediopago int 

	 
	
AS 
	
	
BEGIN 
     SET NOCOUNT ON 

     INSERT INTO pagos
     ( 
	 cod_factura ,
	 fecha,
	 monto ,
	 cod_mediopago 

	 )                    
     VALUES 
     ( 
     @cod_factura ,
	 GETDATE(),
	 @monto ,
	 @cod_mediopago 
			
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

select * from facturas

select * from medios_de_pago

select * from pagos

select * from alumnos_en_grupos