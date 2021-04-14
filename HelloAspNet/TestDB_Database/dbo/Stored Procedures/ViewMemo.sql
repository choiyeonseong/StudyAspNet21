
--[c] 메모 상세 보기용 저장 프로시저
Create Proc dbo.ViewMemo
(
	@Num Int
)
As
	Select Num, Name, Email, Title, PostDate, PostIP 
	From Memos 
	Where Num = @Num
