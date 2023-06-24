using System;
using Il2CppDummyDll;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
[Serializable]
public class SunTime
{
	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0xAB20D0", Offset = "0xAB06D0", VA = "0x180AB20D0")]
	public void SetFromDateTime(DateTime dateTime)
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0xAB2230", Offset = "0xAB0830", VA = "0x180AB2230")]
	public SunTime()
	{
	}

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x10")]
	public int year;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x14")]
	public int month;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x18")]
	public int day;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x1C")]
	public int hour;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x20")]
	public int minute;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x24")]
	public int second;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x28")]
	public int millisecond;
}
