

  


-- Profesores

SELECT  cod_profesor as Codigo , cedula as Cédula,
REPLACE(nombre, ' ', '') + ' ' + REPLACE(apellido1, ' ', '') + ' ' + REPLACE(apellido2, ' ', '') AS Profesor,
telefono AS Telefono,
correo AS Correo
FROM  profesores



select * from profesores
-- Grupos

SELECT  'G' + CONVERT(char(2), g.numero) + c.nombre AS Curso, 
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

  
  -- Matriculas                       
                         
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



select * from grupos

delete from grupos where numero = 1