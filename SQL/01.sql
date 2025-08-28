/*
 * Escribe un programa que muestre por consola (con un print) los
 * números de 1 a 100 (ambos incluidos y con un salto de línea entre
 * cada impresión), sustituyendo los siguientes:
 * - Múltiplos de 3 por la palabra "fizz".
 * - Múltiplos de 5 por la palabra "buzz".
 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
 */
DECLARE @i INT
SET @i = 1
WHILE @i < 101
BEGIN
    IF (@i % 3 = 0 AND @i % 5 = 0)
        PRINT 'fizzbuzz'
    ELSE IF (@i % 3 = 0)
        PRINT 'fizz'
    ELSE IF (@i % 5 = 0)
        PRINT 'buzz'
    ELSE
        PRINT @i
    SET @i = @i + 1
END