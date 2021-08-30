
--Supported File Practice
--1. Write a query to find the names (first_name, last_name) and salaries of the employees who have higher salary than the employee whose last_name='Bull'. 
SELECT FirstName, LastName, Salary FROM Employees 
WHERE Salary > (SELECT Salary FROM Employees WHERE LastName = 'Bull')

--2. Find the names (first_name, last_name) of all employees who works in the IT department. 
SELECT * FROM Employees
SELECT * FROM Departments
SELECT * FROM Locations
SELECT FirstName, LastName From Employees WHERE DepartmentID IN (SELECT DepartmentID From Departments WHERE DepartmentName = 'IT')

--3. Find the names (first_name, last_name) of the employees who have a manager who works for a department based in United States. 
--Hint : Write single-row and multiple-row subqueries
SELECT FirstName, LastName FROM Employees 
WHERE ManagerID IN (SELECT ManagerID FROM Departments WHERE ManagerID > 0 AND
 LocationID IN (SELECT LocationID FROM Locations WHERE CountryID = 'US'))

--4. Find the names (first_name, last_name) of the employees who are managers. 

--5. Find the names (first_name, last_name), salary of the employees whose salary is greater than the average salary. 
SELECT FirstName, LastName, Salary FROM Employees WHERE Salary > (SELECT AVG(Salary) FROM Employees)

--6. Find the names (first_name, last_name), salary of the employees whose salary is equal to the minimum salary for their job grade. 
SELECT FirstName, LastName, Salary FROM Employees WHERE Salary = (SELECT MIN(Salary) FROM Employees)

--7. Find the names (first_name, last_name), salary of the employees who earn more than the average salary and who works in any of the IT departments. 
SELECT FirstName, LastName, Salary FROM Employees 
WHERE Salary > (SELECT AVG(Salary) FROM Employees) AND 
DepartmentID IN (SELECT DepartmentID FROM Departments WHERE DepartmentName LIKE 'IT%')

--8. Find the names (first_name, last_name), salary of the employees who earn more than Mr. Bell. 
SELECT FirstName, LastName, Salary FROM Employees 
WHERE Salary > (SELECT Salary FROM Employees WHERE LastName = 'Bell')

--9. Find the names (first_name, last_name), salary of the employees who earn the same salary as the minimum salary for all departments. 
SELECT FirstName, LastName, Salary FROM Employees 
WHERE Salary = All (SELECT MIN(Salary) FROM Employees)

--10. Find the names (first_name, last_name), salary of the employees whose salary greater than average salary of all department. 
SELECT FirstName, LastName, Salary FROM Employees 
WHERE Salary > All (SELECT AVG(Salary) FROM Employees) 

--11. Write a query to find the names (first_name, last_name) and salary of the employees who earn a salary that is higher than the salary of all the Shipping Clerk (JOB_ID = 'SH_CLERK'). Sort the results on salary from the lowest to highest. 
SELECT FirstName, LastName, Salary FROM Employees 
WHERE Salary > All (SELECT Salary FROM Employees WHERE JobId = 'SH_CLERK') ORDER BY Salary

--12. Write a query to find the names (first_name, last_name) of the employees who are not supervisors. 
SELECT FirstName, LastName FROM Employees 
WHERE JobId IN (SELECT JobId FROM Jobs WHERE JobTitle != 'Supervisors') 

--13. Write a query to display the employee ID, first name, last names, and department names of all employees. 
SELECT All e.EmployeeID, e.FirstName, e.LastName, d.DepartmentName FROM Employees AS e 
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID

--14. Write a query to display the employee ID, first name, last names, salary of all employees whose salary is above average for their departments. 

--16. Write a query to find the 5th maximum salary in the employees table. 

SELECT * FROM Employees e1 
WHERE 5 = (SELECT COUNT(Distinct Salary) FROM Employees e2 WHERE e2.Salary >= e1.Salary)

--17. Write a query to find the 4th minimum salary in the employees table. 

