SELECT * FROM Employees
SELECT * FROM Incentive
SELECT FirstName, Salary FROM Employees
WHERE Salary < (SELECT AVG(Salary) FROM Employees)

SELECT FirstName, Salary FROM Employees WHERE Salary > (SELECT AVG(Salary) FROM Employees WHERE FirstName = 'john')	

--Select employee details from employee table if data exists in incentive table ?
SELECT * FROM Employees WHERE EXISTS (SELECT * FROM Incentive WHERE EmployeeID = Employees.EmployeeID)

--Find Salary of the employee whose salary is more than Roy Salary
UPDATE Employees SET Salary = 10000 WHERE EmployeeID = 101
SELECT * FROM Employees WHERE Salary > (SELECT Salary FROM Employees WHERE FirstName = 'Roy') 
