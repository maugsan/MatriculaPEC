

-- Eliminar Alumno ---------------------------------------------------------------
IF ( OBJECT_ID('eliminar_alumno') IS NOT NULL ) 
   DROP PROCEDURE eliminar_alumno
GO

CREATE PROCEDURE eliminar_alumno
       @cedula   INT         
                     
AS 

DECLARE 
@cod int 

BEGIN 
    
     SET NOCOUNT ON 
     SET @cod = (select m.cod_matricula from matriculas m inner join alumnos a on  a.cod_alumno =  m.cod_alumno where a.cedula =  @cedula)

IF  ISNUMERIC(@cod)<> 1

BEGIN
 DELETE FROM alumnos WHERE (cedula =  @cedula) 
END

END 



