-- example given by mam
-- display name PROCEDURE
-- use ' SET SERVEROUTPUT ON'
CREATE OR REPLACE PROCEDURE DISPLAY (NAME IN VARCHAR) IS
BEGIN
    DBMS_OUTPUT.PUT_LINE('HELLO '||NAME||'');
END;
/
-- CALL PROCEDURE 
EXECUTE DISPLAY('PARTH');
-- ADD TWO NUMBER PRODECURES
CREATE OR REPLACE PROCEDURE ADDTWO (A IN INT,B IN INT,C OUT INT) IS 
BEGIN
    C:=A+B;
END;
/
DECLARE
C INT;
BEGIN
    ADDTWO(10,20,C);
    DBMS_OUTPUT.PUT_LINE('SUM IS '|| C );
END;
/
-- q3 
CREATE OR REPLACE PROCEDURE ADDTWO () IS 
BEGIN
    SELECT COUNT(*) from ACCIDENT 
    where extract (Year from accd_date) = '2020';
END;
/
-- q4
CREATE OR REPLACE PROCEDURE Q3 () IS 
CURSOR Q3_CURSER IS
    SELECT COUNT(*) from ACCIDENT 
    where extract (Year from accd_date) = '2020';
BEGIN
OPEN Q3_CURSER
LOOP 
FETCH 
select sum(damage_amount) from PARTICIPATED where 