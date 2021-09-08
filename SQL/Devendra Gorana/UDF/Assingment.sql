--Assingment 1
--Create a scaler Function to compute PF which will accept parameter basicsalary and compute PF. PF is 12% of the basic salary.

CREATE FUNCTION PF_Cal (@BasicSalary int) 
RETURNS float 
AS
BEGIN 
	RETURN (@BasicSalary * 0.12)
END
Go

PRINT PF_Cal (1000)

CREATE FUNCTION PF (EmpID int)  
RETURNS int   
AS   
-- Returns the stock level for the product.  
BEGIN  
DECLARE @salary int;  
    SELECT @salary = (Salary * 0.12) FROM Employees 
    WHERE EmployeeID = @EmpID   
       
    
    RETURN @salary;
END
GO

SELECT FirstName, LastName, Salary, PF (EmployeeID) AS Pf FROM Employees
