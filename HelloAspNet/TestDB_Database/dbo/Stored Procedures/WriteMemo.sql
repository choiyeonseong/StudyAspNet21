

--[3] SQL 저장 프로시저 6가지 작성

--[a] 메모 입력용 저장 프로시저
CREATE Procedure [dbo].[WriteMemo]
(
	@Name NVarChar(25),
	@Email NVarChar(100),
	@Title NVarChar(150),
	@PostDate DateTime,
	@PostIP NVarChar(15)
)
As
	Insert Memos(Name, Email, Title, PostDate, PostIP)
	Values(@Name, @Email, @Title, @PostDate, @PostIP)
