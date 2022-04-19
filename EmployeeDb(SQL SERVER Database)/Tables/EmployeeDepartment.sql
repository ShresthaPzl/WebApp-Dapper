CREATE TABLE [dbo].[EmployeeDepartment](
	[Employee_Id] [int] NULL,
	[Department_Id] [int] NULL
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[EmployeeDepartment]  WITH CHECK ADD FOREIGN KEY([Department_Id])
REFERENCES [dbo].[Department] ([Department_Id])
GO

ALTER TABLE [dbo].[EmployeeDepartment]  WITH CHECK ADD FOREIGN KEY([Employee_Id])
REFERENCES [dbo].[Employee] ([Id])
GO


