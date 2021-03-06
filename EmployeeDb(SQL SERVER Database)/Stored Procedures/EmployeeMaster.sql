CREATE PROCEDURE [dbo].[EmployeeMaster]
	@Id INT = NUll,
	@Name VARCHAR(50) = NULL,
	@Country VARCHAR(25) = NUll,
	@City VARCHAR(20) = NULL,
	@Phone VARCHAR(15) = NULL,
	@Department_Id INT = NULL,
	@Department_Name VARCHAR(50) = NULL,
	@Flag NVARCHAR(MAX) = ''

AS
BEGIN
	IF(@Flag = 'ListE')
	BEGIN
		SELECT * From Employee E
		INNER JOIN EmployeeDepartment ED
		ON Id = Ed.Employee_Id
		INNER JOIN Department D
		ON D.Department_Id = ED.Department_Id
		SELECT 1 as Status,'Employee Listed Successfully!' as Message
	END

	IF(@Flag = 'InsertE')
	BEGIN
		INSERT INTO Employee(
			Name,
			Country,
			City,
			Phone

		) VALUES (
			@Name,
			@Country,
			@City,
			@Phone
		)
		DECLARE @eId INT
		SELECT @eId= SCOPE_IDENTITY();
		INSERT INTO EmployeeDepartment(Employee_Id, Department_Id)
		VALUES (@eId, @Department_Id)
		SELECT 1 as Status,'Employee: '+ @Name +' Inserted Successfully!' as Message
	END

	IF(@Flag = 'DeleteE')
	BEGIN
		DELETE FROM EmployeeDepartment Where Employee_Id = @Id
		DELETE FROM Employee WHERE Id = @Id
		SELECT 1 as Status,'Employee Deleted Successfully!' as Message
	END

	IF(@Flag = 'DetailE')
	BEGIN
		SELECT E.*, ED.Department_Id FROM Employee E
		INNER JOIN EmployeeDepartment ED
		ON id = ED.Employee_Id 
		WHERE Id = @Id

	END

	IF(@Flag = 'UpdateE')
	BEGIN
		UPDATE Employee SET
			Name = @Name,
			Country = @Country,
			City = @City,
			Phone = @Phone
			WHERE Id = @Id
			UPDATE EmployeeDepartment SET
			 Department_Id = @Department_Id
			WHERE Employee_Id = @Id
			SELECT 1 as Status,'Employee: '+ @Name +' Updated Successfully!' as Message
	END	


	--------------For Department--------------

	-------------------------------- FOR DEPARTMENT------------------------
	
	-- SELECT STATEMENT

	IF(@Flag = 'Select')
	BEGIN
		SELECT * FROM Department
	END


	IF(@Flag = 'DetailD')
	BEGIN
		SELECT * FROM Department
		WHERE Department_Id = @Department_Id
	END


	-- INSERT STATEMENT 
	IF(@Flag = 'InsertD')
	BEGIN
		INSERT INTO Department(
			Department_name
		) VALUES (
			@Department_Name
		)
		SELECT 1 as Status,'Department: '+ @Department_Name +' Created Successfully!' as Message 

	END

	-- UPDATE STATEMENT 
	IF(@Flag = 'UpdateD')
	BEGIN
		UPDATE Department SET
			Department_Name = @Department_Name
			WHERE Department_Id = @Department_Id
			SELECT 1 as Status,'Department: '+ @Department_Name +' Updated Successfully!' as Message
	END

	-- DELETE STATEMENT
	IF(@Flag = 'DeleteD')
	BEGIN
		DELETE FROM EmployeeDepartment WHERE Department_Id = @Department_Id
		DELETE FROM Department WHERE Department_Id = @Department_Id
		SELECT 1 as Status,'Department Deleted Successfully!' as Message
	END

END