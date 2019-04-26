CREATE VIEW [dbo].[MachineByGroupView]
AS
(
	SELECT A.Id, A.Machine, B.Name NameMachine, A.[Group], C.Name NameGroup 
	FROM dbo.MachineByGroup A
	LEFT JOIN dbo.Machine B ON A.Machine = B.Id
	LEFT JOIN dbo.[Group] C ON A.[Group] = C.Id
)
