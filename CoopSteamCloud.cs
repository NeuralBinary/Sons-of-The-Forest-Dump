using System;
using Il2CppDummyDll;

// Token: 0x020000D4 RID: 212
[Token(Token = "0x20000D4")]
public static class CoopSteamCloud
{
	// Token: 0x0600064F RID: 1615 RVA: 0x00003CF0 File Offset: 0x00001EF0
	[Token(Token = "0x600064F")]
	[Address(RVA = "0x2E7F010", Offset = "0x2E7E010", VA = "0x182E7F010")]
	public static bool ShouldUseCloud()
	{
		return default(bool);
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000650")]
	[Address(RVA = "0x2E7EF40", Offset = "0x2E7DF40", VA = "0x182E7EF40")]
	public static string[] ListFiles()
	{
		return null;
	}

	// Token: 0x06000651 RID: 1617 RVA: 0x00003D08 File Offset: 0x00001F08
	[Token(Token = "0x6000651")]
	[Address(RVA = "0x2E7EEC0", Offset = "0x2E7DEC0", VA = "0x182E7EEC0")]
	public static bool CloudSave(string filename, byte[] buffer)
	{
		return default(bool);
	}

	// Token: 0x06000652 RID: 1618 RVA: 0x00003D20 File Offset: 0x00001F20
	[Token(Token = "0x6000652")]
	[Address(RVA = "0x2E7EDF0", Offset = "0x2E7DDF0", VA = "0x182E7EDF0")]
	public static bool CloudFileExist(string filename)
	{
		return default(bool);
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00003D38 File Offset: 0x00001F38
	[Token(Token = "0x6000653")]
	[Address(RVA = "0x2E7EF10", Offset = "0x2E7DF10", VA = "0x182E7EF10")]
	public static long CloudTimestamp(string filename)
	{
		return default(long);
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000654")]
	[Address(RVA = "0x2E7EE20", Offset = "0x2E7DE20", VA = "0x182E7EE20")]
	public static byte[] CloudLoad(string filename)
	{
		return null;
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00003D50 File Offset: 0x00001F50
	[Token(Token = "0x6000655")]
	[Address(RVA = "0x2E7EDC0", Offset = "0x2E7DDC0", VA = "0x182E7EDC0")]
	public static bool CloudDelete(string filename)
	{
		return default(bool);
	}
}
