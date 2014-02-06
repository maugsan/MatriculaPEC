use MatriculaPEC

-- Consultar cedula profesor por Nombre y apellidos ---------------------------------------------------------------
IF ( OBJECT_ID('consultar_ced_profesor') IS NOT NULL ) 
   DROP PROCEDURE consultar_ced_profesor
GO

CREATE PROCEDURE consultar_ced_profesor
       @nombre nvarchar(50)  
                     
AS 

DECLARE 
@cod int 

BEGIN 
    
    SET NOCOUNT ON 
SELECT  cod_profesor as Codigo, 
REPLACE(nombre, ' ', '') + ' ' + REPLACE(apellido1, ' ', '') + ' ' + REPLACE(apellido2, ' ', '') AS Profesor,
telefono AS Telefono,
correo AS Correo
FROM  profesores
where REPLACE(nombre, ' ', '') + ' ' + REPLACE(apellido1, ' ', '') + ' ' + REPLACE(apellido2, ' ', '') = @nombre


END 


-- Consultar Grupo por codigo  y numero ---------------------------------------------------------------
IF ( OBJECT_ID('consultarGrupo') IS NOT NULL ) 
   DROP PROCEDURE consultarGrupo
GO

CREATE PROCEDURE consultarGrupo
       @cod_curso INT,
       @numero int      
                     
AS 

DECLARE 
@cod int 

BEGIN 
    
    SET NOCOUNT ON 
	
	g.cod_grupo
	
	FROM            grupos AS g 
	INNER JOIN
	cursos AS c ON g.cod_curso = c.cod_curso 
	INNER JOIN
	profesores AS p ON g.cod_profesor = p.cod_profesor 
	INNER JOIN
	periodos AS pe ON g.cod_periodo = pe.cod_periodo
	WHERE g.cod_curso = @cod_curso AND g.numero = @numero

    

END 




-- Consultar codigo Grupo  ---------------------------------------------------------------
IF ( OBJECT_ID('consultar_cod_grupo') IS NOT NULL ) 
   DROP PROCEDURE consultar_cod_grupo
GO

CREATE PROCEDURE consultar_cod_grupo
       @valor nvarchar(50)
                     
AS 


BEGIN 
    
    SET NOCOUNT ON 
    SELECT g.cod_grupo
	FROM     grupos AS g 
	INNER JOIN
	cursos AS c ON g.cod_curso = c.cod_curso 
	INNER JOIN
	profesores AS p ON g.cod_profesor = p.cod_profesor 
	INNER JOIN
	periodos AS pe ON g.cod_periodo = pe.cod_periodo
	WHERE  'G' +  g.numero + c.nombre  = @valor
    

END 


-- Consultar codigo periodo ---------------------------------------------------------------
IF ( OBJECT_ID('consultar_cod_periodo') IS NOT NULL ) 
   DROP PROCEDURE consultar_cod_periodo
GO

CREATE PROCEDURE consultar_cod_periodo
       @nombre nvarchar(50)
     
                     
AS 


BEGIN 
    
    SET NOCOUNT ON 
	SELECT cod_periodo FROM dbo.periodos
	WHERE nombre = @nombre

    

END 





-- Consultar codigo estudiante ---------------------------------------------------------------
IF ( OBJECT_ID('consultar_cod_estudiante') IS NOT NULL ) 
   DROP PROCEDURE consultar_cod_estudiante
GO

CREATE PROCEDURE consultar_cod_estudiante
       @cedula bigint
          
AS 


BEGIN 
    
    SET NOCOUNT ON 
	SELECT cod_alumno FROM dbo.alumnos
	WHERE cedula = @cedula

    

END 







-- Consultar codigo profesor ---------------------------------------------------------------
IF ( OBJECT_ID('consultar_cod_profesor') IS NOT NULL ) 
   DROP PROCEDURE consultar_cod_profesor
GO

CREATE PROCEDURE consultar_cod_profesor
       @cedula bigint
     
                     
AS 


BEGIN 
    
    SET NOCOUNT ON 
	SELECT cod_profesor FROM dbo.profesores
	WHERE cedula = @cedula

    

END 





-- Consultar codigo matricula ---------------------------------------------------------------
IF ( OBJECT_ID('consultar_cod_matricula') IS NOT NULL ) 
   DROP PROCEDURE consultar_cod_matricula
GO

CREATE PROCEDURE consultar_cod_matricula
       @cod_grupo int,
         @cod_alumno  int
     
                     
AS 


BEGIN 
    
    SET NOCOUNT ON 
	SELECT cod_matricula FROM dbo.matriculas
	WHERE  cod_grupo = @cod_grupo and  cod_alumno = @cod_alumno


    

END 





-- Consultar codigo Curso ---------------------------------------------------------------
IF ( OBJECT_ID('consultar_cod_curso') IS NOT NULL ) 
   DROP PROCEDURE consultar_cod_curso
GO

CREATE PROCEDURE consultar_cod_curso
       @nombre varchar(50)
     
                     
AS 


BEGIN 
    
    SET NOCOUNT ON 
	SELECT cod_curso FROM dbo.cursos
	WHERE nombre = @nombre

    

END 





-- Consultar Costo Curso ---------------------------------------------------------------
IF ( OBJECT_ID('consultar_costo_curso') IS NOT NULL ) 
   DROP PROCEDURE consultar_costo_curso
GO

CREATE PROCEDURE consultar_costo_curso
       @cod_curso int
     
                     
AS 


BEGIN 
    
    SET NOCOUNT ON 
	SELECT c.costo 
	FROM dbo.cursos c INNER JOIN
	 dbo.grupos g on c.cod_curso = g.cod_curso
	WHERE g.cod_grupo = @cod_curso
	
END 






-- Consultar Costo Curso en grupo---------------------------------------------------------------
IF ( OBJECT_ID('consultar_costo_grupo') IS NOT NULL ) 
   DROP PROCEDURE consultar_costo_curso
GO

CREATE PROCEDURE consultar_costo_grupo
       @cod_curso int
     
                     
AS 


BEGIN 
    
    SET NOCOUNT ON 
	SELECT c.costo 
	FROM dbo.cursos c INNER JOIN
	 dbo.grupos g on c.cod_curso = g.cod_curso
	WHERE g.cod_grupo = @cod_curso
	
END 





-- Consultar codigo Descuento ---------------------------------------------------------------
IF ( OBJECT_ID('consultar_cod_descuento') IS NOT NULL ) 
   DROP PROCEDURE consultar_cod_descuento
GO

CREATE PROCEDURE consultar_cod_descuento
       @nombre varchar(50)
     
                     
AS 


BEGIN 
    
    SET NOCOUNT ON 
	SELECT cod_descuento FROM dbo.descuentos
	WHERE nombre = @nombre

    

END 






-- Consultar Porcentaje Descuento ---------------------------------------------------------------
IF ( OBJECT_ID('consultar_porcentaje_descuento') IS NOT NULL ) 
   DROP PROCEDURE consultar_porcentaje_descuento
GO

CREATE PROCEDURE consultar_porcentaje_descuento
       @cod_descuento int
     
                     
AS 


BEGIN 
    
    SET NOCOUNT ON 
	SELECT porcentaje FROM dbo.descuentos
	WHERE cod_descuento = @cod_descuento

    

END 




-- Consultar codigo Periodo ---------------------------------------------------------------
IF ( OBJECT_ID('consultar_cod_periodo') IS NOT NULL ) 
   DROP PROCEDURE consultar_cod_periodo
GO

CREATE PROCEDURE consultar_cod_periodo
       @nombre varchar(50)
     
                     
AS 


BEGIN 
    
    SET NOCOUNT ON 
	SELECT cod_periodo FROM dbo.periodos
	WHERE nombre = @nombre

    

END 












-- Consultar codigo Forma de Pago ---------------------------------------------------------------
IF ( OBJECT_ID('consultar_cod_formaPago') IS NOT NULL ) 
   DROP PROCEDURE consultar_cod_formaPago
GO

CREATE PROCEDURE consultar_cod_formaPago
       @nombre varchar(50)
     
                     
AS 


BEGIN 
    
    SET NOCOUNT ON 
	SELECT cod_formapago FROM dbo.formas_de_pago
	WHERE nombre = @nombre

    

END 








-- Obtener todo Grupo por Periodo ---------------------------------------------------------------
IF ( OBJECT_ID('GrupoPorPeriodo') IS NOT NULL ) 
   DROP PROCEDURE GrupoPorPeriodo
GO

CREATE PROCEDURE GrupoPorPeriodo
       @nombre nvarchar(50)
                     
AS 

DECLARE 
@cod int 

BEGIN 
    
    SET NOCOUNT ON 
	SELECT        'G' + CONVERT(char(2), g.numero) + c.nombre AS Curso,
	REPLACE(p.nombre, ' ', '') + ' ' + REPLACE(p.apellido1, ' ', '') + ' ' + REPLACE(p.apellido2, ' ', '') AS Profesor,
	pe.nombre AS Periodo,
	g.cod_grupo AS Codigo,
	c.cod_curso AS CodigoCurso
	FROM            grupos AS g 
	INNER JOIN
	cursos AS c ON g.cod_curso = c.cod_curso 
	INNER JOIN
	profesores AS p ON g.cod_profesor = p.cod_profesor 
	INNER JOIN
	periodos AS pe ON g.cod_periodo = pe.cod_periodo
	WHERE pe.nombre = @nombre 

    

END 





-- Obtener todo Matriculas por Periodo ---------------------------------------------------------------
IF ( OBJECT_ID('matriculaPorPeriodo') IS NOT NULL ) 
   DROP PROCEDURE matriculaPorPeriodo
GO

CREATE PROCEDURE matriculaPorPeriodo
       @nombre nvarchar(50)
                     
AS 

BEGIN 
    
    SET NOCOUNT ON 
	SELECT
p.nombre as Periodo,
'G' + CONVERT(char(2), g.numero) + c.nombre AS Curso,  
REPLACE(a.nombre, ' ', '') + ' ' + REPLACE(a.apellido1, ' ', '') + ' ' + REPLACE(a.apellido2, ' ',  '') AS Estudiante,
f.total as Total,
convert(varchar,d.porcentaje) +'%'  as Descuento,
f.saldo_pendiente as Saldo


FROM dbo.matriculas m

INNER JOIN grupos g on m.cod_grupo = g.cod_grupo
INNER JOIN cursos c on g.cod_curso = c.cod_curso
INNER JOIN periodos p on g.cod_periodo = p.cod_periodo
INNER JOIN alumnos a on m.cod_alumno = a.cod_alumno
INNER JOIN facturas f on f.cod_matricula = m.cod_matricula
INNER JOIN descuentos d on d.cod_descuento = f.cod_descuento
	WHERE p.nombre = @nombre 

    

END 




-- Obtener todo Profesores nombres y apellidos ---------------------------------------------------------------
IF ( OBJECT_ID('ProfesoresPorNombreYApellidos') IS NOT NULL ) 
   DROP PROCEDURE ProfesoresPorNombreYApellidos
GO

CREATE PROCEDURE ProfesoresPorNombreYApellidos
       
                     
AS 

BEGIN 
    
    SET NOCOUNT ON 
SELECT   cod_profesor as Codigo, cedula,
REPLACE(nombre, ' ', '') + ' ' + REPLACE(apellido1, ' ', '') + ' ' + REPLACE(apellido2, ' ', '') AS Profesor,
telefono AS Telefono,
correo AS Correo
FROM  profesores

    

END 

exec ProfesoresPorNombreYApellidos
select * from alumnos