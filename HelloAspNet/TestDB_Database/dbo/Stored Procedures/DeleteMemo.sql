
--[e] 메모 데이터 삭제용 저장 프로시저
Create Proc dbo.DeleteMemo
(
	@Num Int
)
As
	Delete Memos
	Where Num = @Num
