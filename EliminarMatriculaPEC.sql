
use MatriculaPEC
-- Eliminar Alumno ---------------------------------------------------------------
IF ( OBJECT_ID('eliminar_alumno') IS NOT NULL ) 
   DROP PROCEDURE eliminar_alumno
GO

CREATE PROCEDURE eliminar_alumno
       @cedula   bigint         
                     
AS 

DECLARE 
@cod int 

BEGIN 
    
     SET NOCOUNT ON 
     SET @cod = (select m.cod_matricula from matriculas m
      inner join alumnos a on  a.cod_alumno =  m.cod_alumno where a.cedula =  @cedula)

IF  ISNUMERIC(@cod)<> 1

BEGIN
 DELETE FROM alumnos WHERE (cedula =  @cedula) 
END

END 




-- Eliminar Matricula ---------------------------------------------------------------
IF ( OBJECT_ID('eliminar_matricula') IS NOT NULL ) 
   DROP PROCEDURE eliminar_matricula
GO

CREATE PROCEDURE eliminar_matricula
       @cod_grupo   int,
        @cod_alumno   int            
                     
AS 

DECLARE 
@cod int 

BEGIN 
 
SET @cod = (select m.cod_matricula from matriculas m
where m.cod_grupo =   @cod_grupo and  m.cod_alumno =   @cod_alumno)
 DELETE FROM facturas WHERE cod_matricula =  @cod   
 DELETE FROM matriculas WHERE cod_grupo =  @cod_grupo and cod_alumno  = @cod_alumno 
 DELETE FROM alumnos_en_grupos WHERE cod_grupo =  @cod_grupo and cod_alumno  = @cod_alumno   


END 


